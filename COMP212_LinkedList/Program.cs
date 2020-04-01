using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] top_programming_languages2020 = { "JavaScript", "Java", "C#","C" , "C++" ,"PHP", "Swift", "Go"};

            // TODO: Create a LinkedList that holds strings
            LinkedList<string> topLanguages = new LinkedList<string>(top_programming_languages2020);

            // TODO: Items can be added at the front or back of the list
            topLanguages.AddFirst("Python");
            topLanguages.AddLast("Rubby");

            // TODO: Like other collections, a LinkedList can be iterated using forEach
            foreach (var item in topLanguages)
            {
                Console.WriteLine(item);
            }
            // TODO: First and Last properties return LinkedListNodes
            LinkedListNode<string> first = topLanguages.First;
            LinkedListNode<string> last = topLanguages.Last;

            Console.WriteLine("\nRetrieving the first item in the linked List: " + first.Value);
            Console.WriteLine("Retrieving the last item in the linked List: " +  last.Value);
            //TODO: Retrieving the Next Item after the first item and previous item before the last
            Console.WriteLine("\nThe item after the first is :" + first.Next.Value);
            Console.WriteLine("The item previous or before the last is :" + last.Previous.Value);
            // TODO: Items can be added or removed relative to an existing item
            topLanguages.AddAfter(first, "SQL");
            topLanguages.AddBefore(last, "Kotlin");
            foreach (var item in topLanguages)
            {
                Console.WriteLine(item);
            }

            // TODO: Search for items in the list with Contains and Find


            // TODO: The list can then be traversed with those properties

            Console.ReadLine();
        }
    }
}
