using Microsoft.AspNetCore.Mvc;
using Olleroif.DataAccessLayer;
using Olleroif.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olleroif.ViewComponents
{
	public class HeaderViewComponent : ViewComponent
	{
		private readonly AppDbContext _db;
		public HeaderViewComponent(AppDbContext db)
		{
			_db = db;
		}
		public IViewComponentResult Invoke()
		{
			Setting settings = _db.Settings.FirstOrDefault<Setting>();
			return View(settings);
		}
	}
}
