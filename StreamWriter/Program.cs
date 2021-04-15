using System;
using System.IO;
namespace StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";
            try
            {
                // As linhas do arquivo de origem serão lidas
                string[] lines = File.ReadAllLines(sourcePath);
                //As linhas serão adcionadas no arquivo de destino
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        //Serão escritas em letras maiúsculas
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (
          IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}