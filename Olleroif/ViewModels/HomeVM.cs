﻿using Olleroif.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olleroif.ViewModels
{
	public class HomeVM
	{
		public Slider Slider { get; set; }
		public List<SliderImage> SliderImages { get; set; }
		public List<Category> Categories { get; set; }
		public List<Product> Products { get; set; }
		
	}
}
