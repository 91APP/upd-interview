using MyCheckedListNet46.BusinessLogic;
using MyCheckedListNet46.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCheckedListNet46.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        // GET: Member
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Member member)
        {
            var currentMember = _memberService.GetMemberByName(member.MemberName);

            if (currentMember != null)
            {
                Session["MemberId"] = currentMember.MemberId;
                Session["MemberName"] = currentMember.MemberName;

                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}