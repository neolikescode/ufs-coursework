using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class FullTimeEmployee : Employee
    {
        public decimal MonthlySalary { get; private set; }
        public FullTimeEmployee(string name, string surname, string email, string phoneNumber, decimal salary) : base(name, surname, email, phoneNumber)
        {
            MonthlySalary = salary;
        }


        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }
        public override string DisplayInformation()
        {
            string show = $"{base.DisplayInformation()}\nMonthly Salary: {CalculateSalary():C2}";
            return show;
        }
    }
}
