using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using QLBH_DT.Data;
using QLBH_DT.Models;

namespace QLBH_DT.Controllers
{
	public class CategoryController : Controller
	{

		private readonly QuanLyBanHangContext _context;

		public CategoryController(QuanLyBanHangContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var category = _context.Categories.ToList();
			var model = category.Select(c => new CategoryModel
			{
				CategoryId = c.CategoryId,
				CategoryName = c.CategoryName
			});
			return View(model);
		}
	}
}
