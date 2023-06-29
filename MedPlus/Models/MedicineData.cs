using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedPlus.Models
{
    public class MedicineData
    {
        public string MedicineName { get; set; }
        public float Cost { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int MedcineAddedBy { get; set; }
        
    }
}