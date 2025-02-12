using QLBH_DT.Data;
using QLBH_DT.ViewComponents;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace QLBH_DT.ViewComponents
{
	public class CategoriesViewComponent : ViewComponent
	{
		private readonly QuanLyBanHangContext _context;

		public CategoriesViewComponent(QuanLyBanHangContext context)
		{
			_context = context;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var categories = await _context.Categories.ToListAsync();
			return View(categories);
		}
	}
}
