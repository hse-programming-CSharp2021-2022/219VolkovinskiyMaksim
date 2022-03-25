using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    [Serializable]
    public class Department
    {
        public List<Professor> Employees { get; init; }
        public string Name { get; init; }
        public Department() { }
        public Department(string name, params Professor[] profs)
        {
            Name = name;
            Employees = profs.ToList();
        }
        public override string ToString()
        {
            string res = $"Dep. Name: {Name}\nEmployees:\n";
            Employees.ForEach(x => res += x.ToString() + "\n");
            return res;
        }

    }
}
