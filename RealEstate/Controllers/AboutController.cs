using Microsoft.AspNetCore.Mvc;

namespace RealEstate.PresentationLayer.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
