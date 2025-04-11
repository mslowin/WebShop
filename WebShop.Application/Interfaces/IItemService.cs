using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Application.Interfaces
{
    public interface IItemService
    {
        public List<int> GetItems();
    }
}
