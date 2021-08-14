using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers2
{
    class Inheritance_protected : Program
    {
        public void Inh()
        {
            Prot();
            Inte();
            ProtInt();          //both inheritance in other namespace and the same namespace
            PrivProt();         //both the same class and the inheritance in other classes
        }
    }
}
