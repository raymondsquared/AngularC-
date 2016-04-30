﻿using System.Collections.Generic;

namespace AngularCSharp.Core.Models
{
    public class Person
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public IEnumerable<Pet> pets { get; set; }
    }

    public class Pet
    {
        public string name { get; set; }
        public string type { get; set; }
    }
}
