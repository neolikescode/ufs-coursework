using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class PartTimeEmployee : Employee
    {
        public double HoursWorked { get; private set; }
        public decimal HourlyRate { get; private set; }
        public PartTimeEmployee(string name, string surname, string email, string phoneNumber, double hoursWorked, decimal hourlyRate) : base(name, surname, email, phoneNumber)
        {
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }

        public override decimal CalculateSalary()
        {
            decimal salary = (decimal)HoursWorked * HourlyRate;

            return salary;
        }
        public override string DisplayInformation()
        {
            string show =$"{base.DisplayInformation()}\nWages: {CalculateSalary():C2}\n\tHourly rate: {HourlyRate:C2}\n\tHours Worked: {HoursWorked:C2}";
            return show;
        }
    }
}
