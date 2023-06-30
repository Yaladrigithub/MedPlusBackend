using MedPlus.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MedPlus.DataAccess
{
    public class SaalesPersonDataAccess
    {
        public int AddSalesPerson(SalesPerson salesperson)
        {
            string connectionstring = "Persist Security Info = False; User ID = rkp; password = Rk@123987; Initial Catalog = MedPlus; Data Source = rk.database.windows.net";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = string.Format("insert into ME_AddSalesPerson(Name,Contact,Password,IsActive,AddedBy,AddedDate)values('{0}','{1}','{2}',{3},{4},'{5}')",salesperson.Name, salesperson.Contact, salesperson.Password, salesperson.IsActive, salesperson.AddedBy, salesperson.AddedDate);

            SqlCommand cmd = new SqlCommand(query, con);
            int result = cmd.ExecuteNonQuery();
            return result;
        }
    }
}
