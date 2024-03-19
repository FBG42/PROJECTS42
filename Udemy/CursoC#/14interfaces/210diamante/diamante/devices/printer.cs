using System;

namespace diamante.devices
{
    public class printer : device, IPrinter
    {
        public override void processDoc(string document)
        {
            System.Console.WriteLine("Printer processing:" + document);
        }

        public void print(string document) {
            System.Console.WriteLine("Printer print" + document);
        }
    }
}
