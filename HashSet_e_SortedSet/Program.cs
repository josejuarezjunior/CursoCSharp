using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_e_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("HashSet");
            Console.WriteLine();

            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine("Exibindo itens da lista 'set'.");
            Console.WriteLine();
           
            foreach (String p in set)
            {
                Console.WriteLine(p);
            }

            /*
            * A lista de string 'set' contém "Notebook"?
            * O método 'Contains' irá verificar e retornar
            * um valor booleano.
            */

            Console.WriteLine();
            Console.WriteLine("A lista contém 'Notebook'?");
            Console.WriteLine(set.Contains("Notebook"));
            Console.WriteLine();
            Console.WriteLine("A lista contém 'Computer'?");
            Console.WriteLine(set.Contains("Computer"));

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("SortedSet");
            Console.WriteLine();

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Collection 'a'");
            printCollection(a);

            Console.WriteLine();
            Console.WriteLine("Collection 'b'");
            printCollection(b);

            
            Console.WriteLine("Collection 'c' = 'a'");
            SortedSet<int> c = new SortedSet<int>(a);
            //union
            Console.WriteLine();
            Console.WriteLine("Union 'c' with 'b':");
            c.UnionWith(b);
            printCollection(c);

            Console.WriteLine();
            Console.WriteLine("Collection 'd' = 'a'");
            SortedSet<int> d = new SortedSet<int>(a);
            //intersection
            Console.WriteLine();
            Console.WriteLine("Intersection 'd' with 'b'");
            d.IntersectWith(b);
            printCollection(d);

            Console.WriteLine("Collection 'e' = 'a'");
            SortedSet<int> e = new SortedSet<int>(a);
            //difference
            Console.WriteLine();
            Console.WriteLine("Difference 'e' with 'b'");
            e.ExceptWith(b);
            printCollection(e);

        }
        //Coleção do tipo Generics "printCollection<T>"
        /*
         * IEnumerable é uma interface implementada por todas coleções básicas
         * do pacote 'System.Collection'
         */
        static void printCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
