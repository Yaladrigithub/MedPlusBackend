using MedPlus.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MedPlus.DataAccess
{
    public class AdminDataAccess
    {
        public int AddAdmin(Admin admin)
        {
            string connectionstring = "Persist Security Info = False; User ID = rkp; password = Rk@123987; Initial Catalog = MedPlus; Data Source = rk.database.windows.net";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = string.Format("insert into MDP_Admin(Name,UserName,Password,Contact,IsActive)values('{0}','{1}','{2}','{3}',{4})",
                admin.Name, admin.UserName, admin.Password, admin.Contact, admin.IsActive);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            int result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }
}