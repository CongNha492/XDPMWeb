using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using shopOnline.Models;
using shopOnline.Helpper;

namespace shopOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProductsController : Controller
    {
        private readonly shopOnlineContext _context;
        public INotyfService _notyfService { get; }
        public AdminProductsController(shopOnlineContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminProducts
        public async Task<IActionResult> Index()
        {
            var shopOnlineContext = _context.Products.Include(p => p.Category).Where(x => !x.Deleted && !x.Category.Deleted);
            return View(await shopOnlineContext.ToListAsync());
        }

        // GET: Admin/AdminProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/AdminProducts/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories.Where(x => !x.Deleted), "CategoryId", "CategoryName");
            return View();
        }

        // POST: Admin/AdminProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductName,CategoryId,ProductPrice,Weight,Description,BrandName,Published")] Product product, Microsoft.AspNetCore.Http.IFormFile fImage)
        {
            if (ModelState.IsValid)
            {
                product.ProductName = Utilities.ToTitleCase(product.ProductName);
                if (fImage != null)
                {
                    string extension = Path.GetExtension(fImage.FileName);
                    if (Utilities.IsSupportedTypes(extension))
                    {
                        string image = Utilities.SEOUrl(product.ProductName) + extension;
                        product.Image = await Utilities.UploadFile(fImage, @"products", image.ToLower());
                        if (string.IsNullOrEmpty(product.Image)) product.Image = "default.jpg";
                        if (product.ProductPrice < 20000000)
                        {
                            _context.Add(product);
                            await _context.SaveChangesAsync();
                            _notyfService.Success("Thêm sản phẩm thành công");
                        }
                        else
                        {
                            _notyfService.Warning("Thêm sản phẩm thất bại");
                        }
                        return RedirectToAction(nameof(Index));
                    } else
                    {
                        ModelState.AddModelError("Image", "Định dạng file không đúng hệ thống chỉ nhận các định dạng file sau : " + string.Join("; ", Utilities.supportedTypes));
                    }
                } else
                {
                    ModelState.AddModelError("Image", "Chưa chọn ảnh !");
                }
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories.Where(x => !x.Deleted), "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // GET: Admin/AdminProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories.Where(x => !x.Deleted), "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // POST: Admin/AdminProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductName,CategoryId,ProductPrice,Image,Weight,Description,BrandName,Published,Deleted")] Product product, Microsoft.AspNetCore.Http.IFormFile fImage)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                product.ProductName = Utilities.ToTitleCase(product.ProductName);
                bool showError = false;
                if (fImage != null)
                {
                    string extension = Path.GetExtension(fImage.FileName);
                    if (Utilities.IsSupportedTypes(extension))
                    {
                        string image = Utilities.SEOUrl(product.ProductName) + extension;
                        product.Image = await Utilities.UploadFile(fImage, @"products", image.ToLower());
                    } else
                    {
                        ModelState.AddModelError("Image", "Định dạng file không đúng hệ thống chỉ nhận các định dạng file sau : " + string.Join("; ", Utilities.supportedTypes));
                        showError = true;
                    }
                }
                if (!showError)
                {
                    if (string.IsNullOrEmpty(product.Image)) product.Image = "default.jpg";
                    if (product.ProductPrice < 20000000)
                    {
                        _context.Update(product);
                        _notyfService.Success("Cập nhật sản phẩm thành công");
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        _notyfService.Warning("Cập nhật sản phẩm thất bại");
                    }
                    return RedirectToAction(nameof(Index));
                }
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories.Where(x => !x.Deleted), "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // GET: Admin/AdminProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/AdminProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OrderDetails.Count(x => x.ProductId == id && !x.Order.Deleted) == 0)
            {
                var product = await _context.Products.FindAsync(id);
                product.Deleted = true;
                await _context.SaveChangesAsync();
                _notyfService.Success("Xóa sản phẩm thành công");
            }
            else
            {
                _notyfService.Warning("Không thể xóa sản phẩm này!");
            }

            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
