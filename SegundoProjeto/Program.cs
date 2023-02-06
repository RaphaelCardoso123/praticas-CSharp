using System;
using SegundoProjeto.Devices;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1000 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            Console.ReadLine();
        }
    }
}
