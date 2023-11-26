using Microsoft.AspNetCore.Mvc;

namespace Railway_Group01.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
