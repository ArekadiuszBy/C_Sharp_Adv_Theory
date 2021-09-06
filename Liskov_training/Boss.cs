using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_training
{
    class Boss : BaseEmployee, IManager
    {
        public override void Pension(int rank)
        {
            Salary = 200 * rank;
        }

        public void Review()
        {
            Console.WriteLine("REVIEWWW");
        }

        public void Fire()
        {
            Console.WriteLine("FIRED");
        }
    }
}
