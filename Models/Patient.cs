using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tester.Models;

namespace HospitalAssignment.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public Address Address { get; set; }



        public List<Booking> Bookings { get; set; } = new List<Booking>();

    }
}
