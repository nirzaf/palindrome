using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string pal = Console.ReadLine();

            for (int i = 0; i < pal.Length / 2; i++)
            {
                if (pal[i].ToString() != pal[pal.Length - (i+1)].ToString())
                {
                    Console.WriteLine("Not a palindrome");
                    break;
                }

                if (i == (pal.Length / 2) - 1)
                {
                    Console.WriteLine("palindrome");
                }                
            }
        }
    }
}
