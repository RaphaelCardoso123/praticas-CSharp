using System;

namespace SegundoProjeto.Devices
{
    class Printer : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }
        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
