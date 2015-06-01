using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicWebForm.Models
{
    public class Question
    {
        public int Id { get; set; }
        public DataType DataType { get; set; }
        public string QuestionDescription { get; set; }
        public string Answer { get; set; }
        public bool Active { get; set; }
    }
}
