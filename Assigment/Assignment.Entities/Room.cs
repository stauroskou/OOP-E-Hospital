using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
   public class Room
    {
        public int Id { get;  set; }
        public string Title {  get;  set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
