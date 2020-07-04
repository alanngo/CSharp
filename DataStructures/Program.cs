using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Log(object o) => Console.WriteLine(o);

        // add a print function because ToString isn't overriden in class
        static void Print<E>(ICollection<E> collection){foreach (E o in collection) Log(o);}

        static void Lists()
        {
            // you need to print the list, List does not have ToString
            var names = new List<string> //initialize a list by enumeration 
            {
                "nihitha",
                "waleed",
                "hannah",
                "sam"
            };

            Log("Element at 2: "+names[2]);  // index into the list
            Log("Index of nihitha: "+names.IndexOf("nihitha")); // retrieve index of element

            // print the list
            Print(names);

        }

        static void Sets()
        {
            // has no particular order
            var razer = new HashSet<string>
            {
                "blackwidow",
                "nari",
                "deathadder",
                "leviathan"
            };


            //maintains sorted order
            var razerSorted = new SortedSet<int> { 10, 9, 8, 7, 6, 5 };
            
            Log("hash set does not have a particular order");
            Print(razer);

            Log("sorted set maintains sorted order");
            Print(razerSorted);
        }
        
        static void Dictionaries()
        {
            var table = new Dictionary<string, int> 
            {
                ["alan"] = 2526,
                ["omar"] = 6627
            };

            // perform lookup
            Log("Perform lookup: " +table["omar"]);
        }

        static void Advanced()
        {

            Log("Stacks");
            var lifo = new Stack<char>{ };
            lifo.Push('x');
            lifo.Push('y');
            lifo.Push('z');
            lifo.Push('a');
            lifo.Push('b');
            lifo.Push('c');
            lifo.Pop();

            Log("Top of stack: "+lifo.Peek()); //should be b
            
            Log("Queues");
            var fifo = new Queue<char>() { };
            fifo.Enqueue('f');
            fifo.Enqueue('3');
            fifo.Enqueue('g');
            fifo.Enqueue('n');
            fifo.Dequeue();
            Log("Front of Queue: " + fifo.Peek()); //should be 3

            Log("User implemented Deque");
            
            var dq = new Deque<string>();
            dq.PushFront("glenn");
            dq.PushFront("devdatta");
            dq.PushFront("bill");
            dq.PushBack("devangi");
            dq.PushBack("alison");
            dq.PushBack("sarah");
            
            dq.PopBack();
            dq.PopFront();
            Log(dq);
            Log("Size of deque: "+dq.Size());
        }
        
        static void Main(string[] args)
        {
            Lists();
            Sets();
            Dictionaries();
            Advanced();
        }
    }
}
