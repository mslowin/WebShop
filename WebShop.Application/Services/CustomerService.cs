﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using WebShop.Application.Interfaces;
using WebShop.Application.ViewModels.Address;
using WebShop.Application.ViewModels.Customer;
using WebShop.Domain.Models;
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
            var customer = _mapper.Map<Customer>(customerVm);
            var id = _customerRepository.Add(customer);
            return id;
        }

        public int AddNewAddress(AddressForListVm addressVm)
        {
            throw new NotImplementedException();
        }

        public ListCustomerForListVm BrowseAllCustomersForList(int? pageSize = null, int? pageNumber = null, string nameSearchString = "")
        {
            var customers = _customerRepository.Browse()
                .Where(c => string.IsNullOrEmpty(nameSearchString)
                            || (c.CompanyName != null && c.CompanyName.StartsWith(nameSearchString))
                            || c.FirstName.StartsWith(nameSearchString)
                            || c.LastName.StartsWith(nameSearchString))
                .ProjectTo<CustomerForListVm>(_mapper.ConfigurationProvider).ToList();

            var customersToShow = (pageSize == null && pageNumber == null)
                ? customers
                : customers.Skip((int)(pageSize * (pageNumber - 1))).Take((int)pageSize).ToList();

            return new ListCustomerForListVm
            {
                Customers = customersToShow,
                Count = customers.Count,
                CurrentPage = (int)pageNumber,
                PageSize = (int)pageSize,
                NameSearchString = nameSearchString
            };
        }

        public CustomerDetailsVm GetCustomerDetails(int customerId)
        {
            var customer = _customerRepository.Get(customerId);

            return _mapper.Map<CustomerDetailsVm>(customer);
        }
    }
}
