using System.ComponentModel.DataAnnotations;

namespace Timmer.Web.Models
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }
    }
}
