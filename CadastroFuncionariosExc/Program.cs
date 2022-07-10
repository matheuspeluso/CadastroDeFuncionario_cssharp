using System;
using System.Collections.Generic;
using System.Globalization;
using CadastroFuncionariosExc.Entities;

namespace CadastroFuncionariosExc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsouced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hours: ");
                double valuePerHours = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (outsouced == 'y')
                {
                    Console.Write("Additional charge:");
                    double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    employees.Add(new OutsorceEmployee(name, hours, valuePerHours, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHours));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name + " $ " + employee.Payment().ToString("f2",CultureInfo.InvariantCulture));
            }

        }
    }
}