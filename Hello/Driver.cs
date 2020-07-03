using System;

namespace Hello
{
    class Driver
    {
        // make it easy for printing
        static void Log(object o) => Console.WriteLine(o);
        static void Main(string[] args)
        {
            Log("Hello World!");
        }
    }
}
