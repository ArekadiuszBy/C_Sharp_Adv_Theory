using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Piotr_Gankiewicz.Models
{
    class LambdaExpressions
    {
        public delegate void Write(string message);
        public delegate int Add(int x);

        public void LambdaTest()
        {
            Action writer = () => Console.WriteLine("Action writer LAMBDA \n");
            writer();

            Action<string> stringWriter = (s) => Console.WriteLine($"You've typped {s}");
            stringWriter("Cześć Arek!");

        }
    }
}
