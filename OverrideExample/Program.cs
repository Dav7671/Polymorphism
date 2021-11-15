using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some new employees.
            var employee1 = new SalesEmployee("Ani", 1000, 500);
            var employee2 = new Employee("Aram", 1200);

            Console.WriteLine($"Employee1 {employee1.Name} earned: {employee1.CalculatePay()}");
            Console.WriteLine($"Employee2 {employee2.Name} earned: {employee2.CalculatePay()}");

            Console.ReadKey();
        }

        public class Employee
        {
            public string Name { get; }
            // Basepay is defined as protected, so that it may be
            // accessed only by this class and derived classes.
            protected decimal _basepay;

            public Employee(string name, decimal basepay)
            {
                Name = name;
                _basepay = basepay;
            }

            public virtual decimal CalculatePay()
            {
                return _basepay;
            }
        }

        public class SalesEmployee : Employee
        {
            // New field that will affect the base pay.
            private decimal _salesbonus;

            // The constructor calls the base-class version, and
            // initializes the salesbonus field.
            public SalesEmployee(string name, decimal basepay, decimal salesbonus)
                : base(name, basepay)
            {
                _salesbonus = salesbonus;
            }

            // Override the CalculatePay method
            // to take bonus into account.
            public override decimal CalculatePay()
            {
                return _basepay + _salesbonus;
            }
        }
    }
}
