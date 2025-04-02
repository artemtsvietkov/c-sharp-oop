using System;

namespace EmployeeApp
{
    abstract class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public abstract double GetMonthlySalary();
    }

    class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }
        public FullTimeEmployee(string name, int id, double salary)
        {
            Name = name;
            ID = id;
            MonthlySalary = salary;
        }
        public override double GetMonthlySalary() => MonthlySalary;
    }

    class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public PartTimeEmployee(string name, int id, double rate, int hours)
        {
            Name = name;
            ID = id;
            HourlyRate = rate;
            HoursWorked = hours;
        }
        public override double GetMonthlySalary() => HourlyRate * HoursWorked;
    }

    class Program3
    {
        static void Main()
        {
            var fullTime = new FullTimeEmployee("Alice", 101, 30000);
            Console.WriteLine($"Name: {fullTime.Name}, Salary: {fullTime.GetMonthlySalary()}");

            var partTime = new PartTimeEmployee("Bob", 102, 150, 80);
            Console.WriteLine($"Name: {partTime.Name}, Salary: {partTime.GetMonthlySalary()}");
        }
    }
}