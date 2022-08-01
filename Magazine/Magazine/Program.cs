using System;
using MagazinePresentation;



internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("------Amagno Magazine------");
        Console.WriteLine("Would you like to to see the Main Menu? yes or no?");
        string answer = Console.ReadLine();

        if (answer == "yes")
        {
            int mainMenuChoice = -1;
            do
            {

                Console.WriteLine("\n:::Main Menu:::");
                Console.WriteLine("1. Press 1 to go to Magazine Menu");                               

                Console.WriteLine("0. Exit");

                Console.WriteLine("Enter Choice: ");

                mainMenuChoice = int.Parse(Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        MagazineMenue();
                        break;
                       
                                
                }


            } while (mainMenuChoice != 0);
        }
        else
        {

            Console.WriteLine("Invalid");

        }

        Console.WriteLine("Invalid Credentials");
        Console.ReadKey();

        static void MagazineMenue()
        {

            int magazineMenuChoice = -1;

            do
            {
                Console.WriteLine("\n:::Magazine:::");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Delete");
                Console.WriteLine("3. Edit");
                Console.WriteLine("4. Search");
                Console.WriteLine("5. View All");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Enter Choice: ");

                magazineMenuChoice = Convert.ToInt32(Console.ReadLine().Trim());

                switch (magazineMenuChoice)
                {
                    case 1: MagazinePresentation.MagazinePresentation.AddMagazine(); break;
                    case 2: MagazinePresentation.MagazinePresentation.DeleteMagazine(); break;
                    case 3: MagazinePresentation.MagazinePresentation.EditMagazine(); break;
                    case 5: MagazinePresentation.MagazinePresentation.ViewMagazine(); break;

                }

            } while (magazineMenuChoice != 0);


        }


    }

}
