using System.ComponentModel;

namespace WebShop.Models
{
    public class Item
    {
        [DisplayName("Identyfikator")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeName{ get; set; }
    }
}
