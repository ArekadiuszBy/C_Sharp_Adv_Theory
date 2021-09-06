using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_training
{
    class Manager : Employee, IManager
    {
        public override void Pension(int rank)
        {
            Salary = 20.50 + (rank * 4);
        }

        public void Review()
        {
            Console.WriteLine("You doing great");
        }
    }
}
