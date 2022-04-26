using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCheckedListNet46.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // TODO: 實作 Action Filter 判斷使用者是否已登入
            if (Session["MemberId"] == null)
            {
                return RedirectToAction("Login", "Member");
            }

            // TODO: 實作資料表列, 條件為登入的使用者有勾選過的 Item
            //
            // Member: Member A
            //
            //| Checked | Item Id | Item Name |
            //| --------+---------+-----------|
            //| [v]     | 1       | Item 1    |
            //| [v]     | 2       | Item 2    |
            //| [ ]     | 3       | Item 3    |
            //| [v]     | 4       | Item 4    |

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}