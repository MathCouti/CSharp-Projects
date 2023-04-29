using SalarioEmpregado.Entities.Enums;

namespace SalarioEmpregado.Entities
{
    class Worker
    {
        public string _name { get; set; }
        public double _salary { get; set; }
        public WorkLevel _level { get; set; }
        public Department _depart { get; set; }
        List<HourContract> Contracts = new List<HourContract>();

        public Worker()
        {
        }
        public Worker(string name, double salary, WorkLevel level, Department depart)
        {
            _name = name;
            _salary = salary;
            _level = level;
            _depart = depart;
        }
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
            double sum = _salary;
            foreach (HourContract contract in Contracts)
            {
                if (contract._date.Year == year && contract._date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }

    }
}
