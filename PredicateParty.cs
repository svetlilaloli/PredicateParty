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
                        guests = RemoveGuests(guests, x => !x.StartsWith(command[2])).ToList();
                    }
                    else if (command[1] == "EndsWith")
                    {
                        guests = RemoveGuests(guests, x => !x.EndsWith(command[2])).ToList();
                    }
                    else
                    {
                        guests = RemoveGuests(guests, x => x.Length != int.Parse(command[2])).ToList();
                    }
                }
                else
                {
                    if (command[1] == "StartsWith")
                    {
                        guests = DoubleGuests(guests, name => name.StartsWith(command[2])).ToList();
                    }
                    else if (command[1] == "EndsWith")
                    {
                        guests = DoubleGuests(guests, name => name.EndsWith(command[2])).ToList();
                    }
                    else
                    {
                        guests = DoubleGuests(guests, name => name.Length == int.Parse(command[2])).ToList();
                    }
                }
                command = Console.ReadLine().Split();
            }
            PrintGuests(guests);
        }
        static IEnumerable<string> RemoveGuests(IEnumerable<string> collection, Predicate<string> isFiltered)
        {
            return collection.Where(x => isFiltered(x));
        }
        static IEnumerable<string> DoubleGuests(IEnumerable<string> collection, Predicate<string> isDoubled)
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
            StringBuilder output = new StringBuilder(string.Join(", ", guests));

            if (guests.Count() > 1)
            {
                output.Append(" are going to the party!");
            }
            else if (guests.Count() == 1)
            {
                output.Append(" is going to the party!");
            }
            else
            {
                output.Append("Nobody is going to the party!");
            }
            Console.WriteLine(output);
        }
    }
}
