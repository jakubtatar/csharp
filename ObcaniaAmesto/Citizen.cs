﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcaniaAmesto
{
    public class Citizen
    {
        public string Name { get; set; }
        public int Age { get; set; }



        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void VypisInfo()
        {           
            Console.WriteLine("Meno: " + Name + ", Vek: " + Age);           
        }

        public virtual void VypisVek()
        {
            Console.WriteLine("Vek: " + Age);
        }
    }
}
