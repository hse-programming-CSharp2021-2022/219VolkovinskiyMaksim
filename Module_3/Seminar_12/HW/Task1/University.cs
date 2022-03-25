using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task1
{
    [Serializable]
    public class University
    {
        public string Name { get; init; }
        [JsonInclude]
        public List<Department> Departments = new List<Department>();
        public University() { }
        public University(string name, List<Department> departments)
        {
            Name = name;
            Departments = departments;
        }
        public override string ToString()
        {
            string res = $"University Name: {Name}\nDepartments:\n";
            Departments.ForEach(x => res += x.ToString());
            return res;
        }
    }
}
