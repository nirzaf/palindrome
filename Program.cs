using System;

namespace palindrome
{
    class Program
    {
        private static void Main(string[] args)
        {
            var pal = Console.ReadLine();
            for (var i = 0; i < pal.Length / 2; i++)
            {
                if (pal[i].ToString() != pal[^(i+1)].ToString())
                {
                    Console.WriteLine("Not a palindrome");
                    break;
                }

                if (i == (pal.Length / 2) - 1)
                {
                    Console.WriteLine("palindrome");
                }                
            }
            Console.ReadLine();



        }

    }
}
