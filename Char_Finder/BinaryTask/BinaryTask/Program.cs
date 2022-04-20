using System;

namespace BinaryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {         
 
            string[] DevTeam = { "Sarah", "Andreas", "Justin", "Gerrit", "Yousef", "Lennart", "Marco", "Andre", "Christian", "David" };
            Array.Sort(DevTeam);
           
            try
            {
                string Input = NameInput();
                CheckIfNameInList(Input, DevTeam);
                int result = binarySearch(DevTeam, Input);
                Console.WriteLine($"And the number postion in the array is {result}");
                             
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The Name does not exist!");
            }

        }

        public static string NameInput()
        {
            Console.WriteLine("Enter a Name to check if it exists: ");
            string NameInput = Console.ReadLine();
            return NameInput;
        }

        public static void CheckIfNameInList(string name, string[] array)
        {
            var check = Array.Exists(array, x => x == name);
            if (check == true)
            {
                Console.WriteLine($"{name} found in the array");
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static int binarySearch(string[] array, string name)
        {
            int Left = 0, Right = array.Length - 1;
            while (Left <= Right)
            {
                int middle = Left + (Right - Left) / 2;

                int check = name.CompareTo(array[middle]);
                
                if (check == 0)
                {
                    return middle;
                }                

                if (check > 0)
                {
                    Left = middle + 1;
                }
                else
                {
                    Right = middle - 1;
                }           
                
            }     

            return -1;
        }

       

    }
}
