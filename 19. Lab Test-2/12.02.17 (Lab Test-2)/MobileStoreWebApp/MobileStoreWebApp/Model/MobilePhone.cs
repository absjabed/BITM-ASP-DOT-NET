using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStoreWebApp.Model
{
    public class MobilePhone
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string IMEI { get; set; }
        public decimal Price { get; set; }

        public MobilePhone(int id, string modelName, string imei, decimal priceDecimal)
        {
            Id = id;
            ModelName = modelName;
            IMEI = imei;
            Price = priceDecimal;
        }

        public MobilePhone()
        {
        }

        public MobilePhone(string modelName, string imei, decimal priceDecimal)
        {
            ModelName = modelName;
            IMEI = imei;
            Price = priceDecimal;
        }
    }
}