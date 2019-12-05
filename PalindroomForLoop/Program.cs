using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindroomForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a word");
            string userInput = Console.ReadLine();

            if (IsPalindrome(userInput))//funktsiooni väljakutsumine
            {
                Console.WriteLine($"{userInput} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{userInput} is not s palindrome");
            }


            //VEEL VESTLUSE ÜLESANNET






            Console.ReadKey();
        }

        public static bool IsPalindrome(string userString) //funktsioon
        {
            //VARIANT 1
            int j = userString.Length - 1;
            /*for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] != userString[j])
                {
                    return false;
                }
                j--;
            }*/


            //PAREM VARIANT
            for (int i = 0; i <= j / 2; i++, j--)
            {
                if(userString[i] != userString[j])
                {
                    return false;
                }
            }


            return true;
        }
    }
}
