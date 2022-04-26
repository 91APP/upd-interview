using MyCheckedListNet46.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCheckedListNet46.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        // GET: Item
        public ActionResult Index()
        {
            var items = _itemService.GetItems();

            return View(items);
        }
    }
}