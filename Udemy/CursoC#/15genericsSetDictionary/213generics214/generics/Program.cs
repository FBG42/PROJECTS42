namespace generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            printService _printService = new printService(n);


            for (int i = 0; i < n; i++)
            {
              int x = int.Parse(Console.ReadLine());
              _printService.addValue(x);
            }

            _printService.print();
            Console.WriteLine("First " + _printService.first());
        }
    }
}