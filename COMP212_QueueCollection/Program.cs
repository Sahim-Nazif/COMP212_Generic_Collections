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


            Console.ReadLine();
        }
    }
}
