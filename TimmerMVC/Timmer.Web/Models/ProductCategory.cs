using System.ComponentModel.DataAnnotations;

namespace Timmer.Web.Models
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
