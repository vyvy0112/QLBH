using QLBH_DT.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLBH_DT.Models;
namespace QLBH_DT.Repository.Components
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly QuanLyBanHangContext _context;

        public CategoriesViewComponent(QuanLyBanHangContext context)
        {
            _context = context;
        }

        public IViewComponentResult InvokeAsync()
        {
            var categories = _context.Categories.Select( lo => new CategoryModel
            {
                CategoryId = lo.CategoryId,
                CategoryName = lo.CategoryName,
                Number = lo.Products.Count
            });
            return View(categories);
        }
    }
}
