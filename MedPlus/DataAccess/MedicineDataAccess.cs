using MedPlus.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MedPlus.DataAccess
{
    public class MedicineDataAccess
    {
       public int MedicinDb(MedicineData data)
       {
            string connectionstring= "Persist Security Info = False; User ID = rkp; password = Rk@123987; Initial Catalog = MedPlus; Data Source = rk.database.windows.net";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = string.Format("insert into ME_AddMedicine(MedicineName,Cost,DateAdded,ExpiryDate,MedcineAddedBy) values('{0}',{1},'{2}','{3}',{4})",
            data.MedicineName,data.Cost,data.DateAdded.ToString("MM-dd-yyyy HH:mm:ss"),data.ExpiryDate,data.MedcineAddedBy);
            SqlCommand cmd = new SqlCommand(query,con);
            int result=cmd.ExecuteNonQuery();
            return result;
       }

    }
}