using ClinicWebForm.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Utils
{
    public class AppUtils
    {
        //public const string ConnectionString = "Data Source=10.239.137.108;Database=health;User Id=sa;Password=Fluffy01;Pooling=false;";
        public static string WordTemplateDirectory = HttpContext.Current.Server.MapPath("~/DocumentTemplates/");

        public static string ConnectionString
        {
            get
            {
                return (string)System.Configuration.ConfigurationManager.ConnectionStrings["healthConnStr"].ConnectionString;
            }
        }

        public static SqlConnection GetOpenConnection()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public static void InsertClinic(Clinic clinic)
        {
            string sql = @"INSERT INTO Clinic (ClinicDescription,Active) VALUES";
            sql += "(@ClinicDescription,@Active)";

            using (var connection = AppUtils.GetOpenConnection())
            {
                Dapper.SqlMapper.Execute(connection, sql, clinic);
            }
        }

        public static void InsertWard(Ward ward)
        {
            string sql = @"INSERT INTO Ward (WardDescription,Active) VALUES";
            sql += "(@WardDescription,@Active)";

            using (var connection = AppUtils.GetOpenConnection())
            {
                Dapper.SqlMapper.Execute(connection, sql, ward);
            }
        }

        public static void InsertCHW(CHW chw)
        {
            string sql = @"INSERT INTO CHW (HouseholdIdNumber,Name) VALUES";
            sql += "(@HouseholdIdNumber,@Name)";

            using (var connection = AppUtils.GetOpenConnection())
            {
                Dapper.SqlMapper.Execute(connection, sql, chw);
            }
        }
    }
}