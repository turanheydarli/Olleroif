using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Olleroif.DataAccessLayer;
using Olleroif.Models;
using Olleroif.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Olleroif.Controllers
{
	public class HomeController : Controller
	{
		private readonly AppDbContext _db;
		public HomeController(AppDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			HomeVM homeVM = new HomeVM
			{
				Slider = _db.Sliders.FirstOrDefault<Slider>(),
				SliderImages = _db.SliderImages.ToList<SliderImage>(),
				Categories = _db.Categories.ToList<Category>(),
				Products = _db.Products.OrderByDescending(p => p.Id).Take(8).ToList<Product>(),

			};

			return View(homeVM);
		}

		[HttpPost]
		public IActionResult Search(string key)
		{
			List<Product> products = _db.Products.Where(p => p.Title.Contains(key)).ToList();

			return PartialView("_SearchPartial", products);
		}


	}
}
