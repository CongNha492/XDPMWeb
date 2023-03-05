using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopOnline.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using shopOnline.GHTK;
using shopOnline.Extension;
using shopOnline.VNPAY;
using shopOnline.Helpper;
using System.Net.Mail;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace shopOnline.Models
{
    public class ShoppingCartController : Controller
    {
        private readonly shopOnlineContext _context;
        public INotyfService _notyfService { get; }
        public ShoppingCartController(shopOnlineContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        public List<CartItem> GioHang
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (gh == default(List<CartItem>))
                {
                    gh = new List<CartItem>();
                }
                return gh;
            }
        }

        [HttpPost]
        [Route("api/cart/add")]
        public IActionResult AddToCart(int productID, int? amount)
        {
            List<CartItem> cart = GioHang;

            try
            {
                //Them san pham vao gio hang
                CartItem item = cart.SingleOrDefault(p => p.product.Id == productID);
                if (item != null) // da co => cap nhat so luong
                {
                    item.amount = item.amount + amount.Value;
                    //luu lai session
                    HttpContext.Session.Set<List<CartItem>>("GioHang", cart);
                }
                else
                {
                    Product hh = _context.Products.SingleOrDefault(p => p.Id == productID);
                    item = new CartItem
                    {
                        amount = amount.HasValue ? amount.Value : 1,
                        product = hh
                    };
                    cart.Add(item);//Them vao gio
                }

                //Luu lai Session
                HttpContext.Session.Set<List<CartItem>>("GioHang", cart);
                _notyfService.Success("Thêm sản phẩm thành công");
                return Json(new { success = true });
            }
            catch 
            {
                return Json(new { success = false });
            }
        }
        [HttpPost]
        [Route("api/cart/update")]
        public IActionResult UpdateCart(int productID,int? amount)
        {
            //Lay gio hang ra de xu ly
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            try
            {
                if (cart != null)
                {
                    CartItem item = cart.SingleOrDefault(p => p.product.Id == productID);
                    if (item != null && amount.HasValue) // da co -> cap nhat so luong
                    {
                        if (amount.Value > 0) item.amount = amount.Value;
                        else cart.Remove(item);
                    }
                    //Luu lai session
                    HttpContext.Session.Set<List<CartItem>>("GioHang", cart);
                }
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        [Route("api/cart/remove")]
        public ActionResult Remove(int productID)
        {
            
            try
            {
                List<CartItem> gioHang = GioHang;
                CartItem item = gioHang.SingleOrDefault(p => p.product.Id == productID);
                if (item != null)
                {
                    gioHang.Remove(item);
                }
                //luu lai session
                HttpContext.Session.Set<List<CartItem>>("GioHang", gioHang);
                return Json(new { success = true });
            }
            catch 
            {
                return Json(new { success = false });
            }
        }
        [Route("api/cart/removecart")]
        public ActionResult RemoveCart()
        {

            try
            {
                HttpContext.Session.Set<List<CartItem>>("GioHang", null);
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }

        [Route("getlistdistricts")]
        public IActionResult getListDistricts(string provinceCode)
        {
            ViewBag.districts = _context.Districts.Where(x => x.ProvinceCode == provinceCode).OrderBy(x => x.Name);
            return PartialView();
        }

        [Route("getlistwards")]
        public IActionResult getListWards(string districtCode)
        {
            ViewBag.wards = _context.Wards.Where(x => x.DistrictCode == districtCode).OrderBy(x => x.Name);
            return PartialView();
        }



        [Route("/api/getfeeship")]
        public ContentResult FeeShip(string province_code, string district_code)
        {
            Province p = _context.Provinces.Find(province_code);
            District d = _context.Districts.Find(district_code);
            if (p == null || d == null)
            {
                return Content("");
            }
            double weight = GioHang.Sum(x => x.TotalWeight);
            dynamic result_json = JsonConvert.DeserializeObject(API_GHTK.getFeeShipAsync(p.Name, d.Name, weight).Result);
            return Content((string)result_json["fee"]["fee"]);
        }


        [Route("cart")]
        public IActionResult Index()
        {
            return View(GioHang);
        }

        [Route("cart/checkout")]
        public IActionResult checkout()
        {
            if (GioHang.Count == 0) return RedirectToAction("Index", "Home");
            ViewBag.provinces = new SelectList(_context.Provinces.OrderBy(x => x.Name), "Code", "Name");
            ViewBag.GioHang = GioHang;
            return View();
        }

        public void AddCartToDB()
        {
            Order order = HttpContext.Session.Get<Order>("order");
            order.OrderDate = Utilities.getTimeZoneVietNam();
            order.TotalMoney = GioHang.Sum(x => x.TotalMoney);
            foreach (CartItem c in GioHang)
            {
                OrderDetail od = new OrderDetail
                {
                    ProductId = c.product.Id,
                    Quantity = c.amount
                };
                order.OrderDetails.Add(od);
            }

            double weight = GioHang.Sum(x => x.TotalWeight);
            dynamic result_json = JsonConvert.DeserializeObject(API_GHTK.getFeeShipAsync(
                    _context.Provinces.Find(order.CustomerProvinceCode).Name,
                    _context.Districts.Find(order.CustomerDistrictCode).Name, 
                    weight,
                    order.TotalMoney
            ).Result);
            order.InsuranceFeeGhtk = (int)(result_json["fee"]["insurance_fee"])+10000;
            order.FeeshipGhtk = (int)(result_json["fee"]["fee"]);


            _context.Orders.Add(order);
            _context.SaveChanges();
            Email.sendMail(order.CustomerEmail, "ShopOnline - Đơn hàng của bạn đã đặt thành công", "Mã đơn hàng của bạn là " + order.OrderId + ".\nĐể xem trạng thái đơn hàng thì bạn bấm mục \"Tra cứu đơn hàng\" trong trang web");
            HttpContext.Session.Set<List<CartItem>>("GioHang", null);
        }

        [Route("cart/order")]
        [HttpPost]
        public IActionResult Order(Order order)
        {
            if (ModelState.IsValid)
            {
                if (!Utilities.IsValidEmail(order.CustomerEmail))
                {
                    ModelState.AddModelError("CustomerEmail", "Email không đúng !");
                }
                else {
                    HttpContext.Session.Set("order", order);
                    if (order.Prepaid)
                    {
                        return RedirectToAction("Pay");
                    }
                    else
                    {
                        AddCartToDB();
                        ViewBag.email = order.CustomerEmail;
                        return View();
                    }
                }
            }
            if (GioHang.Count == 0) return RedirectToAction("Index", "Home");
            ViewBag.provinces = new SelectList(_context.Provinces.OrderBy(x => x.Name), "Code", "Name");
            ViewBag.GioHang = GioHang;
            return View("checkout");
        }

        public RedirectResult Pay()
        {
            string vnp_OrderInfo = "thanh toan don hang " + GioHang.Sum(x => x.TotalMoney).ToString("#,##0");
            string vnp_Returnurl = (HttpContext.Request.IsHttps ? "https://" : "http://") + HttpContext.Request.Host + "/cart/payreturn";

            //Build URL for VNPAY
            VnPayLibrary vnpay = new VnPayLibrary();

            vnpay.AddRequestData("vnp_Version", VnPayLibrary.VERSION);
            vnpay.AddRequestData("vnp_Command", "pay");
            vnpay.AddRequestData("vnp_TmnCode", VnPayLibrary.vnp_TmnCode);
            vnpay.AddRequestData("vnp_Amount", (GioHang.Sum(x => x.TotalMoney) * 100).ToString());

            vnpay.AddRequestData("vnp_CreateDate", Utilities.getTimeZoneVietNam().ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData("vnp_CurrCode", "VND");
            vnpay.AddRequestData("vnp_IpAddr", HttpContext.Connection.RemoteIpAddress.ToString());
            vnpay.AddRequestData("vnp_Locale", "vn");
            vnpay.AddRequestData("vnp_OrderInfo", vnp_OrderInfo);
            vnpay.AddRequestData("vnp_OrderType", "other");

            vnpay.AddRequestData("vnp_ReturnUrl", vnp_Returnurl);
            vnpay.AddRequestData("vnp_TxnRef", Utilities.getTimeZoneVietNam().Ticks.ToString());

            string url = vnpay.CreateRequestUrl(VnPayLibrary.vnp_Url, VnPayLibrary.vnp_HashSecret);
            return new RedirectResult(url: url, permanent: true, preserveMethod: true);
        }


        [Route("cart/payreturn")]
        public IActionResult payReturn()
        {
            if (HttpContext.Request.Query.Count > 0)
            {
                var vnpayData = HttpContext.Request.Query;
                VnPayLibrary vnpay = new VnPayLibrary();

                foreach (string s in vnpayData.Keys)
                {
                    if (!string.IsNullOrEmpty(s) && s.StartsWith("vnp_"))
                    {
                        vnpay.AddResponseData(s, vnpayData[s]);
                    }
                }
                //vnp_TxnRef: Ma don hang merchant gui VNPAY tai command=pay    
                //vnp_TransactionNo: Ma GD tai he thong VNPAY
                //vnp_ResponseCode:Response code from VNPAY: 00: Thanh cong, Khac 00: Xem tai lieu
                //vnp_SecureHash: HmacSHA512 cua du lieu tra ve

                long orderId = Convert.ToInt64(vnpay.GetResponseData("vnp_TxnRef"));
                long vnpayTranId = Convert.ToInt64(vnpay.GetResponseData("vnp_TransactionNo"));
                string vnp_ResponseCode = vnpay.GetResponseData("vnp_ResponseCode");
                string vnp_TransactionStatus = vnpay.GetResponseData("vnp_TransactionStatus");
                String vnp_SecureHash = HttpContext.Request.Query["vnp_SecureHash"];
                String TerminalID = HttpContext.Request.Query["vnp_TmnCode"];
                long vnp_Amount = Convert.ToInt64(vnpay.GetResponseData("vnp_Amount")) / 100;
                String bankCode = HttpContext.Request.Query["vnp_BankCode"];

                bool checkSignature = vnpay.ValidateSignature(vnp_SecureHash, VnPayLibrary.vnp_HashSecret);
                if (checkSignature)
                {
                    if (vnp_ResponseCode == "00" && vnp_TransactionStatus == "00")
                    {
                        //Thanh toan thanh cong
                        Order order = HttpContext.Session.Get<Order>("order");
                        AddCartToDB();
                        ViewBag.email = order.CustomerEmail;
                        return View("Order");
                    }
                    //else
                    //{
                    //    //Thanh toan khong thanh cong. Ma loi: vnp_ResponseCode
                    //    return NotFound();
                    //}
                }
                //else
                //{
                //    //Có lỗi xảy ra trong quá trình xử lý
                //    return NotFound();
                //}
            }
            _notyfService.Warning("Thanh toán thất bại");
            return RedirectToAction("checkout");
        }

    }
}
