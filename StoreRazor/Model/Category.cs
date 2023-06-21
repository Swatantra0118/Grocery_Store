using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StoreRazor.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public required String Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display the range between 1 to 100")]
        public int DisplayOrder { get; set; }
    }
}
