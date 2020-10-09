using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstΝame { get; set; }
        public string LastΝame { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Address Address { get; set; } 
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
