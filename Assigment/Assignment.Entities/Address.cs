using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public List<Doctor> doctors { get; set; } = new List<Doctor>();
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
