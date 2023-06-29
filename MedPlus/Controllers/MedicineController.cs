using MedPlus.DataAccess;
using MedPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MedPlus.Controllers
{
    public class MedicineController : ApiController
    {
        [HttpPost]
        public IHttpActionResult AddMedicine(MedicineData medicine)
        {
            medicine.DateAdded = DateTime.Now;


            MedicineDataAccess dataAccess = new MedicineDataAccess();
            int status=dataAccess.MedicinDb(medicine);
            if (status>0)
            {
                return Ok("Medicines added successfully");
            }
            else
            {
               return BadRequest("medicines not added");
            }
            
        }
    }
}
