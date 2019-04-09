using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Console
{
    class Palindrome
    {
        
        public bool isPalindrome(string input)
        {
            bool isPalindrome = true;
           
            try
            {
                char[] userInput = input.ToCharArray();

                if (userInput.Length == 0)
                {
                    throw new Exception("Cannot check a blank string. Please try again.");
                }

                for (int i = 0; i < userInput.Length; i++)
                {
                    if ((userInput[i] < 65) || (userInput[i] > 90 && userInput[i] < 97) || (userInput[i] > 123))
                    {
                        throw new Exception("Restricted character detected. Please try again.");
                    }
                    else
                    {
                        userInput[i] = Char.ToLower(userInput[i]);
                    }
                }

                for (int index = 0; index < userInput.Length / 2; index++)
                    {
                        
                        if (userInput[index] != userInput[userInput.Length - 1 - index])
                        {
                            isPalindrome = false;
                        }
    
                    }
            }

            catch(Exception ex)
            {
                throw ex;
            }

            return isPalindrome;
        }
    }
}
