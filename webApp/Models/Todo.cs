using System.ComponentModel.DataAnnotations;

namespace webApp.Models
{
	public class Todo
	{
	
		public int Id { get; set; }

		[Required(ErrorMessage = "ToDo name is important")]
		public string Name { get; set; }
		public string? Description { get; set; }

		public bool IsFineshed { get; set; }	

		public DateTime CreatedDate { get; set; }
		
	}
}
