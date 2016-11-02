using System;
using System.IO; // use for steamreader

class Program
    {
        static void Main(string[] args)
        {
        StreamWriter w = new StreamWriter("hello.txt", true);
        w.WriteLine("Hello world! na ja");
        w.Close();
        }
    }

