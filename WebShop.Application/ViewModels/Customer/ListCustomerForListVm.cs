﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Application.ViewModels.Customer
{
    public class ListCustomerForListVm
    {
        public List<CustomerForListVm> Customers { get; set; } = [];
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public string NameSearchString { get; set; } = string.Empty;
        public int Count { get; set; }
    }
}
