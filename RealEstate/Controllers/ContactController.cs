using Microsoft.AspNetCore.Mvc;

namespace RealEstate.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
