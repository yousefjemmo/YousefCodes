using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Char_Finder
{
    internal class finder
    {
        public static void Main(string[] args)
        {

           
            
            string input = UserInput();

            var includeSpace = ContainsSpace(input);
            if (includeSpace)
            {
                Console.WriteLine("Your string contains space");
                return;
            }


            Dictionary<char, int> charDic = GetTheMostRepeatedChar(input);
            List<char> myList = new List<char>();
            foreach (KeyValuePair<char, int> chars in charDic)
            {
                if (chars.Value == charDic.Values.Max())
                {
                    
                    myList.Add(chars.Key);
                   

                }

            }
            string output = string.Join(",", myList);
            Console.Write(output);


        }
        private static string UserInput()
        {
            Console.WriteLine("Please type something (Don't use space!!!)");
            return Console.ReadLine();

            
        }

        private static bool ContainsSpace(string input)
        {
            if (input.Contains(" "))
            {
                return true;
            }
            return false;
        }

        private static Dictionary<char, int> GetTheMostRepeatedChar(string input)
        {
            Dictionary<char, int> charDic = new Dictionary<char, int>();
            int max = 0;
            foreach (char c in input)
            {
                int i = 0;
                charDic.TryGetValue(c, out i);
                i++;
                if (i > max)
                {
                    max = i;
                }
                charDic[c] = i;
            }
            return charDic;
            
            

        }

    }
}
