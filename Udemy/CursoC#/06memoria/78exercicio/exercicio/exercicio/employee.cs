using System.Xml.Linq;

namespace exercicio
{
    internal class employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }


        public void increaseSalary(double percentage)
        {
            double toIncrease = salary * percentage / 100.0;
            salary += toIncrease;
        }


        public override string ToString()
        {
            return $"{id}, {name}, {salary}";
        }
    }
}
