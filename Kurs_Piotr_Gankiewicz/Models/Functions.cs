using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kurs_Piotr_Gankiewicz.Models
{
    public class Delegates
    {
        public delegate void Write(string message);
        public delegate int Add(int x, int y);
        public delegate void Alert(int change);


        public void Test()
        {
            Write writer = WriteMessage;
            writer("Arek");

            Add adder = AddTwoNumers;
           var sum = adder(5, 6);
            Console.WriteLine(sum + "\n");
            Console.WriteLine("***Press enter***");

            Console.ReadKey();
            CheckTemperature(TooLowAlert,OptimalAlert,TooHighAlert);    
        }

        public static void TooLowAlert(int change)
        {
            Console.WriteLine($"Temperature is too low (changed by {change} *C)");
        }
                public static void OptimalAlert(int change)
        {
            Console.WriteLine($"Temperature is OK  (changed by {change} *C)");
        }
                public static void TooHighAlert(int change)
        {
            Console.WriteLine($"Temperature is too high (changed by {change} *C)");
        }



        public void CheckTemperature(Alert tooLow, Alert optimal, Alert tooHigh)
        {
            var temperature = 20;
            var random = new Random();

            while (temperature<40 && temperature>-40)
            {
                var change = random.Next(-20, 20);
                temperature += change;
                Console.WriteLine($"Temperature is at: {temperature} *C");
                 
                if (temperature <= 0)
                    tooLow(change);
                else if (temperature > 0 && temperature <= 20)
                    optimal(change);
                else
                    tooHigh(change);

                Thread.Sleep(200);
            }


            Console.WriteLine(" \n *** PRESS ENTER **** \n");    
        }

        public static int AddTwoNumers(int x, int y)
        {
            return x + y;
        }
        public static void WriteMessage(string message)
        {
            Console.WriteLine($"Hello {message}!");
        }
    }
}
