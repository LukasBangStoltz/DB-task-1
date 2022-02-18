using System.Collections.Generic;

namespace Tester.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Field { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();

        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
