using System.ComponentModel;

namespace WebShop.Models
{
    public class Entity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        //[DisplayName("Identyfikator")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }
    }
}
