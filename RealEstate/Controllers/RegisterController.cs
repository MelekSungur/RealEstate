using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.WebUtilities;
using RealEstate.EntityLayer.Concrete;
using RealEstate.PresentationLayer.Models;

using System.Threading.Tasks;

namespace RealEstate.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    Name = p.name,
                    Surname = p.surname,
                    UserName = p.username,
                    Email = p.mail
                };
                if (p.password == p.confirmpassword)
                {
                    var result = await _userManager.CreateAsync(appUser, p.password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Şifreler Birbiriyle Uyuşmuyor");
                }

                //10 kasımda 14:39da kaldım index eklenmedi
            }
            return View();
        }
    }
}
