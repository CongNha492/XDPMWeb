using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PagedList.Core;
using shopOnline.Models;
using shopOnline.Helpper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace shopOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly shopOnlineContext _context;

        public HomeController(ILogger<HomeController> logger, shopOnlineContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index([FromQuery]int? catID, [FromQuery]string search, int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = Utilities.PAGE_SIZE;
            int categoryID = catID == null ? -1 : catID.Value;
            IQueryable<Product> product;
            ViewBag.Category = _context.Categories.AsNoTracking().Where(x => !x.Deleted && x.Published);
            ViewBag.catID = categoryID;
            ViewBag.search = search;
            product = _context.Products.Where(
                x => !x.Deleted && !x.Category.Deleted
                && x.Published && x.Category.Published
                && (categoryID == -1 ? true : x.CategoryId == categoryID)
                && (search == null ? true : x.ProductName.Contains(search))
            );
            PagedList<Product> models = new PagedList<Product>(product, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }

        [Route("details")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _context.Products
                .Include(p => p.Category)
                .FirstOrDefault(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            List<Product> products_category = _context.Products.Where(
                p => p.CategoryId == product.CategoryId
                && p.Published
                && p.Id != product.Id
            ).ToList();
            var rand = new Random();
            int i = 0, r;
            List<Product> related_products = new List<Product>();
            while (products_category.Count > 0 && i < 3)
            {
                r = rand.Next(0, products_category.Count);
                related_products.Add(products_category[r]);
                products_category.RemoveAt(r);
                i++;
            }

            ViewBag.related_products = related_products;

            return View(product);
        }

        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("order_lookup")]
        public IActionResult order_lookup(int id)
        {
            ViewBag.id = id;
            Order order = _context.Orders.Find(id);
            if (order != null && !order.Deleted)
            {
                ViewBag.p = _context.Provinces.Find(order.CustomerProvinceCode).Name;
                ViewBag.d = _context.Districts.Find(order.CustomerDistrictCode).Name;
                ViewBag.w = _context.Wards.Find(order.CustomerWardCode).Name;
                if (order.Confirmed)
                {
                    string result = GHTK.API_GHTK.getOrderStatusAsync(order.LabelGhtk).Result;
                    dynamic json_result = JsonConvert.DeserializeObject(result);
                    string stutus = (string)json_result["order"]["status_text"];
                    ViewBag.status = stutus;
                    ViewBag.deliver_date = stutus != "Hủy đơn hàng" ? (string)json_result["order"]["deliver_date"] : "";
                }
                else
                {
                    ViewBag.status = "Đơn hàng chưa được xác nhận";
                }
                
                ViewBag.OrderDetails = _context.OrderDetails.Where(x => x.OrderId == order.OrderId).Include(x => x.Product);
            }
            return View(order);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
