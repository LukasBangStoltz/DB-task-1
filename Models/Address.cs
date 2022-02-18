using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAssignment.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string Street { get; set; }

        public int Number { get; set; }

        public List<Patient> Patients { get; set; } = new List<Patient>();
        public int? CityInfoId { get; set; }
        [ForeignKey("CityInfoId")]
        public CityInfo CityInfo { get; set; }
    }
}
