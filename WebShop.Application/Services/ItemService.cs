using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Application.Interfaces;

namespace WebShop.Application.Services
{
    public class ItemService : IItemService
    {
        public List<int> GetItems()
        {
            List<int> ints = [ 1, 2, 3 ];
            return ints;
        }

        public int GetItems(int id)
        {
            return 1;
        }
    }
}
