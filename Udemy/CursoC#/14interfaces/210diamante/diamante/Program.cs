using diamante.devices;

namespace diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printer p = new printer() { serialNumber = 1000 };
            p.processDoc("My letter");
            p.print("my letter");

            scanner s = new scanner() { serialNumber = 2003 };
            s.processDoc("My letter");
            System.Console.WriteLine(s.scan());

            comboDevice c = new comboDevice() { serialNumber = 3921 };
            c.processDoc("My dissertation");
            c.print("My dissertation");
            System.Console.WriteLine(c.scan());
        }
    }
}