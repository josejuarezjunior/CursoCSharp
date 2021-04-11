namespace Polimorfismo_Heranca.Entities
{
    class Employee
    {
        //Attributes
        public string Name { get; set; }
        public int Hours { get; set; }

        public double ValuPerHour { get; set; }

        //Constructors
        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuPerHour = valuePerHour;
        }

        //Method
        //"virtual" indica que esse método pode ser sobrescrito na subclasse!
        public virtual double Payment()
        {
            return Hours * ValuPerHour;
        }

    }
}