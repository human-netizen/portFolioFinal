using System.ComponentModel.DataAnnotations;

namespace PortFolioFInal.Models
{
    public class Category
    {
        public int id { get; set; }
        [Required]
        [MaxLength(5)]
        [Display(Name = "Category Name")]
        public String Name { get; set; }
        [Display(Name = "Category Description")]
        [Range(1 , 10 , ErrorMessage = "Display 1 to 10")]
        public String Description { get; set; }
    }
}
