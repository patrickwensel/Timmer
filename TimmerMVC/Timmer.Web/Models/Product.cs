using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Timmer.Web.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [Required]
        public string Image { get; set; }

        public string Url { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        [Display(Name = "New/Used")]
        public int NewUsed { get; set; }

        [Required]
        [Display(Name = "Stock Number")]
        public string StockNumber { get; set; }

        public int Year { get; set; }

        public int Hours { get; set; }

        [Display(Name = "Engine Horse Power")]
        public int EngineHorsePower { get; set; }

        public string Drive { get; set; }

        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }

        public double Price { get; set; }

        [Required]
        public string Model { get; set; }

        [Display(Name = "Category")]
        public virtual ProductCategory ProductCategory { get; set; }

        [Required]
        [ForeignKey("ProductCategory")]
        [Display(Name = "Category")]
        public int ProductCategoryID { get; set; }

        [Display(Name = "Location")]
        public virtual ProductLocation ProductLocation { get; set; }

        [Required]
        [ForeignKey("ProductLocation")]
        [Display(Name = "Location")]
        public int ProductLocationID { get; set; }

        [Display(Name = "Make")]
        public virtual ProductMake ProductMake { get; set; }

        [Required]
        [ForeignKey("ProductMake")]
        [Display(Name = "Make")]
        public int ProductMakeID { get; set; }

        public virtual List<ProductPhoto> ProductPhotos { get; set; }

    }
}
