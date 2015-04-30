using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class Form
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="{0} is required.")]
        [MinLength(2)]
        [Display(Name="Form")]
        public string FormName { get; set; }
        public List<QuestionCategory> QuestionCategories { get; set; }
        public bool Active { get; set; }
    }
}