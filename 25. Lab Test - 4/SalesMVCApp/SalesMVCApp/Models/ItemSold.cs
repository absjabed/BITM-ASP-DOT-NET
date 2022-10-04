using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesMVCApp.Models
{
    public class ItemSold
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }   

    }
}