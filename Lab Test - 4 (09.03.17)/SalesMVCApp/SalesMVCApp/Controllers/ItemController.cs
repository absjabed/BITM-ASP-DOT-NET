using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalesMVCApp.Gateway;
using SalesMVCApp.Models;

namespace SalesMVCApp.Controllers
{
    public class ItemController : Controller
    {
        ItemManager ItemManager = new ItemManager();
        //
        // GET: /Item/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Save()
        
        {
            ViewBag.Items = ItemManager.GetAllItems();
            return View();
        }
        [HttpPost]
        public ActionResult Save(ItemSold item)
        {
            ViewBag.Items = ItemManager.GetAllItems();
           ViewBag.Alert = ItemManager.Save(item);
            return View();
        }
        //
       
        [HttpPost]
        public ActionResult ViewPage(int itemId)
        {

            ViewBag.Items = ItemManager.GetAllItems();
            ViewBag.ItemSold = ItemManager.ViewById(itemId);
            return View();
        }

        [HttpGet]
        public ActionResult ViewPage()
        {
            ViewBag.Items = ItemManager.GetAllItems();
            return View();
        }
        
	}
}