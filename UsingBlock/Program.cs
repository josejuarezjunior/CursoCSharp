using System;
using System.IO;
namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula 188
            string path = @"c:\temp\file1.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}