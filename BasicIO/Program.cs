// static imports
using System.IO;
using static System.Console;
using static System.Convert;


namespace BasicIO
{
    class Program
    {
        private static void StandardIO()
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

        private static void ReadFile(string name)
        {
            StreamReader sr = new StreamReader(name); //need to set working directory to avoid errors

            string line;
            while((line = sr.ReadLine())!=null) 
                Log(line);
            sr.Close();
        }

        private static void WriteFile(string name, string txt)
        {
            StreamWriter sw = new StreamWriter(name); // will generate file if file not found
            sw.Write(txt);
            sw.Close();
        }

        static void Log(object o) => WriteLine(o);

        static void Main(string[] args)
        {
            //read from a file
            ReadFile("pc.txt");
            WriteFile("output.txt", "eluktronics");
            StandardIO();
        }
    }
}
