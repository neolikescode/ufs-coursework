using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class Contractor : Employee
    {
        public decimal ContractRate { get; private set; }
        public int HirePeriod { get; private set; }
        public Contractor(string name, string surname, string email, string phoneNumber, int hirePeriod, decimal contractRte) :base(name, surname, email, phoneNumber)
        {
            ContractRate = contractRte;
            HirePeriod = hirePeriod;
        }

        public override decimal CalculateSalary()
        {
            return ContractRate * HirePeriod;
        }

        public override string DisplayInformation()
        {
            string show = $"{base.DisplayInformation()}\nMonthly Salary: {CalculateSalary():C2}\n\tContractor Rate: {ContractRate}\n\tContract duration: {HirePeriod}";
            return show;
        }
    }
}
