﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Disease
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public List<Patient> patients { get; set; } = new List<Patient>();
    }
}
