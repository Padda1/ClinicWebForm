using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ClinicWebForm.Models
{
    public class QuestionCategory
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Category")]
        [MinLength(2)]
        public string CategoryDescription { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }

        [Display(Name = "Form Id")]
        public int FormId { get; set; }

        [Display(Name = "Questions")]
        public List<Questions> Questions { get; set; }
    }
}
