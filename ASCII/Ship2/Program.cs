
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    internal class ASCII
    {
        public static void Main(string[] args)
        {
            int size = 0;
            bool InputNumberIsValid = false;

            while (!InputNumberIsValid)
            {
                try
                {
                    size = AskForNumber();
                    CheckIfNumberIsInRange(size);
                    CheckIfNumberIsEven(size);
                    InputNumberIsValid = true;

                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The minimum number is 4 and maximumum is 36.");

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("You are only allowed to enter numbers");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("The number is too big");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("You are only allowed to write even numbers");

                }

            }

            Console.WriteLine(size);


            string Ship = GetHead(size) + GetShoulder(size) + GetLowerBody(size) + GetBottom(size);
            Console.Write(Ship);

            Console.WriteLine();


        }

        public static int AskForNumber()
        {
            Console.Write("Please insert a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static void CheckIfNumberIsInRange(int input)
        {
            if (input < 4 || input > 36)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public static void CheckIfNumberIsEven(int input)
        {
            if (input % 2 != 0)
            {
                throw new ArgumentException();
            }

        }

        private static string GetHead(int size)
        {
            int row, col;
            string results = "";
            int rowsInHead = size / 2 - 1;

            for (row = 0; row < rowsInHead; row++)
            {

                int sizeOntheLeftInCurrentRow = size - row;
                for (col = 0; col < sizeOntheLeftInCurrentRow; col++)
                {
                    results = results + " ";

                }


                results += "/";


                int innerSizeInCurrentRow = row * 2 + 1;
                for (col = 1; col < innerSizeInCurrentRow; col++)
                {
                    results = results + " ";

                }
                results += "\\";


                results += System.Environment.NewLine;


            }
            return results;
        }
        private static string GetShoulder(int size)
        {
            int col;
            string results = "";
            results += " ";

            results += Shoulder(size);
            results += "/";
            for (col = 1; col < size - 1; col++)
            {
                results = results + " ";
            }
            results += "\\";
            results += Shoulder(size);

            results += System.Environment.NewLine;

            return results;

        }

        private static string Shoulder(int size)
        {
            int row;
            string xresult = "";
            for (row = 1; row <= size / 2; row++)
            {
                xresult = xresult + "_";
            }
            return xresult;

        }



        private static string GetLowerBody(int size)
        {
            int row, col;
            string results = "";
            for (row = 1; row <= size / 2 - 1; row++)
            {

                for (col = 0; col < row; col++)
                {
                    results = results + " ";
                }

                results += "\\";


                for (col = 1; col < (size * 2 - row * 2 + 1); col++)
                {
                    results += " ";

                }
                results += "/";

                results += System.Environment.NewLine;


            }
            return results;
        }

        private static string GetBottom(int size)
        {
            int row;
            string results = "";
            for (row = 1; row <= size / 2; row++)
            {
                results = results + " ";
            }
            results += "\\";
            for (row = 1; row <= size; row++)
            {
                results = results + "_";
            }
            results += "/";
            return results;

        }

    }
}