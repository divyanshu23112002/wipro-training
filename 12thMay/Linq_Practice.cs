using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Linq_practice
{
    class Program
    {
        static void Main()
        {
            string[] name = { "Anil", "Sharma", "Abdullah", "Imran", "Siva", "Naresh", "Suresh", "Suman" };
            UsingAnonymousMethods(name);
        }
        //private static void UsingLinq(string[] name)
        //{
        //   IEnumerable<String> query = from s in name where s.Length == 5 orderby s select s.ToUpper();

        //    //select * from
        //    foreach (string s in query)

        //        Console.WriteLine(s);
        //    Console.Read();

        //}
        //private static void UsingLINQExtensions(string[] name)
        //{
        //    IEnumerable<String> query = name
        //        .Where(s => s.Length == 5)
        //        .OrderBy(s => s)
        //        .Select(s => s.ToUpper());

        //    foreach (string s in query)
        //        Console.WriteLine(s);
        //    Console.Read ();
        //}

        //private static void UsingLINQFunctions(string[] name)
        //{
        //    Func<string, bool> filter = s => s.Length == 5;
        //    Func<string, string> extract = s => s;
        //    Func<string, string> project = s => s.ToUpper();

        //    IEnumerable<string> query = name.Where(filter)
        //        .OrderBy(extract)
        //        .Select(project);

        //    foreach (string item in query)
        //        Console.WriteLine(item);
        //    Console.Read();
        //}
        private static void UsingAnonymousMethods(string[] name)
        {
            Func<string, bool> filter = delegate (string s)
            {
                return s.Length == 5;
            };

            Func<string, string> extract = delegate (string s)
            {
                return s;
            };
            Func<string, string> project = delegate (string s)
            {
                return s.ToUpper();

            };
            IEnumerable<string>query=name.Where(filter)
                .OrderBy(extract)
                .Select(project);

            foreach (string s in query) 
                Console.WriteLine(s);

        }
    }
}