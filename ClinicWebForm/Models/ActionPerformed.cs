using System.ComponentModel.DataAnnotations;

namespace ClinicWebForm.Models
{
    public class ActionPerformed
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [MinLength(2)]
        [Display(Name = "Action Performed")]
        public string ActionPerformedDescription { get; set; }

        public bool Active { get; set; }
    }
}
