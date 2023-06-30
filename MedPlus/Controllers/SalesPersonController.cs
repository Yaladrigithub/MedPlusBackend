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
    public class SalesPersonController : ApiController
    {
        //Add Sales 
        [HttpPost]
        public IHttpActionResult AddSales(SalesPerson saleperson )
        {
            SaalesPersonDataAccess salespersondataaccess = new SaalesPersonDataAccess();
            int count=salespersondataaccess.AddSalesPerson(saleperson);
            if (count > 0)
                return Ok("SalesPerson added successfully!");
            else
                return BadRequest("SalesPerson failed to add!");

            
        }
    }
}
