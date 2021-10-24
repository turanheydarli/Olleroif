using Olleroif.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olleroif.ViewModels
{
	public class ProductVM
	{
		public List<Product> Products { get; set; }
		public List<ProductDetail> ProductDetails { get; set; }
	}
}
