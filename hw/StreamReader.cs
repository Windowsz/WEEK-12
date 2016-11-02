using System;
using System.IO; //for Streamreader
    class Program
    {
        static void Main(string[] args)
        {
        StreamReader r = new StreamReader("Hello.txt",true);
        string text = r.ReadToEnd();
        Console.WriteLine(text);
        r.Close();
        Console.ReadLine();
        }
    }
