using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Classes
{
    [IgnoreEmptyLines()]
    [DelimitedRecord(",")]
    public class FileTemplate
    {
        [FieldTrim(TrimMode.Both)]
        public String Province;

        [FieldTrim(TrimMode.Both)]
        public String Municipality;
	
        [FieldTrim(TrimMode.Both)]
        public String WardNo;

        [FieldTrim(TrimMode.Both)]
        public String ClinicName;

        [FieldTrim(TrimMode.Both)]
        public String OfficialHouseRegistrationNumber;

        [FieldTrim(TrimMode.Both)]
        public String CHWHouseholdIdentifierNo;

        [FieldTrim(TrimMode.Both)]
        public String CHWHouseholdIdentifierNo1;   

        [FieldTrim(TrimMode.Both)]
        public String DateOfVisit;

        [FieldTrim(TrimMode.Both)]
        public String CHWName;

        [FieldTrim(TrimMode.Both)]
        public String NameOfCaregiver;

        [FieldTrim(TrimMode.Both)]
        public String AgeOfCaregiver;

        [FieldTrim(TrimMode.Both)]
        public String CareGiverContactNumber;

        [FieldTrim(TrimMode.Both)]
        public String EDD;

        [FieldTrim(TrimMode.Both)]
        public String NameOfChild;

        [FieldTrim(TrimMode.Both)]
        public String DateOfBirthOfChild;

        [FieldTrim(TrimMode.Both)]
        public String GenderOfChild;

        [FieldTrim(TrimMode.Both)]
        public String BirthWeight;

        [FieldTrim(TrimMode.Both)]
        public String ChildAge;

        [FieldTrim(TrimMode.Both)]
        public String Grants;

        [FieldTrim(TrimMode.Both)]
        public String Exposed;

        [FieldTrim(TrimMode.Both)]
        public String DateOfVisit1;

        [FieldTrim(TrimMode.Both)]
        public String DateOfFollowup;

        [FieldTrim(TrimMode.Both)]
        public String ANCPNCUnder5LBW;

        [FieldTrim(TrimMode.Both)]
        public String MaternalHealth;

        [FieldTrim(TrimMode.Both)]
        public String ChildHealth;

        [FieldTrim(TrimMode.Both)]
        public String CareInterventionsProvided;

        [FieldTrim(TrimMode.Both)]
        public String Referred;

        [FieldTrim(TrimMode.Both)]
        public String CHWCaregiverSignature;

        [FieldTrim(TrimMode.Both)]
        public String CaregiverSignature;

        [FieldTrim(TrimMode.Both)]
        public String TeamLeaderConsultDate;

        [FieldTrim(TrimMode.Both)]
        public String TeamLeaderSignature;

        //[FieldTrim(TrimMode.Both)]
        //public String Province;

        //[FieldTrim(TrimMode.Both)]
        //public String Province;

        //[FieldTrim(TrimMode.Both)]
        //public String Province;

        //[FieldTrim(TrimMode.Both)]
        //public String Province;

        //[FieldTrim(TrimMode.Both)]
        //public String Province;

        //[FieldTrim(TrimMode.Both)]
        //public String Province;

        //[FieldTrim(TrimMode.Both)]
        //public String Province;

        //[FieldTrim(TrimMode.Both)]
        //public String Province;

        //[FieldTrim(TrimMode.Both)]
        //public String Province;

        //[FieldTrim(TrimMode.Both)]
        //public String Province;

        //[FieldTrim(TrimMode.Both)]
        //public String Province;
    }
}