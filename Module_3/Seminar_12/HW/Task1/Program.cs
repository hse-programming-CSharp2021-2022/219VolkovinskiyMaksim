using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor p1 = new("Леви", 21, "Младший лейтенант");
            Professor p2 = new("Арима", 993, "Убийца гулей");
            Professor p3 = new("Киллуа", 13, "Электрик");
            Professor p4 = new("Саске", 17, "Братоубийца");
            Professor p5 = new("Цунаде", 228, "Госпожа 5ая");
            Professor p6 = new("Аомине Дайки", 16, "Баскетболист");
            Department dep1 = new("Спорт", p1, p2);
            Department dep2 = new("Философия дединсайдиков", p3, p6);
            Department dep3 = new("История", p4, p5);
            List<Department> deps1 = new List<Department> { dep1, dep2 };
            List<Department> deps2 = new List<Department> { dep2, dep3 };
            University univ1 = new("Высшая Школа Анархии", deps1);
            University univ2 = new("Московский Государственный ШлакБАУМ", deps2);
            University[] univs = { univ1, univ2 };

            //байнари
            BinaryFormatter bFormatter = new();
            using (FileStream fs = new("1.txt", FileMode.OpenOrCreate))
            {
                bFormatter.Serialize(fs, univs);
            }
            using (FileStream fs = new("1.txt", FileMode.OpenOrCreate))
            {
                University[] gotUnivs = (University[])bFormatter.Deserialize(fs);
                Array.ForEach(gotUnivs, x => Console.WriteLine(x));
            }

            Console.ReadKey();
            Console.Clear();

            //ХМЛ
            XmlSerializer xmlSerializer = new(typeof(University[]));
            using (FileStream fs = new("2.txt", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, univs);
            }
            using (FileStream fs = new("2.txt", FileMode.OpenOrCreate))
            {
                University[] gotUnivs = (University[])xmlSerializer.Deserialize(fs);
                Array.ForEach(gotUnivs, x => Console.WriteLine(x));
            }

            Console.ReadKey();
            Console.Clear();

            //джейсон
            string json = JsonSerializer.Serialize(univs);
            File.WriteAllText("3.json", json);
            University[] gotUnivs1 = JsonSerializer.Deserialize<University[]>(
                File.ReadAllText("3.json"));
            Array.ForEach(gotUnivs1, x => Console.WriteLine(x));
        }
    }
}
