using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_PGankiewicz_cz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string arg = "ARek";
            if (!arg.Empty())
            {
                Console.WriteLine("Extension - STATIC class & STATIC method with 'THIS' = function like definied built-in");
            }

            var enumerations = new Enumerations();

            enumerations.Test();

            Console.ReadKey();
        }
    }
}
