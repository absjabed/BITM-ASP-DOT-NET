using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using MVCIntroWebApp.Gateway;
using MVCIntroWebApp.Models;

namespace MVCIntroWebApp.Manager
{
    public class ItemManager
    {
        ItemGateway itemGateway = new ItemGateway();
        public AlertType Save(Item item)
        {
            bool isExist = itemGateway.ItemExists(item.Name);
            if (!isExist)
            {
                int row = itemGateway.Save(item);
                if (row > 0)
                {
                    return new AlertType("Successfully saved!", "success");
                }
                return new AlertType("Save failed!", "danger");
            }
            return new AlertType("This item is already exists", "danger"); ;
        }

        public List<ItemWithCategory> GetAllItems()
        {
            return itemGateway.GetAllItems();
        }

        public List<ItemWithCategory> GetItemsByCategory(int id)
        {
            return itemGateway.GetItemsByCategory(id);
        }
    }
}