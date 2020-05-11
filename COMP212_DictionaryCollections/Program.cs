using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main advantage of dictionary is that it's fast and unique key to value mapping
            //Dictionaries map keys to values. Keys must unique
            Dictionary<int ,string>myMovies= new Dictionary<int, string>();
            //add some keys and values to the dictoinary
            myMovies.Add(001, "A quiet Place");
            myMovies.Add(002, "Extraction");
            myMovies.Add(003, "My Dairy");
            myMovies.Add(004, "Call of Duty");

            //use the count property to see how many items there are.
            Console.WriteLine(myMovies.Count());

            //Trying to add an existing key will throw an exception
            //myMovies.Add(002, "A quiet place II");

            //Dictionaries are also like associative arrays
            Console.WriteLine("Key value {0}", myMovies[003]);

            //We can overwrite an existing value using key
            myMovies[003] = "Numb";
            Console.WriteLine(myMovies[003]);
            foreach (var item in myMovies)
            {
                Console.WriteLine(item);
            }

            //Checking if a dictionary contains a key or  value and it will return TRUE

            Console.WriteLine("Contains key:{0}",myMovies.ContainsKey(004));
            Console.WriteLine("Contains value {0}", myMovies.ContainsValue("Call of Duty"));

            //Removing element from dictionary
            myMovies.Remove(002);
            Console.WriteLine("After removing an item, there are {0} item in dictionary", myMovies.Count());
            Console.ReadLine();
        }
    }
}
