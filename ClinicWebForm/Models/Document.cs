using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class Document
    {
        public int Id { get; set; }
        public Form Form { get; set; }
        public List<Field> Fields { get; set; }
        public List<Question> Questions { get; set; }
    }
}