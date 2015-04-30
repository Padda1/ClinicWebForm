using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class FormDocumentViewModel
    {
        public int FormId { get; set; }
        public int ClinicId { get; set; }
        public int MunicipalityId { get; set; }
        public int ProvinceId { get; set; }
        public int WardId { get; set; }
        public int HouseholdId { get; set; }
    }
}