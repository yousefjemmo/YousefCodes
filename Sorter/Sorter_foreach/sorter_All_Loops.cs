using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter_foreach
{
    internal class sorter_foreach
    {
        public static void Main(string[] args)
        {

            int input = UserInput();

            var OverTheLimit = IsBiggerThan20(input);
            if (OverTheLimit)
            {
                Console.WriteLine("The number is over 20.");
                return;
            }

            var s = GetSortedUsingWhileLoop(input);
            Console.WriteLine(string.Join(",", s));

            var y = GetSortedUsingForLoop(input);
            Console.WriteLine(string.Join(",", y));

            var x = GetSortedUsingForeachLoop(input);
            Console.WriteLine(string.Join(",", x));

        }

        private static int UserInput()
        {
            Console.WriteLine("How many words do you want to enter? ");
            return Convert.ToInt32(Console.ReadLine());


        }

        private static bool IsBiggerThan20(int input)
        {
            int max = 20;
            if (input > max)
            {
                return true;
            }
            return false;
        }

        private static List<string> GetSortedUsingWhileLoop(int input)
        {
            string output = "";
            int counter = 1;
            List<string> list = new List<string>();

            while (counter <= input)
            {
                Console.WriteLine("Now enter word number {0}:", counter);
                output = Console.ReadLine();
                list.Add(output);
                counter++;
            }

            list.Sort();
            return list;

        }


        private static List<string> GetSortedUsingForLoop(int input)
        {
            string output = "";
            List<string> list = new List<string>();
            for (int counter = 1; counter <= input; counter++)
            {
                Console.WriteLine("Now enter word number {0}:", counter);
                output = Console.ReadLine();
                list.Add(output);

            }
            list.Sort();
            return list;

        }



        static string[] GetSortedUsingForeachLoop(int i)
        {
            int counter = 1;
            string[] s = new string[i];
            int m = 0;
            foreach (var a in s)
            {
                Console.WriteLine("Now enter word number {0}:", counter);
                s[m] = Console.ReadLine();
                m++;
                counter++;
            }
            Array.Sort(s);
            return s;

        }
    }
}

//private static List<int> GetSortedUsingForeachLoop(List<int> oldList, int current, int max)
//{
//  if (current > max)
//  {
//      return oldList;
//  }

//    var newlist = new List<int>();
//    newlist.AddRange(oldList);
//    newlist.Add(current);
//    if (current == max)
//    {
//        return newlist;
//    }
//    else
//    {
//        current++;
//        return GetSortedUsingForeachLoop(newlist, current, max);
//    }
//}



//GetSortedUsingWhileLoop(input);
//GetSortedUsingForLoop(input);
//var list = GetSortedUsingForeachLoop(new List<int>(), 1, input);
//List<string> output = new List<string>();
//foreach (int e in list)
//{
//    Console.WriteLine("Now enter word number {0}:", e);
//    string output2 = Console.ReadLine();
//    output.Add(output2);

//}
//output.Sort();
//Console.WriteLine(string.Join(",", output));