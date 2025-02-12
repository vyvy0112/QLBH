using Microsoft.AspNetCore.Mvc;

namespace QLBH_DT.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
