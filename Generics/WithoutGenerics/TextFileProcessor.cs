using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.WithoutGenerics
{
    public static class TextFileProcessor
    {
        public static List<Person> LoadPeople(string filePath)
        {
            List<Person> output = new List<Person>();       //creates output
            Person p;                                       //creates new person
            var lines = System.IO.File.ReadAllLines(filePath).ToList();     //read all lines to list

            //Header remove - because it's not a data
            lines.RemoveAt(0);

            foreach(var line in lines)
            {
                var vals = line.Split(',');
                p = new Person();               //new instance of a person

                p.FirstName = vals[0];
            //DONE: //Add error checking
                try { p.IsAlive = bool.Parse(vals[1]); }   //Parse, because its bool, not a string 
                catch (Exception ex) { Console.WriteLine("Error in bool"); }
                p.LastName = vals[2];

                output.Add(p);
            }
            return output;
        }

        public static List<LogEntry> LoadLogs(string filePath)
        {
            List<LogEntry> output = new List<LogEntry>();       //creates output
            LogEntry log;                                       //creates new person
            var lines = System.IO.File.ReadAllLines(filePath).ToList();     //read all lines to list

            //Header remove - because it's not a data
            lines.RemoveAt(0);

            foreach (var line in lines)
            {
                var vals = line.Split(',');
                log = new LogEntry();               //new instance of a person

                log.ErrorCode = int.Parse(vals[0]);
                //DONE: //Add error checking
                log.Message = vals[1];
                log.TimeOfEvent = DateTime.Parse(vals[2]);

                output.Add(log);
            }
            return output;
        }

        public static void SavePeople(List<Person> people, string filePath)
        {
            List<string> lines = new List<string>();

            //Header add
            lines.Add("FirstName,IsAlive,LastName");

            foreach (var p in people)
            {
                lines.Add($"{p.FirstName},{p.IsAlive},{p.LastName}");
            }

            System.IO.File.WriteAllLines(filePath, lines);
        }

        public static void SaveLogs(List<LogEntry> logs, string filePath)
        {
            List<string> lines = new List<string>();

            //Header add
            lines.Add("ErrorCode,Message,TimeOfEvent");

            foreach (var log in logs)
            {
                lines.Add($"{log.ErrorCode},{log.Message},{log.TimeOfEvent}");
            }

            System.IO.File.WriteAllLines(filePath, lines);
        }
    }
}
