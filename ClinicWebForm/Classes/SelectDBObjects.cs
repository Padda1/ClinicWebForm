using ClinicWebForm.Models;
using ClinicWebForm.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Classes
{
    public static class SelectDBObjects
    {
        public static List<HouseholdRegistrationViewModel> LoadHouseholdRegistrationViewModels()
        {
            //TODO: To be completed properly
            List<HouseholdRegistrationViewModel> list = new List<HouseholdRegistrationViewModel>();

            using (var connection = AppUtils.GetOpenConnection())
            {
                string sql = "select top 100 * from Visit";
                List<Visit>  visits = Dapper.SqlMapper.Query<Visit>(connection, sql).ToList();

                foreach(Visit visit in visits)
                {
                    HouseholdRegistrationViewModel model = new HouseholdRegistrationViewModel();

                    model.House.Household.Visit = visit;
                    list.Add(model);
                }
            }

            return list;
        }

        public static List<HouseholdRegistrationViewModel> LoadIndividualAdultHealthRecord()
        {
            //TODO: To be completed properly
            List<HouseholdRegistrationViewModel> list = new List<HouseholdRegistrationViewModel>();

            using (var connection = AppUtils.GetOpenConnection())
            {
                string sql = "select top 100 * from Visit";
                List<Visit> visits = Dapper.SqlMapper.Query<Visit>(connection, sql).ToList();

                foreach (Visit visit in visits)
                {
                    HouseholdRegistrationViewModel model = new HouseholdRegistrationViewModel();

                    model.House.Household.Visit = visit;
                    list.Add(model);
                }
            }

            return list;
        }
    }
}