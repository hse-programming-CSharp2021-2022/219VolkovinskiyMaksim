using System;
using System.Text;
using System.Linq;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoFile separateVF = new VideoFile("Raze", 7, 10000);
            Console.WriteLine($"Изначальный файл:\n{separateVF}");
            Random rand = new Random();
            int n = rand.Next(5, 16);
            VideoFile[] arr = new VideoFile[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new VideoFile(GenerateName(), rand.Next(60, 361), rand.Next(100, 1001));
            }
            var selected = arr.Where(x => x.Size > separateVF.Size).Select(x => x).ToArray();
            Console.WriteLine("Файлы, размер которых больше размера изначального файла:");
            Array.ForEach(selected, x => Console.WriteLine(x));
        }

        public static string GenerateName()
        {
            Random rand = new Random();
            int l = rand.Next(2, 10);
            StringBuilder s = new StringBuilder();
            for (int i = 0;i < l; i++)
            {
                s.Append((char)rand.Next(65, 91));
            }
            return s.ToString();
        }
    }

    internal class VideoFile
    {
        private string name;
        private int duration;
        private int quality;

        public int Size { get => duration * quality; }
        public VideoFile(string name, int duration, int quality)
        {
            this.name = name;
            this.duration = duration;    
            this.quality = quality;
        }

        public override string ToString()
        {
            return $"Имя:{name,-10}Длительность:{duration,-7}Качество:{quality,-7}Размер:{Size,-10}";
        }
    }
}
