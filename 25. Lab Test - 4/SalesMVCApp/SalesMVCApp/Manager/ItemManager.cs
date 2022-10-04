using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalesMVCApp.Models;

namespace SalesMVCApp.Gateway
{
    public class ItemManager
    {
        ItemGateway itemGateway = new ItemGateway();
        public List<Items> GetAllItems()
        {
            return itemGateway.GetAllItems();
        }

        public AlertType Save(ItemSold item)
        {
                int row = itemGateway.Save(item);
                if (row > 0)
                {
                    return new AlertType("Successfully saved!", "success");
                }
                return new AlertType("Save failed!", "danger");
            }

        public List<ItemSold> ViewById(int itemId)
        {
           return itemGateway.ViewById(itemId);
        }
    }
    }
