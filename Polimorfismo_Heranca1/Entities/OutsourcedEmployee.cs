namespace Polimorfismo_Heranca.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            /* O método "Payment" utilizado nessa subclasse
             * é o próprio método da classe principal +
             * 110% do valor de "AdditionalCharge".
            */
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}