using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi

            string lauseHello2 = "Hello, World!";
            Console.WriteLine(lauseHello2);

            for (int i = lauseHello2.Length - 1; i >= 0; i--)
            {
                Console.Write(lauseHello2[i]);
            }
        }
    }
}
