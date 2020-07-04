using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        // make it easy for printing
        static void Log(object o) => Console.WriteLine(o);
        static void Print(int [] arr) 
        {
            foreach (int o in arr) //c# foreach loop
                Log(o);
        }
        static void Print(string[] arr)
        {
            foreach (string o in arr) //c# foreach loop
                Log(o);
        }
        static void Main(string[] args)
        {
            int[] odd = {1,3,5,7,9}; //static array
            
            string[] names = new string[]{ "varshika", "carlos", "smruti", "kevin" ,"lyndon"}; // dynamic array
            Print(names);


            Print(odd);
        }
    }
}
