using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCIntroWebApp.Gateway;
using MVCIntroWebApp.Models;

namespace MVCIntroWebApp.Manager
{
    public class CategoryManager
    {
        private CategoryGateway CategoryGateway = new CategoryGateway();


        public List<Category> GetAllCategories()
        {
            return CategoryGateway.GetAllCategories();
        }
    }
}