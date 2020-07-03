// static imports
using static System.Console;
using static System.Convert;


namespace BasicIO
{
    class Program
    {
        static void Log(object o) => WriteLine(o);

        static void Main(string[] args)
        {
            Write("Enter a string value: ");
            string str = ReadLine();

            Write("Enter an int value: ");
            int i = ToInt32(ReadLine());

            Write("Enter a double value: ");
            double d = ToDouble(ReadLine());

            Log("string: " + str);
            Log("int: " + i);
            Log("double: " + d);
        }
    }
}
