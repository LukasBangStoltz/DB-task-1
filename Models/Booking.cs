using HospitalAssignment.Models;
using System;
using System.Collections.Generic;

namespace Tester.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public string Description { get; set; }

        public bool IsMissed { get; set; }  
        public Patient Patient { get; set; }

        public Employee Employee { get; set; }



        


    }
}
