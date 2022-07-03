using System;

namespace FooBar_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 30)
            {
                i++;

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Foo Bar");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Foo");
                }

                else if(i % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }  
        }
    }
}