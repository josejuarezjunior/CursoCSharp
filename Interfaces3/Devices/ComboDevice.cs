using System;

namespace Interfaces3.Devices
{

    /*
     * Essa classe implementa a classe abstrata "Device"
     * e realiza as interfaces "IScanner" e "IPrinter":
     */
    class ComboDevice : Device, IScanner, IPrinter
    {
        /*
         * O método "Print" é a realização do contrato com
         * a interface "IPrinter"
         */
        public void Print(string document)
        {
            Console.WriteLine("Combodevice print " + document);
        }
        /*
         * O método "ProcessDoc" é a implementação da super classe
         * "Device", sendo sobrescrito (override).
         */
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combodevice processing " + document);
        }

        /*
         * O método "Scan" é a realização do contrato com
         * a interface "IScanner"
         */

        public string Scan()
        {
            return "Combodevice scan result";
        }
    }
}