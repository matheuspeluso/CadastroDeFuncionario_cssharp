using System;

namespace CadastroFuncionariosExc.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHours { get; set; }

        public Employee()
        {

        }

        public Employee(string name, int hours, double valuePerHours)
        {
            Name = name;
            Hours = hours;
            ValuePerHours = valuePerHours;
        }

        virtual public double Payment()
        {
            return ValuePerHours * Hours;
        }


    }
}
