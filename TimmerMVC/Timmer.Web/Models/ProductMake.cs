using System.ComponentModel.DataAnnotations;

namespace Timmer.Web.Models
{
    public class ProductMake
    {
        [Key]
        public int ProductMakeID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
