using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_training
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            manager.Name = "Mana";
            manager.Pension(5);

            Employee employee= new Employee();

            employee.Name = "IT's Me";
            employee.Assign(manager);
            employee.Pension(1);

            Console.WriteLine($"{employee.Name}'s salary = ${employee.Salary}");

            Boss boss = new Boss();

            boss.Fire();
            boss.Pension(5);
            Console.WriteLine($"Boss salary is {boss.Salary}$$$");

            Console.ReadKey();


            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
;
        }
       
        public abstract class Fruit
        {
            public abstract string GetColor();
        }
        public class Apple : Fruit
        {
            public override string GetColor()
            {
                return "Red";
            }
        }
        public class Orange : Fruit
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }
    }
}
