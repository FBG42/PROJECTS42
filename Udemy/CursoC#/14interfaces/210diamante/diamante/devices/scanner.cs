using System;

namespace diamante.devices
{
    public class scanner : device, IScanner
    {
        public override void processDoc(string document)
        {
            System.Console.WriteLine("Scanner processing:" + document);
        }

        public string scan() {
            return "Scanner result";
        }
    }
}
