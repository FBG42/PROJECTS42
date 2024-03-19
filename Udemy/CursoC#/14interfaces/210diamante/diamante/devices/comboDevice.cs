using System;

namespace diamante.devices
{
    public class comboDevice: device, IScanner, IPrinter
    {
        public override void processDoc(string document)
        {
            System.Console.WriteLine("Printer processing:" + document);
        }

        public string scan() {
            return "Scanner result";
        }

        public void print(string document) {
            System.Console.WriteLine("Printer print" + document);
        }
    }
}
