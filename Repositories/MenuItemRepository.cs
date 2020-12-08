using MenuItemService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemService.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        static List<MenuItem> items = new List<MenuItem>()
        {
            new MenuItem{ItemId = 1, ItemName = "Biryani" , Category = "Maincourse", Price = 250},
            new MenuItem{ItemId = 2, ItemName = "Tandoori" , Category = "Starter", Price = 200},
            new MenuItem{ItemId = 3, ItemName = "Brownie" , Category = "Dessert", Price = 100},
        };
        public IEnumerable<MenuItem> GetAll()
        {
            return items;
        }

        public MenuItem GetMenuItem(int itemid)
        {
            return items.FirstOrDefault(b => b.ItemId == itemid);
        }
    }
}
