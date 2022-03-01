//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Sorter
//{
//    internal class sorter_while
//    {
//        public static void Main(string[] args)
//        {
//            int input = UserInput();

//            var OverTheLimit = IsBiggerThan20(input);
//            if (OverTheLimit)
//            {
//                Console.WriteLine("The number is over 20.");
//                return;
//            }

//            GetSorted(input);

//        }

//        private static int UserInput()
//        {
//            Console.WriteLine("How many words do you want to enter? ");
//            return Convert.ToInt32(Console.ReadLine());


//        }

//        private static bool IsBiggerThan20(int input)
//        {
//            int max = 20;
//            if (input > max)
//            {
//                return true;
//            }
//            return false;
//        }


//        private static void GetSortedUsingWhileLoop(int input)
//        {
//            string output = "";
//            int counter = 1;
//            List<string> list = new List<string>();
//            while (input < 20)
//            {

//                while (counter <= input)
//                {
//                    Console.WriteLine("Now enter word number {0}:", counter);
//                    output = Console.ReadLine();
//                    list.Add(output);
//                    counter++;
//                }
//                break;
//            }
//            list.Sort();
//            Console.WriteLine(string.Join(",", list));

//        }
//    }
//}
