using ClinicWebForm.Classes;
using ClinicWebForm.Models;
using ClinicWebForm.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicWebForm.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectForm()
        {
            return View();
        }

        public ActionResult SelectedForm(int id)
        {
            string viewName = "";

            switch (id)
            {
                case 1:
                    viewName = "_CreateHouseHoldRegistration";
                    break;
                case 2:
                    viewName = "_CreateIndividualAdultHealthRecord";
                    break;
                case 3:
                    viewName = "_CreateMaternalandChildHealthRecord";
                    break;
                case 4:
                    viewName = "_CreateOTTemplate";
                    break;
                case 5:
                    viewName = "_CreateReferralForm";
                    break;
                case 6:
                    viewName = "_CreateVisitTick";
                    break;
            }

            return PartialView(viewName);
        }

        public ActionResult SubmitHouseHoldRegistration(HouseholdRegistrationViewModel householdRegistration)
        {
            try
            {
                using (var connection = AppUtils.GetOpenConnection())
                {
                    //Insert CHW 
                    CHW chw = householdRegistration.CHW;

                    string sql = @"INSERT INTO CHW (HouseholdIdNumber,Name) VALUES";
                    sql += "(@HouseholdIdNumber, @Name)";

                    Dapper.SqlMapper.Execute(connection, sql, chw);

                    //Insert Clinic
                    Clinic clinic = householdRegistration.Clinic;

                    sql = @"INSERT INTO clinic (ClinicDescription,Active) VALUES";
                    sql += "(@ClinicDescription, @Active)";

                    Dapper.SqlMapper.Execute(connection, sql, clinic);

                    //Insert Ward 
                    Ward ward = householdRegistration.Ward;

                    sql = @"INSERT INTO Ward (HouseholdIdNumber,Name) VALUES";
                    sql += "(@HouseholdIdNumber, @Name)";

                    Dapper.SqlMapper.Execute(connection, sql, ward);

                    //Insert House 
                    House house = householdRegistration.House;

                    sql = @"INSERT INTO House (HouseholdId,Electricity,PipedWater,Toilet,Fridge,Rooms,AmountOfGrants,AmountOfWorkingMembers,NameOfSchools) VALUES";
                    sql += "(@Household.Id,@Electricity,@PipedWater,@Toilet,@Fridge,@Rooms,@AmountOfGrants,@AmountOfWorkingMembers,@NameOfSchools)";

                    Dapper.SqlMapper.Execute(connection, sql, house);

                    //Insert IndividualMember 
                    foreach (var individualMember in householdRegistration.Members)
                    {
                        sql = @"INSERT INTO IndividualMember (HouseholdId,VisitId,NextOfKinId,RelationshipStatusId,Name,DOB,Age,Gender,Tel,BirthWeight,ReceivingGrant,Head) VALUES";
                        sql += "(@Household.Id,@Visit.Id,@NextOfKin.Id,@RelationshipStatus.Id,@Name,@DOB,@Age,@Gender,@Tel,@BirthWeight,@ReceivingGrant,@Head)";

                        Dapper.SqlMapper.Execute(connection, sql, individualMember);
                    }

                    //Insert Question 
                    foreach (var question in householdRegistration.Questions)
                    {
                        sql = @"INSERT INTO Questions (QuestionCategoryId,QuestionDescription,Active) VALUES";
                        sql += "(@QuestionCategory.Id,@QuestionDescription,@Active)";

                        Dapper.SqlMapper.Execute(connection, sql, question);
                    }
                }

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return PartialView("_CreateHouseHoldRegistration");
            }
        }

        public ActionResult SubmitIndividualAdultHealthRecord(IndividualAdultHealthRecordViewModel individualAdultHealthRecord)
        {
            try
            {
                using (var connection = AppUtils.GetOpenConnection())
                {
                    //Insert CHW 
                    CHW chw = individualAdultHealthRecord.CHW;

                    string sql = @"INSERT INTO CHW (HouseholdIdNumber,Name) VALUES";
                    sql += "(@HouseholdIdNumber, @Name)";

                    Dapper.SqlMapper.Execute(connection, sql, chw);

                    //Insert Clinic
                    Clinic clinic = individualAdultHealthRecord.Clinic;

                    sql = @"INSERT INTO clinic (ClinicDescription,Active) VALUES";
                    sql += "(@ClinicDescription, @Active)";

                    Dapper.SqlMapper.Execute(connection, sql, clinic);

                    //Insert Ward 
                    Ward ward = individualAdultHealthRecord.Ward;

                    sql = @"INSERT INTO Ward (HouseholdIdNumber,Name) VALUES";
                    sql += "(@HouseholdIdNumber, @Name)";

                    Dapper.SqlMapper.Execute(connection, sql, ward);

                    //Insert Household
                    Household household = individualAdultHealthRecord.Household;

                    sql = @"INSERT INTO Household (VisitId,Address,RespondentId,AllMembersRegistered,PregnancyPerionIn6Weeks,Note) VALUES";
                    sql += "(@Visit.Id,@Address,@RespondentId,@AllMembersRegistered,@PregnancyPerionIn6Weeks,@Note)";

                    Dapper.SqlMapper.Execute(connection, sql, household);

                    //Insert NextOfKin 
                    NextOfKin nextOfKin = individualAdultHealthRecord.NextOfKin;

                    sql = @"INSERT INTO NextOfKin (Name,ContactNumber) VALUES";
                    sql += "(@Name,@ContactNumber)";

                    Dapper.SqlMapper.Execute(connection, sql, nextOfKin);

                    //Insert IndividualMember 
                    IndividualMember member = individualAdultHealthRecord.Head;

                    sql = @"INSERT INTO IndividualMember (HouseholdId,VisitId,NextOfKinId,RelationshipStatusId,Name,DOB,Age,Gender,Tel,BirthWeight,ReceivingGrant,Head) VALUES";
                    sql += "(@Household.Id,@Visit.Id,@NextOfKin.Id,@RelationshipStatus.Id,@Name,@DOB,@Age,@Gender,@Tel,@BirthWeight,@ReceivingGrant,@Head)";

                    Dapper.SqlMapper.Execute(connection, sql, member);

                    //Insert Visits 
                    foreach (var visits in individualAdultHealthRecord.Visits)
                    {
                        sql = @"INSERT INTO Visits (UserId,CHWId,PreviousVisitId,ActionPerformedId,VisitDate) VALUES";
                        sql += "(@User.Id,@CHW.Id,@PreviousVisitId,@ActionPerformedId,@VisitDate)";

                        Dapper.SqlMapper.Execute(connection, sql, visits);
                    }

                    //Insert Referrals 
                    foreach (var referral in individualAdultHealthRecord.Referrals)
                    {
                        sql = @"INSERT INTO Referral (VisitId,ReferralReasonId,ReferralOutcome,ReferredTo,BackReferralReceived) VALUES";
                        sql += "(@Visit.Id,@ReferralReason.Id,@ReferralOutcome,@ReferredTo,@BackReferralReceived)";

                        Dapper.SqlMapper.Execute(connection, sql, referral);
                    }
                }

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return PartialView("_CreateIndividualAdultHealthRecord");
            }
        }

        public ActionResult SubmitMaternalandChildHealthRecord(MaternalandChildHealthRecordViewModel maternalAndChild)
        {
            try
            {
                using (var connection = AppUtils.GetOpenConnection())
                {
                    //Insert CHW 
                    CHW chw = maternalAndChild.CHW;

                    string sql = @"INSERT INTO CHW (HouseholdIdNumber,Name) VALUES";
                    sql += "(@HouseholdIdNumber, @Name)";

                    Dapper.SqlMapper.Execute(connection, sql, chw);

                    //Insert Clinic
                    Clinic clinic = maternalAndChild.Clinic;

                    sql = @"INSERT INTO clinic (ClinicDescription,Active) VALUES";
                    sql += "(@ClinicDescription, @Active)";

                    Dapper.SqlMapper.Execute(connection, sql, clinic);

                    //Insert Ward 
                    Ward ward = maternalAndChild.Ward;

                    sql = @"INSERT INTO Ward (HouseholdIdNumber,Name) VALUES";
                    sql += "(@HouseholdIdNumber, @Name)";

                    Dapper.SqlMapper.Execute(connection, sql, ward);

                    //Insert IndividualMember Mother
                    IndividualMember mother = maternalAndChild.Mother;

                    sql = @"INSERT INTO IndividualMember (HouseholdId,VisitId,NextOfKinId,RelationshipStatusId,Name,DOB,Age,Gender,Tel,BirthWeight,ReceivingGrant,Head) VALUES";
                    sql += "(@Household.Id,@Visit.Id,@NextOfKin.Id,@RelationshipStatus.Id,@Name,@DOB,@Age,@Gender,@Tel,@BirthWeight,@ReceivingGrant,@Head)";

                    Dapper.SqlMapper.Execute(connection, sql, mother);

                    //Insert IndividualMember Child
                    IndividualMember child= maternalAndChild.Child;

                    sql = @"INSERT INTO IndividualMember (HouseholdId,VisitId,NextOfKinId,RelationshipStatusId,Name,DOB,Age,Gender,Tel,BirthWeight,ReceivingGrant,Head) VALUES";
                    sql += "(@Household.Id,@Visit.Id,@NextOfKin.Id,@RelationshipStatus.Id,@Name,@DOB,@Age,@Gender,@Tel,@BirthWeight,@ReceivingGrant,@Head)";

                    Dapper.SqlMapper.Execute(connection, sql, child);

                    //Insert Visits 
                    foreach (var visits in maternalAndChild.Visits)
                    {
                        sql = @"INSERT INTO Visits (UserId,CHWId,PreviousVisitId,ActionPerformedId,VisitDate) VALUES";
                        sql += "(@User.Id,@CHW.Id,@PreviousVisitId,@ActionPerformedId,@VisitDate)";

                        Dapper.SqlMapper.Execute(connection, sql, visits);
                    }

                    //Insert Question 
                    foreach (var question in maternalAndChild.Questions)
                    {
                        sql = @"INSERT INTO Questions (QuestionCategoryId,QuestionDescription,Active) VALUES";
                        sql += "(@QuestionCategory.Id,@QuestionDescription,@Active)";

                        Dapper.SqlMapper.Execute(connection, sql, question);
                    }
                }

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return PartialView("_CreateMaternalandChildHealthRecord");
            }
        }

        public ActionResult SubmitReferral(ReferralViewModel referral)
        {
            try
            {
                using (var connection = AppUtils.GetOpenConnection())
                {
                    //Insert CHW 
                    CHW chw = referral.CHW;

                    string sql = @"INSERT INTO CHW (HouseholdIdNumber,Name) VALUES";
                    sql += "(@HouseholdIdNumber, @Name)";

                    Dapper.SqlMapper.Execute(connection, sql, chw);

                    //Insert Clinic
                    Clinic clinic = referral.Clinic;

                    sql = @"INSERT INTO clinic (ClinicDescription,Active) VALUES";
                    sql += "(@ClinicDescription, @Active)";

                    Dapper.SqlMapper.Execute(connection, sql, clinic);

                    //Insert Ward 
                    Ward ward = referral.Ward;

                    sql = @"INSERT INTO Ward (HouseholdIdNumber,Name) VALUES";
                    sql += "(@HouseholdIdNumber, @Name)";

                    Dapper.SqlMapper.Execute(connection, sql, ward);

                    //Insert House 
                    Referral objReferral = referral.Referral;

                    sql = @"INSERT INTO Referrals (VisitId,ReferralReasonId,ReferralOutcome,ReferredTo,BackReferralReceived) VALUES";
                    sql += "(@Visit.Id,@ReferralReason.Id,@ReferralOutcome,@ReferredTo,@BackReferralReceived)";

                    Dapper.SqlMapper.Execute(connection, sql, objReferral);

                    //Insert IndividualMember 
                    IndividualMember individualMember = referral.Member;

                    sql = @"INSERT INTO IndividualMember (HouseholdId,VisitId,NextOfKinId,RelationshipStatusId,Name,DOB,Age,Gender,Tel,BirthWeight,ReceivingGrant,Head) VALUES";
                    sql += "(@Household.Id,@Visit.Id,@NextOfKin.Id,@RelationshipStatus.Id,@Name,@DOB,@Age,@Gender,@Tel,@BirthWeight,@ReceivingGrant,@Head)";

                    Dapper.SqlMapper.Execute(connection, sql, individualMember);

                    //Insert Question 
                    foreach (var question in referral.Questions)
                    {
                        sql = @"INSERT INTO Questions (QuestionCategoryId,QuestionDescription,Active) VALUES";
                        sql += "(@QuestionCategory.Id,@QuestionDescription,@Active)";

                        Dapper.SqlMapper.Execute(connection, sql, question);
                    }
                }

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return PartialView("_CreateReferralForm");
            }
        }

        public ActionResult ListAll()
        {
            return View();
        }

        public ActionResult SelectedFormType(int id)
        {
            string viewName = "";
            
            switch (id)
            {
                case 1:
                    viewName = "_ListHouseHoldRegistration";
                    var list = SelectDBObjects.LoadHouseholdRegistrationViewModels();
                    return PartialView(viewName, list);
                case 2:
                    viewName = "_ListIndividualAdultHealthRecord";
                    var list1 = SelectDBObjects.LoadIndividualAdultHealthRecord();
                    return PartialView(viewName, list1);
                case 3:
                    viewName = "_ListMaternalandChildHealthRecord";
                    var list2 = SelectDBObjects.LoadHouseholdRegistrationViewModels();
                    return PartialView(viewName, list2);
                case 4:
                    viewName = "_ListOTTemplate";
                    var list3 = SelectDBObjects.LoadHouseholdRegistrationViewModels();
                    return PartialView(viewName, list3);
                case 5:
                    viewName = "_ListReferralForm";
                    var list4 = SelectDBObjects.LoadHouseholdRegistrationViewModels();
                    return PartialView(viewName, list4);
                case 6:
                    viewName = "_ListVisitTick";
                    var list5 = SelectDBObjects.LoadHouseholdRegistrationViewModels();
                    return PartialView(viewName, list5);
                default:
                    return PartialView(viewName);
            }
        }
    }
}