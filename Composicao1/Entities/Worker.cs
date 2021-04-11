using System.Collections.Generic;
using Composicao1.Entities.Enums;

namespace Composicao1.Entities
{
    class Worker
    {
        //Atributos
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        /*
         * Declarando uma propriedade do tipo "Department", que é 
         * uma composição de objetos. Ou seja, há uma associação
         * entre o "Worker" e o "Department".
        */
        public Department Department { get; set; }
        /*
         * Como a propriedade "Contracts", que também é uma
         * composição de objetos, terá mais de um item
         * deve ser criada como do tipo "List".
        */
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //A lista já é instanciada, para garantir que a mesma não seja nula!

        //Construtores
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Métodos
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
