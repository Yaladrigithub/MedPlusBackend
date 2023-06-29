using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedPlus.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Contact { get; set; }
        public int IsActive { get; set; }
    }
}