using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Olleroif.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olleroif.DataAccessLayer
{
	public class AppDbContext : IdentityDbContext<User>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{

		}

		public DbSet<Setting> Settings { get; set; }
		public DbSet<Slider> Sliders { get; set; }
		public DbSet<SliderImage> SliderImages { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductDetail> ProductDetails { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<BlogDetail> BlogDetails { get; set; }
	}
}
