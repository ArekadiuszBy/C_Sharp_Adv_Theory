using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_training
{
    public interface IEmployee
    {
        string Name { get; set; }
        double Salary {  get; set; }

        bool IsActive {  get; set; }

        void Pension(int rank);

    }
}
