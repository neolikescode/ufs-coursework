using System;

namespace EmployeeManagementSystem
{
    public abstract class Employee
    {
        private static readonly Random rand = new Random();

        public int EmployeeID { get; private set; }
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public string Email { get; protected set; }
        public string PhoneNumber { get; protected set; }

        protected Employee(string name, string surname, string email, string phoneNumber)
        {
            EmployeeID = GenerateEmployeeID();
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        private int GenerateEmployeeID()
        {
            return rand.Next(000000, 999999);
        }

        public abstract decimal CalculateSalary();

        public virtual string DisplayInformation()
        {
            string show = $"Name: {Name}\nSurname: {Surname}\nEmail address: {Email}\nPhone Number: {PhoneNumber}";
            return show;
        }
    }
}
