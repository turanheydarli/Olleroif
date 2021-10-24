using Microsoft.AspNetCore.Mvc;
using Olleroif.DataAccessLayer;
using Olleroif.ViewModels;
using Olleroif.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Olleroif.Controllers
{
	public class ProductController : Controller
	{
		private readonly AppDbContext _db;
		public ProductController(AppDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			ProductVM productVM = new ProductVM
			{
				Products = _db.Products.OrderByDescending(p => p.Id).Take(4).ToList(),
			};
			ViewBag.ProCount = _db.Products.Count();

			return View(productVM);
		}

		public IActionResult Detail(int id)
		{
			Product product = _db.Products.Include(p => p.ProductDetail).FirstOrDefault<Product>(p => p.Id == id);
			if (product != null && id != null)
			{
				return View(product);
			}

			return NotFound();
		}

		[HttpPost]
		public IActionResult LoadMore(int skip)
		{
			List <Product> products = _db.Products.OrderByDescending(p => p.Id).Skip(skip).Take(4).ToList<Product>();

			return PartialView("_ProductsPartial", products);
		}
	}
}
