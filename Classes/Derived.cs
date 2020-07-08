

namespace Classes
{
    class Derived: Base
    {
        public new void Hide() => Log("Derived Hide called"); // method hiding 


        // overridden methods need to override virtual/abstract/override methods
        public override void Override() => Log("Derived Override Called "); 

    }
}
