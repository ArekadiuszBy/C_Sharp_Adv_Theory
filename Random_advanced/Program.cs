using System;
using System.Collections.Generic;
using System.Linq;

namespace Random_advanced
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Podaj liczbe");
            String s = Console.ReadLine();
            int x = int.Parse(s);   

            Random ran = new Random();
            int y = ran.Next(1, 2);

            // Random(liczba) -> seed number - zawsze od tego numeru 
            //będzie zaczynało się wyliczanie Random - np. w pętli za każym razem będziemy mieli te same wyniki =  don't use this
            Random ran2 = new Random(3);
            Random ran3 = new Random(x);

            Easy(ran);

            Console.WriteLine("\n NextDouble:" + ran.NextDouble() + "\n \n");    //pokazuje double od 0-1 


            //working on List - adding, sorting, etc
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{ Name = "Arek"},
                new PersonModel{ Name = "Darek"}, 
                new PersonModel{ Name = "Jaaaarek"},
                new PersonModel{ Name = "Annna"}
            };


            //sorting Names randomly
            var sortedPeopleRandom = people.OrderBy(x => ran.Next());
            //sorting Names alphabetically
            var sortedPeople = people.OrderBy(x => x.Name);


            Console.WriteLine("\n Not sorted");
            foreach(var p in people)
            {
                Console.WriteLine(p.Name);
            }            
            
            Console.WriteLine("\n Sorted");
            foreach(var p in sortedPeople)
            {
                Console.WriteLine(p.Name);
            }            
            
            Console.WriteLine("\n Randomly sorted");
            foreach(var p in sortedPeopleRandom)
            {
                Console.WriteLine(p.Name);
            }
        }
        private static void Easy(Random random)
        {
            Console.WriteLine(random.Next());
        }

        public class PersonModel
        {
            public string Name { get; set; }    
        }
    }
}
