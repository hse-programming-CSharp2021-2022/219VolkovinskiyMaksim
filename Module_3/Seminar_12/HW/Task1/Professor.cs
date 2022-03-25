using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    [Serializable]
    public class Professor : Human
    {
        public string Post { get; init; }
        public Professor(string name, int age, string post): base(name, age)
        {
            Post = post;
        }
        public Professor() { }

        public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}\tPost: {Post}";
        }
    }
}
