using ExercicioEnumComp.Entities;
using ExercicioEnumComp.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioEnumComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name:");
            Department department = new Department(Console.ReadLine());

            Console.WriteLine("Enter worker data:");
            
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level: ");
            string mockLevel = Console.ReadLine();

            WorkerLevel level = Enum.Parse<WorkerLevel>(mockLevel); // Here we convert string to Enum WorkerLevel.

            Console.Write("Base salary: ");
            double baseSalary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker(name, level, baseSalary, department);

            Console.Write("How many contracts to this worker?");
            int QuantityContracts = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < QuantityContracts; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Value per hour: ");
                double perHour = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                double duration = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                HourContract contract;
                worker.AddContract( contract = new HourContract(date, perHour, duration));
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime monthYear = Convert.ToDateTime(Console.ReadLine());

            double income = worker.Income(monthYear.Year, monthYear.Month);

            Console.Write(
                "\nName:"
                + worker.Name
                + "\nDepartment:"
                + worker.Department.Name
                + "\nIncome:"
                + income);
        }
    }
}
