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
                        guests = Filtered(guests, x => !x.StartsWith(command[2])).ToList();
                    }
                    else if (command[1] == "EndsWith")
                    {
                        guests = Filtered(guests, x => !x.EndsWith(command[2])).ToList();
                    }
                    else
                    {
                        guests = Filtered(guests, x => x.Length != int.Parse(command[2])).ToList();
                    }
                }
                else
                {
                    if (command[1] == "StartsWith")
                    {
                        guests = Doubled(guests, name => name.StartsWith(command[2])).ToList();
                    }
                    else if (command[1] == "EndsWith")
                    {
                        guests = Doubled(guests, name => name.EndsWith(command[2])).ToList();
                    }
                    else
                    {
                        guests = Doubled(guests, name => name.Length == int.Parse(command[2])).ToList();
                    }
                }
                command = Console.ReadLine().Split();
            }
            PrintGuests(guests);
        }
        static IEnumerable<string> Filtered(IEnumerable<string> collection, Predicate<string> isFiltered)
        {
            return collection.Where(x => isFiltered(x));
        }
        static IEnumerable<string> Doubled(IEnumerable<string> collection, Predicate<string> isDoubled)
        {
            List<string> result = new List<string>();
            
            foreach (string name in collection)
            {
                result.Add(name);
                if (isDoubled(name))
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
