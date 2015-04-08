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
    }
}