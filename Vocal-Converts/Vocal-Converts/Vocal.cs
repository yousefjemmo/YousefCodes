using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocal_Converts
{
    internal class Vocal
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write a word:");
            string input = Console.ReadLine();


            foreach (char ch in input)
            {
                if (HasDigits(ch))
                {
                    return;
                }

            }



            string result1 = ReplaceAwith4(input);

            string result2 = ReplaceEwith3(result1);

            string result3 = ReplaceIwith1(result2);

            string result4 = ReplaceOwith0(result3);

            string result5 = ReplaceUwith6(result4);


            AddNumbers(result5);

        }



        private static bool HasDigits(char digit)
        {


            if (char.IsDigit(digit))
            {
                Console.WriteLine("You not allowed to include numbers!");

                return true;
            }
            return false;

        }

        private static string ReplaceAwith4(string a)
        {

            a = a.Replace("a", "4").Replace("A", "4");


            return a;

        }
        private static string ReplaceEwith3(string e)
        {

            e = e.Replace("e", "3").Replace("E", "3");

            return e;

        }

        private static string ReplaceIwith1(string i)
        {

            i = i.Replace("i", "1").Replace("I", "1");

            return i;

        }

        private static string ReplaceOwith0(string o)
        {

            o = o.Replace("o", "0").Replace("O", "0");

            return o;

        }

        private static string ReplaceUwith6(string u)
        {

            u = u.Replace("u", "6").Replace("U", "6");

            return u;

        }


        private static void AddNumbers(string word)
        {

            string Converted = "";

            for (int i = 0; i < word.Length; i++)
            {
                int numberOfConsecutiveDigit = GetNumbers(word, i);

                if (numberOfConsecutiveDigit >= 2)
                {
                    string result = GetSum(word, i, numberOfConsecutiveDigit);

                    Converted += result;

                    i += numberOfConsecutiveDigit - 1;
                }
                else
                {
                    Converted += word[i];
                }


            }
            Console.WriteLine(Converted);
        }

        private static int GetNumbers(string word, int i)
        {
            int numberOfConsecutiveDigits = 0;
            if (char.IsDigit(word[i]))
            {
               for (int x = i;  x < word.Length; x++ )
                {

                if (char.IsDigit(word[x]))
                {
                        numberOfConsecutiveDigits++;
                }
                else
                {
                        return numberOfConsecutiveDigits;
                }

                }
            }
           

            return numberOfConsecutiveDigits;
        }

        



        private static string GetSum(string word, int index, int numberOfConsecutiveDigits)
        {
            int sum = 0;

            for (int i = index; i < numberOfConsecutiveDigits + index; i++)    
            {
                 
                 sum = (int)(sum + (char.GetNumericValue(word[i])));
                 //sum = sum + (int.Parse(word[i].ToString()));

                
            }
            

            return sum.ToString(); 
        }

        



    }
}      



















//private static void AddNumbers(string num1)
//{

//    string Converted = "";

//    for (int i = 0; i < num1.Length; i++)
//    {
//        if (i < num1.Length - 1 && char.IsDigit(num1[i]) && char.IsDigit(num1[i + 1]))
//        {
//            string result = (int.Parse(num1[i].ToString()) + int.Parse(num1[i + 1].ToString())).ToString();

//            Converted += result;
//            i++;

//        }
//        else
//        {
//            Converted += num1[i];
//        }

//    }
//    Console.WriteLine(Converted);
//}