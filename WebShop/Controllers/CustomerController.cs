using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using WebShop.Application.Interfaces;
using WebShop.Application.ViewModels.Customer;
using WebShop.Extensions;

namespace WebShop.Controllers
{
    public class CustomerController : Controller
    {
        private IValidator<NewCustomerVm> _validator;
        private readonly ICustomerService _customerService;

        public CustomerController(IValidator<NewCustomerVm> validator, ICustomerService customerService)
        {
            _validator = validator;
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

            var model = _customerService.BrowseAllCustomersForList(2, 1, "");
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
        public IActionResult AddCustomer() 
        {
            return View(new NewCustomerVm());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCustomer(NewCustomerVm customer)
        {
            ValidationResult result = await _validator.ValidateAsync(customer);
            
            if (!result.IsValid)
            {
                // Copy the validation results into ModelState
                result.AddToModelState(this.ModelState);
                // Return the view with the validation errors
                return View("AddCustomer", customer);
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var id = _customerService.AddNewCustomer(customer);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
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
