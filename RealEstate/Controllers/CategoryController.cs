using Microsoft.AspNetCore.Mvc;
using RealEstate.BusinessLayer.Abstract;

namespace RealEstate.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values=_categoryService.GetList();

            return View(values);
        }
    }
}
