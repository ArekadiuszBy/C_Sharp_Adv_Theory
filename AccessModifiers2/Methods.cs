using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers2
{
    class Methods
    {
        public string creditCard;
        public string _number;

        public string Number
        {
            get { return "1344-xxxx-xxxx-xxxx"; }
            set { _number = value; }
        }


        public int _age;
        public int Age
        {
            get { return _age; }
            set {
                if (value >= 0 && value < 99)
                    _age = value;
            }
        }


        public static void Main(String[] args)
        {
            Program progr = new Program();

            progr.ProtInt();
            progr.
        }
    }
}
