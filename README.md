# C Sharp
## Intro
- C# is similar to Java except you have to use Microsoft Visual Studio to run it
- You can only have 1 Main function per project
     ```csharp
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
    ```
- Uses PascalCase as notation for functions
    - EX: 
    ```csharp
        int Sum(int x, int y){...}
    ```
