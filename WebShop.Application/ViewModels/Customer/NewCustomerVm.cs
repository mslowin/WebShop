//using System.ComponentModel.DataAnnotations;

namespace WebShop.Application.ViewModels.Customer
{
    public class NewCustomerVm
    {
        //[Required]
        public int Id { get; set; }
        
        //[Required(ErrorMessage = "First name is required.")]
        //[StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; } = string.Empty;
        
        //[Required(ErrorMessage = "Last name is required.")]
        //[StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string LastName { get; set; } = string.Empty;
        
        //[StringLength(100, ErrorMessage = "Company name cannot exceed 100 characters.")]
        public string CompanyName { get; set; } = string.Empty;
        
        //[RegularExpression(@"^\d{10}$", ErrorMessage = "NIP must be a 10-digit number.")]
        public string Nip { get; set; } = string.Empty;
        
        //[RegularExpression(@"^\d{9}$", ErrorMessage = "REGON must be a 9-digit number elo.")]
        public string Regon { get; set; } = string.Empty;
    }
}
