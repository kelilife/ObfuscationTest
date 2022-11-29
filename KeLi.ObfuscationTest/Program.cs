using System;

namespace KeLi.ObfuscationTest
{
    internal class Program
    {
        private static void Main()
        {
            Test();
        }

        private static void Test()
        {
            for (var i = 0; i < 100; i++)
            {
                if (i < 10)
                    Console.WriteLine(i + 1);

                else
                {
                    if (i > 80)
                        Console.WriteLine(i - 2);

                    if (i > 90)
                        Console.WriteLine(i - 5);
                }
            }

            Console.ReadLine();
        }
    }
}
