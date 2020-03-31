using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_List_GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] movies = { "A Quite Place 2", "The Gurdge", "The Turning","Under Water", "Escape Room 2" ,"Run",
                                "The Night House", "Wolf Creek 3" ,"Candyman"};

            // TODO: Create the list
            List<string> movieList = new List<string>(12);

            // TODO: Add some elements to the list from an existing array
            movieList.AddRange(movies);

            // TODO: Add individual items
            movieList.Add("Spiral");
            movieList.Add("The Hunt");

            // TODO: Examine the Count and Capacity
            Console.WriteLine("Count is:" + movieList.Count + "\nCapacity is :" + movieList.Capacity);


            // TODO: Enumerate the items in the list with a foreach loop

            foreach (var item in movieList)
            {
                Console.WriteLine(item);
            }
            //PrintList(movieList);

            // TODO: Access any item by its index

            Console.WriteLine("Movie at Index 5:" + movieList[5]);

            // TODO: Remove items from the list- it can be done using different methods as Remove (), RemoveAt(index), RemoveRange()
            movieList.Remove("Run");
            movieList.RemoveAt(2);
            
            foreach (var item in movieList)
            {
                Console.WriteLine(item);
            }
            // TODO: Sort the list content
            Console.ReadLine();

            // ** Searching List Content **/

            // TODO: Determine if a list contains a given item


            // TODO: The Exists function gives us a more customizable way to search
            // by using a predicate function to examine each element in the list


            // TODO: Use the Find function to search through items


            // TODO: The FindAll function can find multiple items


            // TODO: Use TrueForAll to see if a given condition is true for all elements
        }

       }
}
