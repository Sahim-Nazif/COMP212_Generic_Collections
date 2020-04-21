using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_StackCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create an empty stack
            Stack<string> movieStack = new Stack<string>();

            // TODO: The Push function pushes new elements onto the stack
            movieStack.Push("A Quiet Place");
            movieStack.Push("Bird Box");
            movieStack.Push("Candyman");

            // TODO: The Count property indicates how many elements are on the stack
            Console.WriteLine("Total Items: {0}", movieStack.Count());

            // TODO: Stacks can be enumerated in place without changing the content

            foreach (var item in movieStack)
            {
                Console.WriteLine(item);
            }
            // TODO: The Peek function examines the current top element but does not remove it

            Console.WriteLine("The first item in the stack order is: {0}", movieStack.Peek());

            // TODO: The Pop function removes an element from the top
            movieStack.Pop();
            Console.WriteLine("Total items after poping an item from the top in stack order are: {0}", movieStack.Count());

            // TODO: Search for an element using Contains --It contains the item will return true--
            Console.WriteLine("Movie Stack Contains: {0}", movieStack.Contains("Bird Box"));

            Console.ReadLine();
        }
    }
}
