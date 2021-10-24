using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olleroif.Models
{
	public class Setting
	{
		public int Id { get; set; }
		public string SiteName { get; set; }
		public string HomeTitle { get; set; }
		public string Keyword { get; set; }
		public string FacebookUrl { get; set; }
		public string InstagramUrl { get; set; }
		public string LinkedinUrl { get; set; }
		public string PinterestUrl { get; set; }
		public string TumblrUrl { get; set; }
		public string Logo { get; set; }
	}
}
