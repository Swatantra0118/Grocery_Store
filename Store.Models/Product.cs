using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Store.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Display (Name = "Cost")]
        [Range(1,1000)]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Cost For 1-10")]
        [Range(1, 1000)]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Cost For 10+")]
        [Range(1, 1000)]
        public double Price10 { get; set; }

        [Required]
        [Display(Name = "Cost For 20+")]
        [Range(1, 1000)]
        public double Price20 { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]

        [ValidateNever]
        public Category Category { get; set; }

        [ValidateNever]
        public string ImageUrl { get; set; }

    }
}
