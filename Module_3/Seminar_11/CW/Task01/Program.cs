

string s;
using (FileStream fstream = File.OpenRead($"note.txt"))
{
    byte[] array = new byte[fstream.Length];
    fstream.Read(array, 0, array.Length);
 
    string textFromFile = System.Text.Encoding.Default.GetString(array);
    s = textFromFile;
    Console.WriteLine($"Текст из файла: {textFromFile}");
}
using (FileStream fstream = new FileStream($"note.txt", FileMode.OpenOrCreate))
{
    fstream.Seek(0, SeekOrigin.End);
    if (!string.IsNullOrEmpty(s) && s[^1] < 'D')
    {
        byte[] array = System.Text.Encoding.Default.GetBytes(((char) (s[^1] + 1)).ToString());
        fstream.Write(array, 0, array.Length);
        Console.WriteLine("Текст записан в файл");
    }
    else if(fstream.Length==0)
    {
        byte[] array = System.Text.Encoding.Default.GetBytes("A");
        fstream.Write(array, 0, array.Length);
        Console.WriteLine("Текст записан в файл");
    }
}