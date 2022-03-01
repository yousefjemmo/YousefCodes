using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Palindrome
    {
        public static void Main(string[] args)
        {        
          
            string input = UserInput();

            var CheckSpecialChar = ContainsSpecialChar(input);
            if (CheckSpecialChar)
            {
                Console.WriteLine("Special character included that's not Allowed!!!!!");
                return;
            }

            var CheckNumbers = ContainsNumbers(input);
            if (CheckNumbers)
            {
                Console.WriteLine("Numbers included that's not Allowed!!!!!");
                return;
            }

            bool palindrome = ContainsPalindrome(input);
            Console.WriteLine(palindrome);
        



        }


        public static string UserInput()
        {
            Console.WriteLine("Please type any Senetence (Numbers and Special charachter are not allowed!");
            Console.Write("Your Sentence: ");            
            return Console.ReadLine();
        }


        public static bool ContainsSpecialChar(string input)
        {
            
            var specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-";
            foreach (var ch in specialCharacters)
            if (input.Contains((ch)))
            {                
              return true;
            }
            return false;
        }

        public static bool ContainsNumbers(string input)
        {
            var containsNumbers = "1234567890";
            foreach (var num in containsNumbers)
            if (input.Contains((num)))
            {
              return true;
            }

            return false;
        }
      
        public static bool ContainsPalindrome(string input)
        {
            input = input.ToLower();
            input = input.Replace(" ", string.Empty);

            if (input.Length <= 1)
            {

                return true;
            }
            else
            {
                if (input[0] != input[input.Length - 1])
                {

                    return false;
                }


            }

            return ContainsPalindrome(input.Substring(1, input.Length - 2));

        }
    }

}


//public static bool ContainsPalindrome(string str)
//{
//    char[] rev = str.ToCharArray();
//    Array.Reverse(rev);
//    string reversed = new string(rev);

//    if (str.Equals(reversed))
//    {

//        return true;
//    }

//    else
//    {
//        return false;
//    }

//}