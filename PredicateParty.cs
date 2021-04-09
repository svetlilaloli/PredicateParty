using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PredicateParty
{
    class PredicateParty
    {
        static void Main()
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            string[] command = Console.ReadLine().Split();
            
            while (command[0] != "Party!")
            {
                if (command[0] == "Remove")
                {
                    if (command[1] == "StartsWith")
                    {
                        guests = RemoveStartsWith(command[2], guests).ToList();
                    }
                    else if (command[1] == "EndsWith")
                    {
                        guests = RemoveEndsWith(command[2], guests).ToList();
                    }
                    else
                    {
                        guests = RemoveWithLength(command[2], guests).ToList();
                    }
                }
                else
                {
                    if (command[1] == "StartsWith")
                    {
                        guests = DoubleStartsWith(command[2], guests).ToList();
                    }
                    else if (command[1] == "EndsWith")
                    {
                        guests = DoubleEndsWith(command[2], guests).ToList();
                    }
                    else
                    {
                        guests = DoubleWithLength(command[2], guests).ToList();
                    }
                }
                command = Console.ReadLine().Split();
            }
            PrintGuests(guests);
        }
        static IEnumerable<string> RemoveStartsWith(string substr, IEnumerable<string> collection)
        {
            return collection.Where(x => !x.StartsWith(substr));
        }
        static IEnumerable<string> RemoveEndsWith(string substr, IEnumerable<string> collection)
        {
            return collection.Where(x => !x.EndsWith(substr));
        }
        static IEnumerable<string> RemoveWithLength(string substr, IEnumerable<string> collection)
        {
            return collection.Where(x => x.Length != int.Parse(substr));
        }
        static IEnumerable<string> DoubleStartsWith(string substr, IEnumerable<string> collection)
        {
            List<string> result = new List<string>();
            
            foreach (string name in collection)
            {
                result.Add(name);
                if (name.StartsWith(substr))
                {
                    result.Add(name);
                }
            }
            return result;
        }
        static IEnumerable<string> DoubleEndsWith(string substr, IEnumerable<string> collection)
        {
            List<string> result = new List<string>();

            foreach (string name in collection)
            {
                result.Add(name);
                if (name.EndsWith(substr))
                {
                    result.Add(name);
                }
            }
            return result;
        }
        static IEnumerable<string> DoubleWithLength(string substr, IEnumerable<string> collection)
        {
            List<string> result = new List<string>();

            foreach (string name in collection)
            {
                result.Add(name);
                if (name.Length == int.Parse(substr))
                {
                    result.Add(name);
                }
            }
            return result;
        }
        static void PrintGuests(IEnumerable<string> guests)
        {
            StringBuilder result = new StringBuilder(string.Join(", ", guests));

            if (guests.Count() > 1)
            {
                result.Append(" are going to the party!");
            }
            else if (guests.Count() == 1)
            {
                result.Append(" is going to the party!");
            }
            else
            {
                result.Append("Nobody is going to the party!");
            }
            Console.WriteLine(result);
        }
    }
}
