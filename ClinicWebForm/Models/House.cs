using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class House
    {
        [Key]
        public int Id { get; set; }
        public virtual Household Household { get; set; }
        public bool Electricity { get; set; }
        public bool PipedWater { get; set; }
        public bool Toilet { get; set; }
        public bool Fridge { get; set; }
        public int Rooms { get; set; }
        public int AmountOfGrants { get; set; }
        public int AmountOfWorkingMembers { get; set; }

        [DataType(DataType.MultilineText)]
        public string NameOfSchools { get; set; }
    }
}