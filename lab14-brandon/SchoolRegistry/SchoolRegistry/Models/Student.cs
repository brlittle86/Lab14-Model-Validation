﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegistry.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int Age { get; set; }
        public DateTime Birthdate { get; set; }
    }
}