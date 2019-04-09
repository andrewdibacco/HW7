using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            bool isPalindrome = false;

            while (true)
            {
                System.Console.WriteLine("Enter any text to see if your word is a palindrome or 'Exit' to quit...");
                string msg = System.Console.ReadLine();

                if (msg == "Exit")
                {
                    break;
                }

                try
                {
                    isPalindrome = p.isPalindrome(msg);
                    System.Console.WriteLine($"{msg}: Palindrome = {isPalindrome}");
                }
                catch(Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
