using System;

namespace CadastroFuncionariosExc.Entities
{
    internal class OutsorceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsorceEmployee()
        {

        }
        public OutsorceEmployee(string name, int hours, double valuePerHours,double additionalCharge) 
            : base(name,hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
