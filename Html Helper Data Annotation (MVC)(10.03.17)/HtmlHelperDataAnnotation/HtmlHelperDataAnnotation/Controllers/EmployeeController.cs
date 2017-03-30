using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelperDataAnnotation.Models;

namespace HtmlHelperDataAnnotation.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            ViewBag.Departments = GetDepartments();
            return View();
        }
        [HttpPost]
        public ActionResult Register(Employee employee)
        {
            ViewBag.Departments = GetDepartments();
            return View();
        }
        [HttpGet]
        public ActionResult Save()
        {
            ViewBag.Departments = GetDepartments();
            return View();
        }
        [HttpPost]
        public ActionResult Save(Employee employee)
        {
            ViewBag.Departments = GetDepartments();
            return View();
        }

        private static List<SelectListItem> GetDepartments()
        {
            List<SelectListItem> items = new List<SelectListItem>()
            {
                new SelectListItem(){Value = "", Text = "--SELECT-"},
                new SelectListItem(){Value = "ACC", Text = "Accounts"},
                new SelectListItem(){Value = "FIN", Text = "Finance"},
                new SelectListItem(){Value = "SD", Text = "Software Development"},
                new SelectListItem(){Value = "QA", Text = "Quality Assurance"},
                new SelectListItem(){Value = "R&D", Text = "Research & Development"}
            };
            return items;
        }
    }
}