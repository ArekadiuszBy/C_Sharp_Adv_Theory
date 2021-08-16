using Generics.WIthGenerics;
using Generics.WithoutGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();

            // GenericsTextFileStorage();

            List<int> list = new List<int>();

            TextFileStorage();

            Console.WriteLine("Press any button to exit");
            Console.ReadKey();
        }

        private static void TextFileStorage()
        {

            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();

            string peopleFile = @"C:\Users\NoOne\Desktop\C#\people.csv";
            string logFile = @"C:\Users\NoOne\Desktop\C#\logs.csv";

            PopulateLists(people, logs);


            //GENERICS
            GenericsTextFileStorage.SaveToTextFile<Person>(people, peopleFile);
            GenericsTextFileStorage.SaveToTextFile<LogEntry>(logs, logFile);

            var newPeople = GenericsTextFileStorage.LoadFromTextFile<Person>(peopleFile);

            foreach (var p in newPeople)
            {
                Console.WriteLine($"{ p.FirstName } { p.LastName } (IsAlive = { p.IsAlive })");
            }

            var newLogs = GenericsTextFileStorage.LoadFromTextFile<LogEntry>(logFile);

            foreach (var log in newLogs)
            {
                Console.WriteLine($"{ log.ErrorCode }: { log.Message } at { log.TimeOfEvent.ToShortTimeString() }");
            }

            // NON GENERICS
/*            TextFileProcessor.SaveLogs(logs,logFile);

            var newLogs = TextFileProcessor.LoadLogs(logFile);

            foreach (var log in newLogs)
            {
                Console.WriteLine($"{log.ErrorCode}: { log.Message} at { log.TimeOfEvent.ToShortTimeString() }");
            }

            //Can comment this line so program will Load from file
            TextFileProcessor.SavePeople(people, peopleFile);

            var newPeople = TextFileProcessor.LoadPeople(peopleFile);

            foreach (var p in newPeople)
            {
                Console.WriteLine($"{p.FirstName} {p.IsAlive} (IsAlive = {p.LastName})");
            }*/
        }

        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Timkiewicz" });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm", IsAlive = false });
            people.Add(new Person { FirstName = "Greg", LastName = "Olsen" });

            logs.Add(new LogEntry { Message = "Message1", ErrorCode = 9999 });
            logs.Add(new LogEntry { Message = "Message2", ErrorCode = 1337 });
            logs.Add(new LogEntry { Message = "Message3", ErrorCode = 2222 });
        }
    }  
}
