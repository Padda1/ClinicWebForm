namespace ClinicWebForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CHWs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HouseholdIdName = c.String(),
                        HouseholdIdNumber = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 100),
                        Surname = c.String(nullable: false, maxLength: 100),
                        Signature = c.String(nullable: false, maxLength: 100),
                        IsTeamLeader = c.Boolean(nullable: false),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Clinics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClinicDescription = c.String(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FormName = c.String(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Healths",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OFFICIAL_HOUSE_REG_NO = c.String(),
                        CHW_ID_NO = c.String(),
                        DATE_OF_VISIT = c.String(),
                        CHW_NAME = c.String(),
                        DISTRICT = c.String(),
                        PROVINCE = c.String(),
                        WARD_DHIS = c.String(),
                        CLINIC_NAME = c.String(),
                        TEAM_NAME = c.String(),
                        HOUSEHOLD_HEAD_NAME = c.String(),
                        HOUSEHOLD_ADDRESS = c.String(),
                        HOUSEHOLD_HEAD_TEL = c.String(),
                        HOUSEHOLD_RESPONDENT = c.String(),
                        MEMBER_1_NAME = c.String(),
                        MEMBER_1_DOB = c.String(),
                        MEMBER_1_AGE = c.String(),
                        MEMBER_1_GENDER = c.String(),
                        MEMBER_2_NAME = c.String(),
                        MEMBER_2_AGE = c.String(),
                        MEMBER_2_DOB = c.String(),
                        MEMBER_2_GENDER = c.String(),
                        HOUSEHOLD_TOILET = c.String(),
                        MEMBER_3_NAME = c.String(),
                        MEMBER_3_DOB = c.String(),
                        MEMBER_3_AGE = c.String(),
                        MEMBER_3_GENDER = c.String(),
                        MEMBER_4_NAME = c.String(),
                        MEMBER_4_DOB = c.String(),
                        MEMBER_4_AGE = c.String(),
                        MEMBER_4_GENDER = c.String(),
                        MEMBER_5_NAME = c.String(),
                        MEMBER_5_DOB = c.String(),
                        MEMBER_5_AGE = c.String(),
                        MEMBER_5_GENDER = c.String(),
                        MEMBER_6_NAME = c.String(),
                        MEMBER_6_DOB = c.String(),
                        MEMBER_6_AGE = c.String(),
                        MEMBER_6_GENDER = c.String(),
                        MEMBER_7_NAME = c.String(),
                        MEMBER_7_DOB = c.String(),
                        MEMBER_7_AGE = c.String(),
                        MEMBER_7_GENDER = c.String(),
                        MEMBER_8_NAME = c.String(),
                        MEMBER_8_DOB = c.String(),
                        MEMBER_8_AGE = c.String(),
                        MEMBER_8_GENDER = c.String(),
                        HOUSEHOLD_NUMBER_OF_PEOPLE = c.String(),
                        ALL_HOUSEHOLD_MEMBERS_REGISTERED = c.String(),
                        HOUSEHOLD_ELECTRICITY = c.String(),
                        HOUSEHOLD_PUMPED_WATER = c.String(),
                        HOUSEHOLD_FRIDGE = c.String(),
                        HOUSEHOLD_ROOMS = c.String(),
                        HOUSEHOLD_GRANTS = c.String(),
                        HOUSEHOLD_MEMBERS_THAT_WORK = c.String(),
                        LEARNERS_SCHOOLS_1 = c.String(),
                        LEARNERS_SCHOOLS_2 = c.String(),
                        MEMBER_WITH_PERSISTANT_COUGH = c.String(),
                        MEMBER_WITH_NIGHT_SWEATS = c.String(),
                        MEMBER_WITH_WEIGH_LOSS = c.String(),
                        MEMBER_WITH_FEVER = c.String(),
                        MEMBER_WITH_LOSS_OF_APPITITE = c.String(),
                        MEMBER_WITH_TB_SYMPTOMS = c.String(),
                        MEMBER_NEEDING_HIV_TEST = c.String(),
                        MEMBERS_WITH_SOCIAL_GRANTS = c.String(),
                        MEMBERS_APPLYING_FOR_GRANTS = c.String(),
                        MEMBER_WHO_WOULD_LIKE_HIV_TEST = c.String(),
                        MEMBER_NEEDING_FAMILY_PLANNING = c.String(),
                        MEMBER_WITH_UNMET_FAMILY_PLANNING_NEEDS = c.String(),
                        MEMBER_WHO_NEEDS_HELP_WITH_DAILY_ACTIVITES = c.String(),
                        MEMBER_THAT_NEEDS_ADL_HELP = c.String(),
                        HOUSEHOLD_CHILD_HEAD = c.String(),
                        AGE_OF_HOUSEHOLD_HEAD = c.String(),
                        HOUSEHOLD_PREGNANCY_OR_PERION_IN_6_WEEKS = c.String(),
                        MEMBERS_PREGNANT_IN_HOUSEHOLD = c.String(),
                        BABY_DELIVERIES_IN_PAST_6_WEEKS = c.String(),
                        NUMBER_OF_BABIES_IN_6_WEEKS = c.String(),
                        HOUSEHOLD_CHILDREN_UNDER_5 = c.String(),
                        NUMBER_OF_CHILDREN_UNDER_5_IN_HOUSEHOLD = c.String(),
                        MEMBER_TAKING_MEDICATION = c.String(),
                        MEMBER_NUMBER_TAKING_CHRONIC_MEDICATION = c.String(),
                        NOTE_ON_HOUSEHOLD_SCREENING = c.String(),
                        FOLLOW_UP_DATE = c.String(),
                        PREGNANT_MEMBER_EXPECTED_DATE = c.String(),
                        MEMBER_NUMBER_CURRENTLY_PREGNANT = c.String(),
                        REFERALLS_ISSUED_FOR_PREGNANT_MEMBER = c.String(),
                        DOB_MEMBER_BORN_WITHIN_6_WEEKS = c.String(),
                        MEMBER_NUMBER_BORN_WITHIN_THE_LAST_6_WEEKS = c.String(),
                        BABY_WEIGHT_LESS_THAN_2500G = c.String(),
                        MEMBER_NUMBER_BIRTH_WEIGHT_LESS_THAN_2500g = c.String(),
                        NUMBER_OF_REFERRALS_FOR_UNDER_WEIGHT_BABIES = c.String(),
                        CHILRDEN_UNDER_5_NOT_IMMUNIZED = c.String(),
                        CHILDREN_UNDER_5_WITH_NO_VIT_A_IN_6_MONTHS = c.String(),
                        REFERRAL_FORMS_ISSUED_BABIES_BORN_WITHIN_6_WEEKS_IF_NECESSARY = c.String(),
                        MEMBER_NUMBER_WHOSE_IMMUNIZATION_IS_NOT_UP_TO_DATE = c.String(),
                        REFFERALS_ISSUED_FOR_CHILDREN_NOT_IMMUNIZED = c.String(),
                        MEMBER_NUMBER_NOT_HAD_VITAMIN_A_PROPHYLAXIS = c.String(),
                        CHILDREN_NOT_WEIGHED_OR_UNDER_WEIGHT = c.String(),
                        MEMBER_NUMBER_NOT_WEIGHED_SHOWS_SIGNS_OF_MALNUTRITION = c.String(),
                        CHILDREN_SUSPECTED_OF_ILLNESS_OR_CONCERNS = c.String(),
                        REFERRALS_FOR__VITAMIN_A_PROPHYLAXIS = c.String(),
                        REFFERALS_FOR_NOT_WEIGHED_SHOWS_SIGNS_OF_MALNUTRITION = c.String(),
                        MEMBER_NUMBER_SUSPECTED_OF_ILLNESS_OR_CONCERNS = c.String(),
                        REFFERALS_FOR_NOT_WEIGHED_CHILDREN_SHOWS_SIGNS_OF_MALNUTRITION = c.String(),
                        HIV_EXPOSED_CHILDREN_WITHIN_6_WEEKS = c.String(),
                        MEMBER_NUMBER_NOT_HAD_PCR__WHO_IS_6_WEEKS_AND_OLDER_HIV_EXPOSED = c.String(),
                        REFERRALS_FOR_HIV_EXPOSED_CHILDREN_6_WEEKS_OLDER_NOT__PCR_TEST = c.String(),
                        MEMBERS_TAKING_TB_HIV_BP_DIABETES_MEDS = c.String(),
                        MEMBER_NUMBER_TAKING_TB_HIV_BP_DIABETES_MEDS = c.String(),
                        REFERRALS_FOR_TAKING_TB_HIV_BP_DIABETES_MEDS = c.String(),
                        MEMBER_DEFAULTING_FROM_TREATMENT = c.String(),
                        MEMBER_NUMBER_THAT_DEFAULTED = c.String(),
                        REFERRALS_ISSUED_FOR_DEFAULTING_MEMBER = c.String(),
                        ANY_OTHER_PROBLEMS = c.String(),
                        MEMBER_NUMBER_WITH_IDENTIFIED_PROBLEMS = c.String(),
                        REFERRAL_FORMS_FOR_ANY_OTHER_PROBLEMS_IDENTIFIED = c.String(),
                        COMMENTS_LINE_1 = c.String(),
                        COMMENTS_LINE_2 = c.String(),
                        COMMENTS_LINE_3 = c.String(),
                        COMMENTS_LINE_4 = c.String(),
                        CHW_SIGN = c.String(),
                        TL_NAME = c.String(),
                        TL_VERIFY_DA = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Municipalities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MunicipalCode = c.String(nullable: false),
                        MunicipalName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProvinceDescription = c.String(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionDescription = c.String(),
                        Active = c.Boolean(nullable: false),
                        QuestionCategory_Id = c.Int(),
                        FormDocument_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.QuestionCategories", t => t.QuestionCategory_Id)
                .ForeignKey("dbo.FormDocuments", t => t.FormDocument_Id)
                .Index(t => t.QuestionCategory_Id)
                .Index(t => t.FormDocument_Id);
            
            CreateTable(
                "dbo.QuestionCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryDescription = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Households",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegistrationNumber = c.String(),
                        Address = c.String(),
                        AllMembersRegistered = c.Boolean(nullable: false),
                        PregnancyPerionIn6Weeks = c.Boolean(nullable: false),
                        Note = c.String(),
                        Respondent_Id = c.Int(),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Respondents", t => t.Respondent_Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Respondent_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Respondents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RespondentValue = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Visits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VisitDate = c.DateTime(nullable: false),
                        CHW_Id = c.Int(nullable: false),
                        PreviousVisits_Id = c.Int(),
                        Household_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CHWs", t => t.CHW_Id, cascadeDelete: true)
                .ForeignKey("dbo.Visits", t => t.PreviousVisits_Id)
                .ForeignKey("dbo.Households", t => t.Household_Id)
                .Index(t => t.CHW_Id)
                .Index(t => t.PreviousVisits_Id)
                .Index(t => t.Household_Id);
            
            CreateTable(
                "dbo.ActionPerformeds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActionPerformedDescription = c.String(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Visit_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Visits", t => t.Visit_Id)
                .Index(t => t.Visit_Id);
            
            CreateTable(
                "dbo.FormDocuments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Clinic_Id = c.Int(nullable: false),
                        Form_Id = c.Int(nullable: false),
                        Municipality_Id = c.Int(nullable: false),
                        Province_Id = c.Int(nullable: false),
                        Ward_Id = c.Int(nullable: false),
                        Visit_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinics", t => t.Clinic_Id, cascadeDelete: true)
                .ForeignKey("dbo.Forms", t => t.Form_Id, cascadeDelete: true)
                .ForeignKey("dbo.Municipalities", t => t.Municipality_Id, cascadeDelete: true)
                .ForeignKey("dbo.Provinces", t => t.Province_Id, cascadeDelete: true)
                .ForeignKey("dbo.Wards", t => t.Ward_Id, cascadeDelete: true)
                .ForeignKey("dbo.Visits", t => t.Visit_Id)
                .Index(t => t.Clinic_Id)
                .Index(t => t.Form_Id)
                .Index(t => t.Municipality_Id)
                .Index(t => t.Province_Id)
                .Index(t => t.Ward_Id)
                .Index(t => t.Visit_Id);
            
            CreateTable(
                "dbo.Wards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WardDescription = c.String(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        CHW_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CHWs", t => t.CHW_Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex")
                .Index(t => t.CHW_Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "CHW_Id", "dbo.CHWs");
            DropForeignKey("dbo.Households", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Visits", "Household_Id", "dbo.Households");
            DropForeignKey("dbo.Visits", "PreviousVisits_Id", "dbo.Visits");
            DropForeignKey("dbo.FormDocuments", "Visit_Id", "dbo.Visits");
            DropForeignKey("dbo.FormDocuments", "Ward_Id", "dbo.Wards");
            DropForeignKey("dbo.Questions", "FormDocument_Id", "dbo.FormDocuments");
            DropForeignKey("dbo.FormDocuments", "Province_Id", "dbo.Provinces");
            DropForeignKey("dbo.FormDocuments", "Municipality_Id", "dbo.Municipalities");
            DropForeignKey("dbo.FormDocuments", "Form_Id", "dbo.Forms");
            DropForeignKey("dbo.FormDocuments", "Clinic_Id", "dbo.Clinics");
            DropForeignKey("dbo.Visits", "CHW_Id", "dbo.CHWs");
            DropForeignKey("dbo.ActionPerformeds", "Visit_Id", "dbo.Visits");
            DropForeignKey("dbo.Households", "Respondent_Id", "dbo.Respondents");
            DropForeignKey("dbo.CHWs", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Questions", "QuestionCategory_Id", "dbo.QuestionCategories");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", new[] { "CHW_Id" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.FormDocuments", new[] { "Visit_Id" });
            DropIndex("dbo.FormDocuments", new[] { "Ward_Id" });
            DropIndex("dbo.FormDocuments", new[] { "Province_Id" });
            DropIndex("dbo.FormDocuments", new[] { "Municipality_Id" });
            DropIndex("dbo.FormDocuments", new[] { "Form_Id" });
            DropIndex("dbo.FormDocuments", new[] { "Clinic_Id" });
            DropIndex("dbo.ActionPerformeds", new[] { "Visit_Id" });
            DropIndex("dbo.Visits", new[] { "Household_Id" });
            DropIndex("dbo.Visits", new[] { "PreviousVisits_Id" });
            DropIndex("dbo.Visits", new[] { "CHW_Id" });
            DropIndex("dbo.Households", new[] { "Team_Id" });
            DropIndex("dbo.Households", new[] { "Respondent_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Questions", new[] { "FormDocument_Id" });
            DropIndex("dbo.Questions", new[] { "QuestionCategory_Id" });
            DropIndex("dbo.CHWs", new[] { "Team_Id" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Wards");
            DropTable("dbo.FormDocuments");
            DropTable("dbo.ActionPerformeds");
            DropTable("dbo.Visits");
            DropTable("dbo.Respondents");
            DropTable("dbo.Households");
            DropTable("dbo.Teams");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.QuestionCategories");
            DropTable("dbo.Questions");
            DropTable("dbo.Provinces");
            DropTable("dbo.Municipalities");
            DropTable("dbo.Healths");
            DropTable("dbo.Forms");
            DropTable("dbo.Clinics");
            DropTable("dbo.CHWs");
        }
    }
}
