using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Olleroif.DataAccessLayer;
using Olleroif.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olleroif.Controllers
{
	public class BlogController : Controller
	{
		private readonly AppDbContext _db;
		public BlogController(AppDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			List<Blog> blogs = _db.Blogs.OrderByDescending(b => b.Id).Take(3).ToList();

			return View(blogs);
		}
		public IActionResult Detail(int id)
		{
			Blog blog = _db.Blogs.Include(b => b.BlogDetail).Include(b => b.Employee).FirstOrDefault(b => b.Id == id);

			if (blog != null && id != null)
			{
				return View(blog);
			}

			return NotFound();
		}
	}
}
