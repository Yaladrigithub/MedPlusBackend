using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedPlus.Models
{
    public class SalesPerson
    {
        
        public int SalesPersionId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Password { get; set; }
        public int IsActive { get; set; }
        public int AddedBy { get; set; }
        public DateTime AddedDate { get; set; }

    }
}