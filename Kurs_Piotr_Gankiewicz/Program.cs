using Kurs.Models;
using Kurs_Piotr_Gankiewicz.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kurs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var user = new User("user@email.com", "secret");
            
            var anotherUser = new 
            {
                Id = 1,
                Name = "user",
                Address = new 
                {
                    Street = "Krakowska 1",
                    City = "Kraków"
                }
            };

            //______4_________

            var delegates = new Delegates();
            delegates.Test();

            // Delegates delegates1= new Delegates();
            // delegates1.CheckTemperature(null,null,null);

            Console.ReadKey();

            LambdaExpressions le = new LambdaExpressions();
            le.LambdaTest();

            Console.ReadKey();
        }
    }
}
