using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCIntroWebApp.Manager;
using MVCIntroWebApp.Models;

namespace MVCIntroWebApp.Controllers
{
    public class ItemController : Controller
    {
        ItemManager itemManager = new ItemManager();
        CategoryManager CategoryManager = new CategoryManager();
        public string Find(int? id)
        {
            if (id == 101)
            {
                return "Item id 101";
            }
            else if (id == 200)
            {
                return "Item id 200";
            }
            return "No item found!";
        }

        public string FCB()
        {
            return "FC Barcelona";
        }

        [HttpGet]
        public ActionResult Save()
        {
            ViewBag.Categories = CategoryManager.GetAllCategories();
            return View();
        }
        [HttpPost]
        public ActionResult Save(Item item)
        {
           //ViewBag.Message = itemManager.Save(item);
           ViewBag.Alert = itemManager.Save(item);
           ViewBag.Categories = CategoryManager.GetAllCategories();
            return View();
        }

        public string Search(int? id)
        {
            List<Item> items = GetAllItems();
            
            if (id == null)
            {
                string info = "";

                items.ForEach(n => info += "<br/> Name: " + n.Name + ", Price: " + n.Price + "<br/>");
                //foreach (Item itemy in items)
                //{
                //    info += "<br/> Name: " + itemy.Name + ", Price: " + itemy.Price + "<br/>";
                //}
                return info;
            }

            Item item = items.Find(c => c.Id == id);
            if (item == null)
            {
                return "No item found!";
            }
            return "Name: " + item.Name + ", Price: " + item.Price;
        }

        private List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>()
            {
                new Item(){Id = 1,Name = "Burger", Price = 30},
                new Item(){Id = 2,Name = "Chicken Roll", Price = 20},
                new Item(){Id = 3,Name = "Thai Thick Soup", Price = 50},
                new Item(){Id = 4,Name = "Sandwich", Price = 40},
                new Item(){Id = 5,Name = "Green Tea", Price = 50},
                new Item(){Id = 6,Name = "Coffe", Price = 30},
              
            };

            return items;
        }
        [HttpGet]
        public ActionResult Index()
        {
            //Item item = new Item() { Id = 2, Name = "Chicken Roll", Price = 20 };
            //ViewBag.Item = item;
            List<ItemWithCategory> items = itemManager.GetAllItems();
            ViewBag.Categories = CategoryManager.GetAllCategories();
            return View(items);
        }
        [HttpPost]
        public ActionResult Index(int categoryId)
        {
            //Item item = new Item() { Id = 2, Name = "Chicken Roll", Price = 20 };
            //ViewBag.Item = item;
            List<ItemWithCategory> items = itemManager.GetItemsByCategory(categoryId);
            ViewBag.Categories = CategoryManager.GetAllCategories();
            return View(items);
        }

	}
}