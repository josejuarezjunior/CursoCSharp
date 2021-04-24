using System;
using Interfaces3.Devices;

namespace Interfaces3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Object type Printer: ");
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");
            Console.WriteLine();

            Console.WriteLine("Object type Scanner: ");
            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());
            Console.WriteLine();

            Console.WriteLine("Object type ComboDevice: ");
            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
