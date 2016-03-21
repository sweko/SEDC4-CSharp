﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqClasses
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Age}) - {Gender}";
        }
    }
}
