using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAssignment.Models
{
    public class CityInfo
    {
        public int ID { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
