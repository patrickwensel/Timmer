using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Timmer.Web.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NewUsed { get; set; }
        public string StockNumber { get; set; }
        public int Year { get; set; }
        public int Hours { get; set; }
        public int EngineHorsePower { get; set; }
        public string Drive { get; set; }
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }


        public virtual ProductCategory ProductCategory { get; set; }
        [ForeignKey("ProductCategory")]
        public int ProductCategoryID { get; set; }

        public virtual ProductLocation ProductLocation { get; set; }
        [ForeignKey("ProductLocation")]
        public int ProductLocationID { get; set; }

        public virtual ProductMake ProductMake { get; set; }
        [ForeignKey("ProductMake")]
        public int ProductMakeID { get; set; }
    }
}
