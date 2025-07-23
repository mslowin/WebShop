using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Application.ViewModels.Customer;
using WebShop.Application.ViewModels.Address;

namespace WebShop.Application.Interfaces
{
    public interface ICustomerService
    {
        public ListCustomerForListVm BrowseAllCustomersForList(int? pageSize = null, int? pageNumber = null, string nameSearchString = "");
        
        public int AddNewCustomer(NewCustomerVm customer);
        
        public int AddNewAddress(AddressForListVm address);
        
        public CustomerDetailsVm GetCustomerDetails(int customerId);
    }
}
