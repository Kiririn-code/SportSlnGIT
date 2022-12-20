using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportStore.Models
{
	public class Product
	{
        public long ProductID { get; set; }
        [Required(ErrorMessage ="Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter a description")]
        public string  Description { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        [Required]
        [Range(0.01,double.MaxValue,ErrorMessage ="Please enter a positive price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage ="PLease enter a category")]
        public string Category { get; set; }
    }
}

