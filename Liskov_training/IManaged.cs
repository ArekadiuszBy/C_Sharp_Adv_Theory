using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_training
{
    interface IManaged : IEmployee
    {
        IEmployee Manager { get; set; }

        void Assign(IEmployee manager);
    }
}
