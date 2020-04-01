﻿using System;
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

            Console.ReadLine();
            // TODO: First and Last properties return LinkedListNodes


            // TODO: Items can be added or removed relative to an existing item


            // TODO: Search for items in the list with Contains and Find


            // TODO: The list can then be traversed with those properties
        }
    }
}