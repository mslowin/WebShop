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

        [HttpGet]
        public IActionResult Index()
        {
            // utworzyć widok dla tej akcji
            // w widoku tabela z klientami
            // u góry panel do filtrowania elementów w tabeli

            // muszę przygotować dane
            // przekazać filtry do serwisu
            // serwis będzie musiał przygotować dane
            // serwis musi zwrócić dane w odpowiednim formacie

            var model = _customerService.BrowseAllCustomersForList(10, 1, "");
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNumber, string nameSearchString)
        {
            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            if (nameSearchString == null)
            {
                nameSearchString = string.Empty;
            }

            var model = _customerService.BrowseAllCustomersForList(pageSize, pageNumber, nameSearchString);
            return View(model);
        }

        [HttpGet]
        public IActionResult UpsertCustomer(int? id)
        {
            if (id.HasValue)
            {
                var customer = _customerService.GetCustomerForEdit(id.Value);
                if (customer == null)
                {
                    return NotFound();
                }

                return View(customer);
            }

            return View(new UpsertCustomerVm());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpsertCustomer(UpsertCustomerVm customer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _customerService.UpsertCustomer(customer);
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    // Log the exception
                    ModelState.AddModelError("", "An error occurred while saving the customer.");
                    return View(customer);
                }
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
