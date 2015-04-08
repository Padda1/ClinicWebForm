using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class Health
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Official House Reg No")]
        //public string OfficialHouseRegNo { get; set; }
        public string OFFICIAL_HOUSE_REG_NO { get; set; }

        [Display(Name = "CHW Household Identifier Number")]
        //public string ChwIdNo { get; set; }
        public string CHW_ID_NO { get; set; }

        [Display(Name = "Date of Visit")]
        //[DataType(DataType.DateTime)]
        //public DateTime DateOfVisit { get; set; }
        public string DATE_OF_VISIT { get; set; }

        
        [Display(Name = "CHW Name")]
        public string CHW_NAME { get; set; }

        
        [Display(Name = "District")]
        public string DISTRICT { get; set; }

        
        [Display(Name = "Province")]
        public string PROVINCE { get; set; }

        
        [Display(Name = "Ward DHIS")]
        public string WARD_DHIS { get; set; }

        
        [Display(Name = "Clinic Name")]
        public string CLINIC_NAME { get; set; }

        
        [Display(Name = "Team Name")]
        public string TEAM_NAME { get; set; }

        
        [Display(Name = "Household Head Name")]
        public string HOUSEHOLD_HEAD_NAME { get; set; }

        
        [Display(Name = "Household Address")]
        public string HOUSEHOLD_ADDRESS { get; set; }

        
        [Display(Name = "Household Head Tel")]
        public string HOUSEHOLD_HEAD_TEL { get; set; }

        
        [Display(Name = "Household Respondent")]
        public string HOUSEHOLD_RESPONDENT { get; set; }

        
        [Display(Name = "Member 1 Name")]
        public string MEMBER_1_NAME { get; set; }

        
        [Display(Name = "Member 1 DOB")]
        public string MEMBER_1_DOB { get; set; }

        
        [Display(Name = "Member 1 Age")]
        public string MEMBER_1_AGE { get; set; }

        
        [Display(Name = "Member 1 Gender")]
        public string MEMBER_1_GENDER { get; set; }

        
        [Display(Name = "Member 2 Name")]
        public string MEMBER_2_NAME { get; set; }

        
        [Display(Name = "Member 2 Age")]
        public string MEMBER_2_AGE { get; set; }

        
        [Display(Name = "Member 2 DOB")]
        public string MEMBER_2_DOB { get; set; }

        
        [Display(Name = "Member 2 Gender")]
        public string MEMBER_2_GENDER { get; set; }

        
        [Display(Name = "Household Toilet")]
        public string HOUSEHOLD_TOILET { get; set; }

        
        [Display(Name = "Member 3 Name")]
        public string MEMBER_3_NAME { get; set; }

        
        [Display(Name = "Member 3 DOB")]
        public string MEMBER_3_DOB { get; set; }

        
        [Display(Name = "Member 3 Age")]
        public string MEMBER_3_AGE { get; set; }

        
        [Display(Name = "Member 3 Gender")]
        public string MEMBER_3_GENDER { get; set; }

        
        [Display(Name = "Member 4 Name")]
        public string MEMBER_4_NAME { get; set; }

        
        [Display(Name = "Member 4 DOB")]
        public string MEMBER_4_DOB { get; set; }

        
        [Display(Name = "Member 4 Age")]
        public string MEMBER_4_AGE { get; set; }

        
        [Display(Name = "Member 4 Gender")]
        public string MEMBER_4_GENDER { get; set; }

        
        [Display(Name = "Member 5 Name")]
        public string MEMBER_5_NAME { get; set; }

        
        [Display(Name = "Member 5 DOB")]
        public string MEMBER_5_DOB { get; set; }

        
        [Display(Name = "Member 5 Age")]
        public string MEMBER_5_AGE { get; set; }

        
        [Display(Name = "Member 5 Gender")]
        public string MEMBER_5_GENDER { get; set; }

        
        [Display(Name = "Member 6 Name")]
        public string MEMBER_6_NAME { get; set; }

        
        [Display(Name = "Member 6 DOB")]
        public string MEMBER_6_DOB { get; set; }

        
        [Display(Name = "Member 6 Age")]
        public string MEMBER_6_AGE { get; set; }

        
        [Display(Name = "Member 6 Gender")]
        public string MEMBER_6_GENDER { get; set; }

        
        [Display(Name = "Member 7 Name")]
        public string MEMBER_7_NAME { get; set; }

        
        [Display(Name = "Member 7 DOB")]
        public string MEMBER_7_DOB { get; set; }

        
        [Display(Name = "Member 7 Age")]
        public string MEMBER_7_AGE { get; set; }

        
        [Display(Name = "Member 7 Gender")]
        public string MEMBER_7_GENDER { get; set; }

        
        [Display(Name = "Member 8 Name")]
        public string MEMBER_8_NAME { get; set; }

        
        [Display(Name = "Member 8 DOB")]
        public string MEMBER_8_DOB { get; set; }

        
        [Display(Name = "Member 8 Age")]
        public string MEMBER_8_AGE { get; set; }

        
        [Display(Name = "Member 8 Gender")]
        public string MEMBER_8_GENDER { get; set; }

        
        [Display(Name = "Household Number of People")]
        public string HOUSEHOLD_NUMBER_OF_PEOPLE { get; set; }

        
        [Display(Name = "All Household Members Registered")]
        public string ALL_HOUSEHOLD_MEMBERS_REGISTERED { get; set; }

        
        [Display(Name = "Household Electricity")]
        public string HOUSEHOLD_ELECTRICITY { get; set; }

        
        [Display(Name = "Household Pumped Water")]
        public string HOUSEHOLD_PUMPED_WATER { get; set; }

        
        [Display(Name = "Household Fridge")]
        public string HOUSEHOLD_FRIDGE { get; set; }

        
        [Display(Name = "Household Rooms")]
        public string HOUSEHOLD_ROOMS { get; set; }

        
        [Display(Name = "Household Grants")]
        public string HOUSEHOLD_GRANTS { get; set; }

        
        [Display(Name = "Working Members")]
        public string HOUSEHOLD_MEMBERS_THAT_WORK { get; set; }

        [Display(Name = "Schools 1")]
        public string LEARNERS_SCHOOLS_1 { get; set; }

        [Display(Name = "Schools 2")]
        public string LEARNERS_SCHOOLS_2 { get; set; }

        [Display(Name = "Member with Persistant Cough")]
        public string MEMBER_WITH_PERSISTANT_COUGH { get; set; }

        [Display(Name = "Night Sweats")]
        public string MEMBER_WITH_NIGHT_SWEATS { get; set; }

        [Display(Name = "Weigh Loss")]
        public string MEMBER_WITH_WEIGH_LOSS { get; set; }

        [Display(Name = "Fever")]
        public string MEMBER_WITH_FEVER { get; set; }

        [Display(Name = "Loss of Appitite")]
        public string MEMBER_WITH_LOSS_OF_APPITITE { get; set; }

        [Display(Name = "TB Symtoms")]
        public string MEMBER_WITH_TB_SYMPTOMS { get; set; }

        [Display(Name = "HIV Test")]
        public string MEMBER_NEEDING_HIV_TEST { get; set; }

        [Display(Name = "With Social Grants")]
        public string MEMBERS_WITH_SOCIAL_GRANTS { get; set; }

        [Display(Name = "Appling for Grants")]
        public string MEMBERS_APPLYING_FOR_GRANTS { get; set; }

        [Display(Name = "Would Like HIV Test")]
        public string MEMBER_WHO_WOULD_LIKE_HIV_TEST { get; set; }

        [Display(Name = "Family Planning")]
        public string MEMBER_NEEDING_FAMILY_PLANNING { get; set; }

        [Display(Name = "Unmet Family Planning Needs")]
        public string MEMBER_WITH_UNMET_FAMILY_PLANNING_NEEDS { get; set; }

        [Display(Name = "Help With Daily Activites")]
        public string MEMBER_WHO_NEEDS_HELP_WITH_DAILY_ACTIVITES { get; set; }

        [Display(Name = "ADL Help")]
        public string MEMBER_THAT_NEEDS_ADL_HELP { get; set; }

        [Display(Name = "Child Head")]
        public string HOUSEHOLD_CHILD_HEAD { get; set; }

        [Display(Name = "Age of Household Head")]
        public string AGE_OF_HOUSEHOLD_HEAD { get; set; }

        [Display(Name = "Household Pregnancy or Perion in 6 Weeks")]
        public string HOUSEHOLD_PREGNANCY_OR_PERION_IN_6_WEEKS { get; set; }

        [Display(Name = "Members pregnant in household")]
        public string MEMBERS_PREGNANT_IN_HOUSEHOLD { get; set; }

        [Display(Name = "Baby deliveries in past 6 weeks")]
        public string BABY_DELIVERIES_IN_PAST_6_WEEKS { get; set; }

        [Display(Name = "Number of babies in 6 weeks")]
        public string NUMBER_OF_BABIES_IN_6_WEEKS { get; set; }

        [Display(Name = "Household children under 5")]
        public string HOUSEHOLD_CHILDREN_UNDER_5 { get; set; }

        [Display(Name = "Number of children under 5 in household")]
        public string NUMBER_OF_CHILDREN_UNDER_5_IN_HOUSEHOLD { get; set; }

        [Display(Name = "Member taking medication")]
        public string MEMBER_TAKING_MEDICATION { get; set; }

        [Display(Name = "Member number taking chronic medication")]
        public string MEMBER_NUMBER_TAKING_CHRONIC_MEDICATION { get; set; }

        [Display(Name = "Note on household screening")]
        public string NOTE_ON_HOUSEHOLD_SCREENING { get; set; }

        [Display(Name = "Follow up date")]
        public string FOLLOW_UP_DATE { get; set; }

        [Display(Name = "Pregnant member expected date")]
        public string PREGNANT_MEMBER_EXPECTED_DATE { get; set; }

        [Display(Name = "Member number currently pregnant")]
        public string MEMBER_NUMBER_CURRENTLY_PREGNANT { get; set; }

        [Display(Name = "Referalls issued for pregnant member")]
        public string REFERALLS_ISSUED_FOR_PREGNANT_MEMBER { get; set; }

        [Display(Name = "DOB Member born within 6 weeks")]
        public string DOB_MEMBER_BORN_WITHIN_6_WEEKS { get; set; }

        [Display(Name = "Member number born within the last 6 weeks")]
        public string MEMBER_NUMBER_BORN_WITHIN_THE_LAST_6_WEEKS { get; set; }

        [Display(Name = "Baby weight less than 2500g")]
        public string BABY_WEIGHT_LESS_THAN_2500G { get; set; }

        [Display(Name = "Member number birth weight less than 2500g")]
        public string MEMBER_NUMBER_BIRTH_WEIGHT_LESS_THAN_2500g { get; set; }

        [Display(Name = "Number of referrals for under weight babies")]
        public string NUMBER_OF_REFERRALS_FOR_UNDER_WEIGHT_BABIES { get; set; }

        [Display(Name = "Chilrden under 5 not immunized")]
        public string CHILRDEN_UNDER_5_NOT_IMMUNIZED { get; set; }

        [Display(Name = "Children under 5 with no vit a in 6 months")]
        public string CHILDREN_UNDER_5_WITH_NO_VIT_A_IN_6_MONTHS { get; set; }

        [Display(Name = "Referral forms issued babies born within 6 weeks if necessary")]
        public string REFERRAL_FORMS_ISSUED_BABIES_BORN_WITHIN_6_WEEKS_IF_NECESSARY { get; set; }

        [Display(Name = "Member number whose immunization is not up to date")]
        public string MEMBER_NUMBER_WHOSE_IMMUNIZATION_IS_NOT_UP_TO_DATE { get; set; }

        [Display(Name = "Refferals issued for children not immunized")]
        public string REFFERALS_ISSUED_FOR_CHILDREN_NOT_IMMUNIZED { get; set; }

        [Display(Name = "Member number not had vitamin a prophylaxis")]
        public string MEMBER_NUMBER_NOT_HAD_VITAMIN_A_PROPHYLAXIS { get; set; }

        [Display(Name = "Children not weighed or under weight")]
        public string CHILDREN_NOT_WEIGHED_OR_UNDER_WEIGHT { get; set; }

        [Display(Name = "Member number not weighed shows signs of malnutrition")]
        public string MEMBER_NUMBER_NOT_WEIGHED_SHOWS_SIGNS_OF_MALNUTRITION { get; set; }

        [Display(Name = "Children suspected of illness or concerns")]
        public string CHILDREN_SUSPECTED_OF_ILLNESS_OR_CONCERNS { get; set; }

        [Display(Name = "Referrals for vitamin a prophylaxis")]
        public string REFERRALS_FOR__VITAMIN_A_PROPHYLAXIS { get; set; }

        [Display(Name = "Refferals for not weighed shows signs of malnutrition")]
        public string REFFERALS_FOR_NOT_WEIGHED_SHOWS_SIGNS_OF_MALNUTRITION { get; set; }

        [Display(Name = "MEMBER_NUMBER_SUSPECTED_OF_ILLNESS_OR_CONCERNS")]
        public string MEMBER_NUMBER_SUSPECTED_OF_ILLNESS_OR_CONCERNS { get; set; }

        [Display(Name = "REFFERALS_FOR_NOT_WEIGHED_CHILDREN_SHOWS_SIGNS_OF_MALNUTRITION")]
        public string REFFERALS_FOR_NOT_WEIGHED_CHILDREN_SHOWS_SIGNS_OF_MALNUTRITION { get; set; }

        [Display(Name = "HIV_EXPOSED_CHILDREN_WITHIN_6_WEEKS")]
        public string HIV_EXPOSED_CHILDREN_WITHIN_6_WEEKS { get; set; }

        [Display(Name = "MEMBER_NUMBER_NOT_HAD_PCR__WHO_IS_6_WEEKS_AND_OLDER_HIV_EXPOSED")]
        public string MEMBER_NUMBER_NOT_HAD_PCR__WHO_IS_6_WEEKS_AND_OLDER_HIV_EXPOSED { get; set; }

        [Display(Name = "REFERRALS_FOR_HIV_EXPOSED_CHILDREN_6_WEEKS_OLDER_NOT__PCR_TEST")]
        public string REFERRALS_FOR_HIV_EXPOSED_CHILDREN_6_WEEKS_OLDER_NOT__PCR_TEST { get; set; }

        [Display(Name = "MEMBERS_TAKING_TB_HIV_BP_DIABETES_MEDS")]
        public string MEMBERS_TAKING_TB_HIV_BP_DIABETES_MEDS { get; set; }

        [Display(Name = "MEMBER_NUMBER_TAKING_TB_HIV_BP_DIABETES_MEDS")]
        public string MEMBER_NUMBER_TAKING_TB_HIV_BP_DIABETES_MEDS { get; set; }

        [Display(Name = "REFERRALS_FOR_TAKING_TB_HIV_BP_DIABETES_MEDS")]
        public string REFERRALS_FOR_TAKING_TB_HIV_BP_DIABETES_MEDS { get; set; }

        [Display(Name = "MEMBER_DEFAULTING_FROM_TREATMENT")]
        public string MEMBER_DEFAULTING_FROM_TREATMENT { get; set; }

        [Display(Name = "MEMBER_NUMBER_THAT_DEFAULTED")]
        public string MEMBER_NUMBER_THAT_DEFAULTED { get; set; }

        [Display(Name = "REFERRALS_ISSUED_FOR_DEFAULTING_MEMBER")]
        public string REFERRALS_ISSUED_FOR_DEFAULTING_MEMBER { get; set; }

        [Display(Name = "ANY_OTHER_PROBLEMS")]
        public string ANY_OTHER_PROBLEMS { get; set; }

        [Display(Name = "MEMBER_NUMBER_WITH_IDENTIFIED_PROBLEMS")]
        public string MEMBER_NUMBER_WITH_IDENTIFIED_PROBLEMS { get; set; }

        [Display(Name = "REFERRAL_FORMS_FOR_ANY_OTHER_PROBLEMS_IDENTIFIED")]
        public string REFERRAL_FORMS_FOR_ANY_OTHER_PROBLEMS_IDENTIFIED { get; set; }

        [Display(Name = "COMMENTS_LINE_1")]
        public string COMMENTS_LINE_1 { get; set; }

        [Display(Name = "COMMENTS_LINE_2")]
        public string COMMENTS_LINE_2 { get; set; }

        [Display(Name = "COMMENTS_LINE_3")]
        public string COMMENTS_LINE_3 { get; set; }

        [Display(Name = "COMMENTS_LINE_4")]
        public string COMMENTS_LINE_4 { get; set; }

        [Display(Name = "CHW_SIGN")]
        public string CHW_SIGN { get; set; }

        [Display(Name = "TL_NAME")]
        public string TL_NAME { get; set; }

        [Display(Name = "TL_VERIFY_DA")]
        public string TL_VERIFY_DA { get; set; }
    }
}