using System;

namespace _08.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            ushort age = 27;
            char gender = 'f';
            long IDNumber = 8306112507;
            int employeeNumber = 27563571;

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {IDNumber}");
            Console.WriteLine($"Unique Employee number: {employeeNumber}");
        }
    }
}
