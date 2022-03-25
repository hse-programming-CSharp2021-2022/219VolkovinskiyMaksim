using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task1
{
    public class Program
    {
        [Serializable]
        public class Student
        {
            public int Course { get; set; }
            public string Surname { get; set; }
            public Student () { }
            public Student(int course, string surname)
            {
                Course = course;
                Surname = surname;
            }
        }

        [Serializable]
        public class Group
        {
            public int Id { get; set; }
            public List<Student> Students { get; set; }
            public Group() { }
            public Group(int id, List<Student> students)
            {
                Id = id;
                Students = students;
            }
            public override string ToString()
            {
                string res = $"Group: {Id}\nStudents:\n";
                Students.ForEach(x =>
                res += $"Surname: {x.Surname}\tCourse: {x.Course}\n");
                return res;
            }
        }

        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Артэмаф");
            Student s2 = new Student(3, "3-ий раз поступил на ПИ");
            List<Student> students1 = new List<Student>();
            students1.Add(s1);
            students1.Add(s2);
            Group gr1 = new(219, students1);
            Student s3 = new Student(1, "Саня саанечка");
            Student s4 = new Student(1, "АНДРЕЙ ГРЕЧКА");
            List<Student> students2 = new List<Student>();
            students2.Add(s3);
            students2.Add(s4);
            Group gr2 = new(218, students2);
            Group[] groups = { gr1, gr2 };

            //байнари
            BinaryFormatter bFormatter = new();

            using (FileStream fs = new FileStream("1.txt", FileMode.OpenOrCreate))
            {
                bFormatter.Serialize(fs, groups);
            }
            using (FileStream fs = new FileStream("1.txt", FileMode.OpenOrCreate))
            {
                Group[] gg = (Group[])bFormatter.Deserialize(fs);
                Array.ForEach(gg, x => Console.WriteLine(x));
            }

            //ХМЛ
            XmlSerializer xmlSerializer = new(typeof(Group[]));

            using (FileStream fs = new FileStream("2.txt", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, groups);
            }
            using (FileStream fs = new FileStream("2.txt", FileMode.OpenOrCreate))
            {
                Group[] gg = (Group[])xmlSerializer.Deserialize(fs);
                Array.ForEach(gg, x => Console.WriteLine(x));
            }

            //джейсон
            string json = JsonSerializer.Serialize<Group[]>(groups);

            Group[] gg1 = (Group[])JsonSerializer.Deserialize<Group[]>(json);
            Array.ForEach(gg1, x => Console.WriteLine(x));

        }
    }
}
