using AutoMapper;
using AutoMapper.QueryableExtensions;
using WebShop.Application.Interfaces;
using WebShop.Application.ViewModels.Address;
using WebShop.Application.ViewModels.Customer;
using WebShop.Domain.RepositoryInterfaces;

namespace WebShop.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public int AddNewCustomer(NewCustomerVm customerVm)
        {
            throw new NotImplementedException();
        }

        public int AddNewAddress(AddressForListVm addressVm)
        {
            throw new NotImplementedException();
        }

        public ListCustomerForListVm BrowseAllCustomersForList()
        {
            var customers = _customerRepository.Browse()
                .ProjectTo<CustomerForListVm>(_mapper.ConfigurationProvider).ToList();

            return new ListCustomerForListVm
            {
                Customers = customers,
                Count = customers.Count
            };
        }

        public CustomerDetailsVm GetCustomerDetails(int customerId)
        {
            var customer = _customerRepository.Get(customerId);

            return _mapper.Map<CustomerDetailsVm>(customer);
        }
    }
}
