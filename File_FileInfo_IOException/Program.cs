using System;
//Biblioteca necessária para trabalhar com File, FileInfo
using System.IO;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * "@" significa que a string é um caminho para um arquivo.
             * Sem a "@", seria necessário usar barra dupla, ex:
             * "c:\\temp\\file1.txt"
            **/
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                //"CopyTo" irá copiar o conteúdo para o arquivo designado
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
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