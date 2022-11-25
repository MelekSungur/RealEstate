using Microsoft.AspNetCore.Mvc;
using RealEstate.BusinessLayer.Abstract;
using RealEstate.EntityLayer.Concrete;

namespace RealEstate.PresentationLayer.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        public IActionResult Index()
        {
            var values = _memberService.GetList();
            return View(values);
        }
        
        [HttpPost]
        public IActionResult AddMember()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddMember(Member member)
        {
            _memberService.TInsert(member);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteMember(int id)
        {
           var values=_memberService.TGetByID(id);
            _memberService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
