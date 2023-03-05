using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using shopOnline.Models;
using shopOnline.GHTK;
using Newtonsoft.Json;
using System.IO;
using shopOnline.Extension;

namespace shopOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminOrdersController : Controller
    {
        private readonly shopOnlineContext _context;

        public AdminOrdersController(shopOnlineContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminOrders
        public async Task<IActionResult> Index(bool confirmed=false)
        {
            var order = await _context.Orders.Where(x => x.Confirmed == confirmed && !x.Deleted)
                .Include(x => x.CustomerProvinceCodeNavigation)
                .Include(x => x.CustomerDistrictCodeNavigation)
                .Include(x => x.CustomerWardCodeNavigation)
                .ToListAsync();
            ViewBag.confirmed = confirmed;
            return View(order);
        }


        // GET: Admin/AdminOrders/Details/5
        public async Task<IActionResult> Details(int id)
        {
            Order order = await _context.Orders.FindAsync(id);
            if (order == null || order.Deleted)
            {
                return NotFound();
            }
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
                ViewBag.message = (string)json_result["order"]["message"];
            } else
            {
                ViewBag.status = "Đơn hàng chưa được xác nhận";
            }
            ViewBag.OrderDetails = _context.OrderDetails.Where(x => x.OrderId == order.OrderId).Include(x => x.Product).ToList();
            return View(order);
        }


        [Route("api/deleteOrder")]
        [HttpPost]
        public IActionResult DeleteOrder(int id)
        {
            Order order = _context.Orders.Find(id);
            if (order != null && !order.Confirmed)
            {
                order.Deleted = true;
                _context.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

        [Route("api/OrderToGHTK")]
        [HttpPost]
        public IActionResult postOrderToGHTK(int id)
        {
            Order order = _context.Orders.Find(id);
            if (order != null && !order.Deleted && !order.Confirmed)
            {
                infoDH info = new infoDH();
                foreach(OrderDetail od in _context.OrderDetails.Where(x => x.OrderId == id).Include(x => x.Product))
                {
                    info.products.Add(new info_products
                    {
                        name = od.Product.ProductName,
                        quantity = od.Quantity,
                        weight = od.Product.Weight.Value * od.Quantity
                    });
                }
                info.order.name = order.CustomerName;
                info.order.address = order.CustomerAddress;
                info.order.ward = _context.Wards.Find(order.CustomerWardCode).Name;
                info.order.district = _context.Districts.Find(order.CustomerDistrictCode).Name;
                info.order.province = _context.Provinces.Find(order.CustomerProvinceCode).Name;
                info.order.tel = order.CustomerTel;
                info.order.email = order.CustomerEmail;
                info.order.id = order.OrderId.ToString();
                info.order.is_freeship = (order.Prepaid ? 1 : 0);
                info.order.note = order.Note;
                info.order.pick_money = (order.Prepaid ? 0 : order.TotalMoney);
                info.order.value = order.InsuranceFeeGhtk.Value;

                string json = JsonConvert.SerializeObject(info);
                string result = API_GHTK.postOrderAsync(json).Result;
                dynamic json_result = JsonConvert.DeserializeObject(result);
                if ((bool)json_result["success"])
                {
                    Email.sendMail(order.CustomerEmail, "ShopOnline - Đơn hàng đã xác nhận", "Đơn hàng có mã " + order.OrderId + " của bạn đã được xác nhận");
                    order.LabelGhtk = (string)json_result["order"]["label"];
                    order.Confirmed = true;
                    _context.SaveChanges();
                    return Json(new { success = true });
                }
            }
            return Json(new { success = false });
        }


        [Route("api/cancelOrder")]
        [HttpPost]
        public IActionResult cancelOrder(int id)
        {
            Order order = _context.Orders.Find(id);
            if (order != null && !order.Deleted && order.Confirmed)
            {

                string result = API_GHTK.cancelOrderAsync(order.LabelGhtk).Result;
                dynamic json_result = JsonConvert.DeserializeObject(result);
                if ((bool)json_result["success"])
                {
                    return Json(new { success = true });
                }
            }
            return Json(new { success = false });
        }

        public IActionResult printOrder(int id)
        {
            Order order = _context.Orders.Find(id);
            if(order != null)
            {
                Stream stream = API_GHTK.printOrderStatusAsync(order.LabelGhtk).Result;
                return File(stream, "application/pdf", "");
            }
            return NotFound();
        }
    }
}
