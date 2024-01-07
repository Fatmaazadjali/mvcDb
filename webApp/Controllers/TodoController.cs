using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webApp.Data;

namespace webApp.Controllers
{
	public class TodoController : Controller
	{

		private readonly ApplicationDbContext _context;
		public TodoController(ApplicationDbContext context) {
            _context = context;

        }
		public IActionResult Index()
		{
			var todo = _context.todos.ToList();
			return View(todo);
		}
	}
}
