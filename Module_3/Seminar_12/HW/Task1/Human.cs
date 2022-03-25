using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    [Serializable]
    public class Human
    {
        public string Name { get; init; }
        public int Age { get; init; }
        public Human() { }
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}";
        }
    }
}
