using System;
using System.Text.RegularExpressions;


class Program
{
	public static void Main()
	{
        Regex regex = new Regex(@"\d{3}\w{3}");
        Console.WriteLine(regex.IsMatch("1a2b3c"));
        Console.WriteLine(regex.IsMatch("123abc"));
        Console.WriteLine(regex.IsMatch("123123abc"));
        Console.WriteLine(regex.IsMatch("abc123"));
        Console.WriteLine(regex.IsMatch("aaa111aaa"));
    }

    void Meth(int x)
    {

    }
    void Meth (uint x)
    {

    }

}
