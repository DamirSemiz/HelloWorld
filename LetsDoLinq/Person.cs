using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsDoLinq
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int WorkPlaceID { get; set; }

        public Person(string name, int age, int workPlaceID)
        {
            Name = name;
            Age = age;
            WorkPlaceID = workPlaceID;
        }

        public override string ToString()
        {
            return $" Name: {Name} Age: {Age}";
        }
    }
}
