﻿using System.ComponentModel.DataAnnotations;

namespace Timmer.Web.Models
{
    public class ProductLocation
    {
        [Key]
        public int ProductLocationID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
