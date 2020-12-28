using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumComp.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        private double ValuePerHour { get; }
        private double Hours { get; }

        public HourContract() { }

        public HourContract(DateTime date, double valuePerHour, double hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double totalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
