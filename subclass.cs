using System;

namespace ExampleNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Greet();
            program.DisplayDate();

            SubClass sub = new SubClass();
            sub.PrintMessage();
            sub.AddNumbers(5, 10);
            sub.MultiplyNumbers(3, 4);
        }

        // Function 1
        public void Greet()
        {
            Console.WriteLine("Hello from the Main Class!");
        }

        // Function 2
        public void DisplayDate()
        {
            Console.WriteLine("Today's date is: " + DateTime.Now.ToShortDateString());
        }

        // Nested class
        public class SubClass
        {
            // Function 1
            public void PrintMessage()
            {
                Console.WriteLine("Hello from the Nested SubClass!");
            }

            // Function 2
            public int AddNumbers(int a, int b)
            {
                int result = a + b;
                Console.WriteLine($"Addition result: {result}");
                return result;
            }

            // Function 3
            public int MultiplyNumbers(int a, int b)
            {
                int result = a * b;
                Console.WriteLine($"Multiplication result: {result}");
                return result;
            }
        }
    }
}
