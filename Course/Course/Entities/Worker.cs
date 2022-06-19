using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Entities.Enums;

namespace Course.Entities
{
    internal class Worker
    {
        public string Name { get; set; }

        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baeeSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baeeSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContranct(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int month, int year)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum = sum + contract.TotalValue();
                }
            }
            return sum;
        }
    }

    
}
