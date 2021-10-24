using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olleroif.Models
{
	public class Blog
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public string ImageUrl { get; set; }
		public int EmployeeId { get; set; }
		public Employee Employee { get; set; }
		public DateTime Date { get; set; }
		public BlogDetail BlogDetail { get; set; }
		

	}
}
