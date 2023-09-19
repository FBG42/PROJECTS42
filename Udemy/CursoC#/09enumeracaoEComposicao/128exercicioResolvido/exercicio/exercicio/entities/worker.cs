using exercicio.entities.enums;
using System.Collections.Generic;

namespace exercicio.entities
{
    internal class worker
    {
        public string name { get; set; }
        public workerLevel level { get; set; }
        public double baseSalary { get; set; }
        public departament departament { get; set; }
        public List<hourContract> contracts { get; set; } = new List<hourContract>();

        public worker()
        {

        }

        public worker(string name, workerLevel level, double baseSalary, departament departament)
        {
            this.name = name;
            this.level = level;
            this.baseSalary = baseSalary;
            this.departament = departament;
        }

        public void addContract(hourContract contract)
        {
            contracts.Add(contract);
        }

        public void removeContract(hourContract contract)
        {
            contracts.Remove(contract);
        }
        
        public string income(int year, int month)
        {
            double sum = baseSalary;

            foreach (hourContract contract in contracts)
            {
                if (contract.date.Year == year && contract.date.Month == month)
                {
                    sum += contract.totalValue();
                }
            }

            return $"{sum:F2}";
        }

    }
}
