using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesMVCApp.Models
{
    public class AlertType
    {
        public string Message { get; set; }
        public string MessageType { get; set; }

        public AlertType(string message, string messageType)
        {
            Message = message;
            MessageType = messageType;
        }

    }
}