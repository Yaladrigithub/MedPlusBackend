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
    public class AdminController : ApiController
    {

        //Add admin
        [HttpPost]
        public IHttpActionResult AddAdmin(Admin admin)
        {
            AdminDataAccess adminDataAccess = new AdminDataAccess();
            int count = adminDataAccess.AddAdmin(admin);
            if (count > 0)
                return Ok("Admin added successfully!");
            else
                return BadRequest("Admin failed to add!");
        }

        //Login admin

        //Update admin
    }
}
