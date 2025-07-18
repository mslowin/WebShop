using Microsoft.AspNetCore.Mvc;
using WebShop.Application.Interfaces;
using WebShop.Application.ViewModels.Customer;

namespace WebShop.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            // utworzyć widok dla tej akcji
            // w widoku tabela z klientami
            // u góry panel do filtrowania elementów w tabeli

            // muszę przygotować dane
            // przekazać filtry do serwisu
            // serwis będzie musiał przygotować dane
            // serwis musi zwrócić dane w odpowiednim formacie

            var model = _customerService.BrowseAllCustomersForList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddCustomer() 
        {
            // zwraca widok z formularzem tworzenia nowego klienta
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(NewCustomerVm customer)
        {
            if (ModelState.IsValid)
            {
                var id = _customerService.AddNewCustomer(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        ////[HttpGet]
        ////public IActionResult AddNewAddressForClient(int customerId)
        ////{
        ////    // zwraca widok z formularzem tworzenia nowego adresu dla klienta
        ////    var model = new AddressModel { CustomerId = customerId };
        ////    return View(model);
        ////}

        ////[HttpPost]
        ////public IActionResult AddNewAddressForClient(AddressModel address)
        ////{
        ////    if (ModelState.IsValid)
        ////    {
        ////        var id = _customerService.AddAddress(address);
        ////        return RedirectToAction("Index");
        ////    }
        ////    return View(address);
        ////}

        [HttpGet]
        public IActionResult ViewCustomer(int customerId)
        {
            var customer = _customerService.GetCustomerDetails(customerId);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }
    }
}
