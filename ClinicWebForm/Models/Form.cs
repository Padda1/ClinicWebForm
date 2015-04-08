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
        public string FormName { get; set; }
        public bool Active { get; set; }
    }
}