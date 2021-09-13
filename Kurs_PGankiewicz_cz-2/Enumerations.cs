using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_PGankiewicz_cz_2
{
    public class Enumerations
    {
        public void Test()
        {
            var numbers = Enumerable.Range(1, 10).ToList();
            IEnumerable<int> listEnumerable = numbers;      //IEnumerable<int> listEnumerable = Enumerable.Range(1, 10);
            IEnumerable<int> listGetNumbers = GetNumbers();


            Console.WriteLine("\n___ listEnumerable");
            foreach(var n in listEnumerable)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\n___ listGetNumbers");
            foreach (var n in listGetNumbers)
            {
                Console.WriteLine(n);
            }

            var enumerator = numbers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }


            //IQuery
            //PRZYPISYWAĆ DO PAMIĘCI KOMPUTERA, gdy będziemy wykorzystywali jakieś dane z bazy wiele razy
            //Bo operacja QUERY zużywa dużo zasobów i czasu (by za każdym razem pobierać na nowo to samo z DB)

            /*            var users = GetUsers().ToList();
                        Console.WriteLine("\n___ listGetNumbers");
                        foreach (var user in users)
                        {
                            Console.WriteLine(user);
                        }
            */

            var items = GetItems();
            var tools = items.Where(x => x.Name == "Arek");
            var arek = tools.First(x => x.Name == "Arek");      //tools.FirstOrDefault zwraca NULL jeśli nie znajdzie elementu 
                                                                //.Single -> wymaga, by element był unikalny, inaczej da InvalidOperationException 
            var sum = numbers.Sum();
            var max = numbers.Max();
            var food = items.Where(x => x.Name == "Marek");
            var foodAndTools = tools.Union(food);               //Suma dwóch zbiorów 



            var query = items.Where(x => x.Date >= DateTime.Now.AddDays(-10))
                             .Where(x => x.Name.Length < 4)
                             .Skip(1)                           //Pomiń pierwszy element w kolekcji
                             .Take(2)                           //Wyświetl tylko dwa pierwsze wyniki (poza tym pominiętym)
                             .OrderBy(x => x.Date)
                             .Select(x => new { x.Name, x.Date }); //Utworzenie anonimowego typu, gdzie dostaniemy tylko Name i Date

            var dictionary = items.ToDictionary(key => key.Id, value => value.Name);        //Get dictionary from query

            foreach(var d in dictionary)
                Console.WriteLine("\n VALUE: " + d.Value +" \t KEY: " + d.Key);


        }


        public IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
        }

        public IQueryable<User> GetUsers()
        {
            return GetUsers();              //should be return user, but doesn't work..
        }

        //LINQ - Language INtegrated Query
        public IEnumerable<Item> GetItems()
        {
            yield return new Item("Arek", "Str", DateTime.Now.AddDays(-15));
            yield return new Item("Aresk", "STRR", DateTime.Now.AddDays(-5));
            yield return new Item("k", "str", DateTime.Now.AddDays(-1));
            yield return new Item("Marek", "str", DateTime.Now.AddDays(+20));
            yield return new Item("Marek", "STRR", DateTime.Now.AddDays(-215));
            yield return new Item("Arek", "str", DateTime.Now.AddDays(+32));
            yield return new Item("WWW", "S", DateTime.Now.AddDays(-2));
        }
    }

    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }
    }



    public class Item
    {
        public Guid Id {  get; set; }  
        public string Name {  get; set; }
        public string Str {  get; set; } 
        public DateTime Date {  get; set; }

        public Item(string name, string str, DateTime date)
        {
            Id = Guid.NewGuid();
            Name = name;
            Str = str;
            Date = date;
        }
    }
}
