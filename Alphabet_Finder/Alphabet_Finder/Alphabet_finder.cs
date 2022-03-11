using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet_Finder
{
    internal class Alphabet_finder
    {
        public static void Main(string[] args)
        {
            string input = UserInput();

            var includeSpace = ContainsSpace(input);
            if (includeSpace)
            {
                Console.WriteLine("Your string contains space");

                

            }


            RepeatedChar(input);


            
                
        }

        private static string UserInput()
        {
            Console.WriteLine("Please type something (Don't use space!!!)");
            return Console.ReadLine();

        }

        private static bool ContainsSpace(string space)
        {
            if (space.Contains(" "))
            {
                return true;

            }
            return false;

        }

        private static void RepeatedChar(string output2)
        {
            Dictionary<char, int> charDic = new Dictionary<char, int>();
            int max = 0;
            foreach (char c in output2)
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
            foreach (KeyValuePair<char, int> chars in charDic)
            {
                if (chars.Value == max)
                {
                    Console.WriteLine(chars.Key);
                }
            }
        }

















    }  
}
