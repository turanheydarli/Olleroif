using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Olleroif.Models
{
	public class BlogDetail
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public Blog Blog { get; set; }
		[ForeignKey("Blog")]
		public int BlogId { get; set; }
	}
}
