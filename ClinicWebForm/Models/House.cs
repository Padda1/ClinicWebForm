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

        [Display(Name = "Electricity")]
        public bool Electricity { get; set; }

        [Display(Name = "Piped Water")]
        public bool PipedWater { get; set; }

        [Display(Name = "Toilet")]
        public bool Toilet { get; set; }

        [Display(Name = "Fridge")]
        public bool Fridge { get; set; }

        [Display(Name = "Rooms")]
        public int Rooms { get; set; }

        [Display(Name = "Amount of Grants")]
        public int AmountOfGrants { get; set; }

        [Display(Name = "Amount of Working Members")]
        public int AmountOfWorkingMembers { get; set; }

        [Display(Name = "Schools")]
        [DataType(DataType.MultilineText)]
        public string NameOfSchools { get; set; }
    }
}