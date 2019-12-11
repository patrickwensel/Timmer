using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Timmer.Web.Models
{
    public class ProductPhoto
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductPhotoID { get; set; }

        public string PhotoURL { get; set; }
        public int Order { get; set; }

        [Required]
        [ForeignKey("Product")]
        [Display(Name = "Product")]
        public int ProductID { get; set; }

        public Product Product { get; set; }
    }
}
