
namespace SalarioEmpregado.Entities
{
    class HourContract
    {
        public DateTime _date;
        public double ValuePerHour;
        public int Hour;

        public HourContract()
        {

        }
        public HourContract(DateTime date, double valuehour, int hour)
        {
            _date = date;
            ValuePerHour = valuehour;
            Hour = hour;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hour;
        }

    }
}
