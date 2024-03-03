using System.ComponentModel.DataAnnotations;

namespace PortFolioFInal.Models
{
    public class Project
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Project Name")]
        public String projectName { get; set; }
        [Display(Name = "Project Description")]
        public String projectDescription { get; set; }
        [Display(Name = "Project Link")]
        public String projectLink { get; set; }
    }
}
