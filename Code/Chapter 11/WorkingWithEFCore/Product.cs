using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packt.Shared
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }
        [Column("UnitPrice", TypeName = "money")]
        public decimal? Cost { get; set; } // property name != field name
        [Column("UnitsInStock")]
        public short? Stock { get; set; }
        public bool Discontinued { get; set; }
        // these two define the foreign key relationship to the Categories table
        // marking the below as virtual (and Product.Category) allows EF Core to inherit and override the properties to provide extra features,
        // such as lazy loading. Lazy loading is not available in EF Core 2.0 or earlier.
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}