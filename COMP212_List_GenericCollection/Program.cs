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
           

            // TODO: Access any item by its index

            Console.WriteLine("Movie at Index 5:" + movieList[5]);

            // TODO: Remove items from the list- it can be done using different methods as Remove (), RemoveAt(index), RemoveRange()
            movieList.Remove("Run");
            movieList.RemoveAt(2);
            
            //foreach (var item in movieList)
            //{
            //    Console.WriteLine(item);
            //}
            // TODO: Sort the list content
            movieList.Sort();

            //foreach (var item in movieList)
            //{
            //    Console.WriteLine(item);
            //}
            printMovies(movieList);
         

            // ** Searching List Content **/

            // TODO: Determine if a list contains a given item
            Console.WriteLine(movieList.Contains("Under Water"));


            // TODO: Use the Find function to search through items
            string findMovieStartWith = "";
            findMovieStartWith= movieList.Find(m => m.StartsWith("C"));
            Console.WriteLine("Movie that start with C is:" + findMovieStartWith);
            // TODO: The FindAll function can find multiple items


            Console.ReadLine();
            // TODO: Use TrueForAll to see if a given condition is true for all elements
        }

        static void printMovies(List<string >list)
        {
            foreach (var item in list )
            {
                Console.WriteLine(item);
            }
        }
       }
}
