using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_training
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;

        public virtual void Assign(IEmployee manager)
        {
            Manager = manager; 
        }       
    }

}
