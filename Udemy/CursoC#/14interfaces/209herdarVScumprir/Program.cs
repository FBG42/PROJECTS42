using herdarVScumprir.entities;

namespace herdarVScumprir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ishape s1 = new circle()
            {
              radius = 2.0,
              color = enums.color.white
            };

            Ishape s2 = new rectangle()
            {
              width = 3.5,
              height = 4.2,
              color = enums.color.black
            };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}