using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_training
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>() { 1, 4, 5634, 634, 63, 734, 43, 3, 5, 2 };

            foreach (var x in numbers)
            {
                Console.WriteLine("{0} ", x);
            }
            Console.WriteLine();

            var square = numbers.Select(x => Math.Pow(x, 2));

            Console.WriteLine("Squares : ");

            foreach (var val in square)
            {
                Console.WriteLine("{0}", val);
            }
            Console.WriteLine();

            List<int> divBy5 = numbers.FindAll(x => (x % 5 == 0));

            Console.WriteLine("Numbers Divisable by 5:");
            foreach (var val in divBy5)
            {
                Console.WriteLine("{0}", val);
            }
            Console.WriteLine();



            //Second example - sorting List alphabetically

            List<Program> details = new List<Program>()
            {
                new Program{ RollNo =1, Name="Arek"},
                new Program{ RollNo =2, Name="TRads"},
                new Program{ RollNo =3, Name="Wasdas"},
                new Program{ RollNo =4, Name="Araeettek"},
                new Program{ RollNo =5, Name="A"},
            };

            var newDetails = details.OrderBy(x => x.Name);

            foreach (var val in newDetails)
            {
                Console.WriteLine(val.RollNo + " " + val.Name);
            }
        }



        public int RollNo { get; set; }
        public string Name { get; set; }
    }
}
