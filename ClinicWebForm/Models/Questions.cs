using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class Questions
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Question")]
        [MinLength(2)]
        public string QuestionDescription { get; set; }

        [Display(Name = "Answer")]
        [MinLength(2)]
        public string QuestionValue { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }

        [Display(Name = "QuestionCategory Id")]
        public int QuestionCategory_Id { get; set; }
    }
}