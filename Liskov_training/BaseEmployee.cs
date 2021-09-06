using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_training
{
    public class BaseEmployee : IEmployee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool IsActive { get; set; }

        public virtual void Pension(int rank)
        {
            Salary = 15.90 + (rank * 2);
        }
    }
}
