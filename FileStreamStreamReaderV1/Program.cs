using System;
using System.IO;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula 187
            //Caminho do arquivo externo
            string path = @"c:\temp\file1.txt";
            /*
             * FileStream nos permite fazer entrada e saída de dados em um arquivo externo.
             * FileStream é uma steram binária
            */
            FileStream fs = null;
            /*
             * StremReader é um objeto instanciado à partir do FileStream.
             * É uma stream (sequência de dados) de caracteres.
            */
            StreamReader sr = null;
            try
            {
                /*
                 * Primeira mente é instanciado um FileStream, associado à um arquivo externo
                 * depois é instanciado um StreamReader associado à ao FileStream.
                */
                fs = new FileStream(path, FileMode.Open); // File.OpenRead(path);
                sr = new StreamReader(fs);
                //Associando uma linha do arquivo à uma string
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                /*
                 * Como o recurso aberto(o arquivo externo) não é gerenciado
                 * pelo CLR do .NET, é necessário fechar esse arquivo manualmente!!!
                 * Abaixo o procedimento para fechar os recursos.
                */
                //Se o StreaReader é diferente de nulo, chamar o método Close para ele.
                if (sr != null) sr.Close();
                //Se o FileStream é diferente de nulo, chamar o método Close para ele.
                if (fs != null) fs.Close();
            }
        }
    }
}