using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_QueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created an empoty Queue that holds strings
            Queue<string> myFavGames = new Queue<string>();

            //Add items to the end of the queue
            myFavGames.Enqueue("PES_2020");
            myFavGames.Enqueue("The Walking Dead");
            myFavGames.Enqueue("Call of Duty");
            myFavGames.Enqueue("The Last of Us");
            //Use the count property to see how many items there are
            int items = myFavGames.Count();
            Console.WriteLine("Number of items in Queue is :{0}", items);

            //Queues can be iterated without changing the structure
            foreach (var item in myFavGames)
            {
                Console.WriteLine(item);
            }
            //Peek at the front of the Queue. Peek will return the item/object at the beginning of the Queue without removing it
            string firstItem = myFavGames.Peek();
            Console.WriteLine("The first item in the Queue is : {0}", firstItem);
                     
            //Remove items from the front of the Queue
            firstItem = myFavGames.Dequeue();
            Console.WriteLine("Removing an item from the front : {0}", firstItem);
            foreach (var item in myFavGames)
            {
                Console.WriteLine(item);
            }
            //Search an item using Contain () will return true on the console
            Console.WriteLine(myFavGames.Contains("Call of Duty"));
            //we can continue removing first item from the queue using dequeue, because Queue is based on first in first out method

            //lastly we can use Clear to remove all item from the Queue
            myFavGames.Clear();
            Console.WriteLine("After clearing all the queue the count is: " + myFavGames.Count());

            Console.ReadKey();
        }
    }
}
