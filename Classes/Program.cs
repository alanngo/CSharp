using System;

namespace Classes
{
    class Program
    {

        static void Log(object o) => Console.WriteLine(o);

        static void Inheritence()
        {
            Log("static bind to base class");
            Base b = new Base();
            b.Hide(); //calls base Hide
            b.Override(); //call base Override 
            Log("");

            Log("dynamic bind to derived class");
            Base b1 = new Derived();
            b1.Hide(); // did not call derived Hide bc of new specifier in derived class
            b1.Override();//call derived Override bc of override specifier in derived class
            Log("");

            Log("static bind to derived class");
            Derived d = new Derived();
            d.Hide(); // call derived Hide
            d.Override(); //call derived Override
            Log("");

        }
        static void Main(string[] args)
        {

            User u = new User("alan", "ngo");

            Log(u.Equals(new User("alan", "ngo"))); //override both Equals and GetHashCode
            Log(u == new User("alan", "ngo")); //overload == operator
            Log(u); //override ToString
            Log("");

            Inheritence();


        }
    }
}
