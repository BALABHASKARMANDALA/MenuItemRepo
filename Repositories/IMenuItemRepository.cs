using MenuItemService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemService.Repositories
{
    public interface IMenuItemRepository
    {
        IEnumerable<MenuItem> GetAll();
        MenuItem GetMenuItem(int itemid);
    }
}
