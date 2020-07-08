

using System;

namespace Classes
{
    
    class Base
    {
        internal static void Log(object o) => Console.WriteLine(o);

        public void Hide() => Log("Base Hide called");

        public virtual void Override() => Log("Base Override called"); 

    }
}
