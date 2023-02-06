using System;

namespace SegundoProjeto.Devices
{
    class Scanner : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner process: " + document);
        }
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
