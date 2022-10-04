using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCIntroWebApp.Models
{
    public class ItemWithCategory
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}