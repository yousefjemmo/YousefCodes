
using System;
using static System.Console;
using static System.Convert;


namespace HarshaBank.Presentation
{
    public class Program
    {
        #region Methods
        public static void Main()
        {
            WriteLine("********** Harsha Bank **********");
            var (userName, password) = LoginPage();
            if (userName == "system" && password == "manager")
                MainMenu();
            WriteLine("Thank you! Visit again");
        }

        private static (string userName, string password) LoginPage()
        {
            try
            {
                WriteLine("\n:::Login page:::");
                Write("User name: ");
                var userName = ReadLine();
                Write("Password: ");
                var password = ReadLine();
                return (userName, password);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void MainMenu()
        {
            int menuChoice;
            do
            {
                WriteLine("\n:::Main menu:::");
                WriteLine("1. Customers");
                WriteLine("2. Accounts");
                WriteLine("3. Funds transfer");
                WriteLine("4. Funds transfer statement");
                WriteLine("5. Account statement");
                WriteLine("0. Exit");

                Write("Enter choice: ");
                menuChoice = ToInt32(ReadLine());

                switch (menuChoice)
                {
                    case 1: CustomersMenu(); break;
                    case 2: AccountsMenu(); break;
                    case 3: FundsTransferMenu(); break;                 
                    case 0: Environment.Exit(0); break;
                    default: throw new InvalidOperationException();
                }
            } while (menuChoice != 0);
        }

        private static void CustomersMenu()
        {
            int menuChoice;
            do
            {
                WriteLine("\n:::Customers menu:::");
                WriteLine("1. Edit customer");
                WriteLine("2. Delete customer");              
                WriteLine("0. Back to main menu");

                Write("Enter choice: ");
                menuChoice = ToInt32(ReadLine());

                switch (menuChoice)
                {
                    case 1: EditCustomer(); break;
                    case 2: DeleteCustomer(); break;                 
                    case 0: return;
                    default: throw new InvalidOperationException();
                }
            } while (menuChoice != 0);
        }

      

        private static void AccountsMenu()
        {
            int menuChoice;
            do
            {
                WriteLine("\n:::Accounts menu:::");
                WriteLine("1. New account");
                WriteLine("2. Delete account");
                WriteLine("3. Edit account");
                WriteLine("4. View accounts");                

                Write("Enter choice: ");
                menuChoice = ToInt32(ReadLine());

                switch (menuChoice)
                {
                    case 1: NewAccount(); break;
                    case 2: DeleteAccount(); break;
                    case 3: EditAccount(); break;
                    case 4: ViewAccount(); break;
                 
                    case 0: return;
                    default: throw new InvalidOperationException();
                }
            } while (menuChoice != 0);
        }

      
        private static void FundsTransferMenu()
        {
            int menuChoice;
            do
            {
                WriteLine("\n:::Funds transfer menu:::");
                WriteLine("1. Transfer fund");
                WriteLine("2. Fund Transfare Statement");
                WriteLine("3. Account Statement");
                WriteLine("0. Back to main menu");

                Write("Enter choice: ");
                menuChoice = ToInt32(ReadLine());

                switch (menuChoice)
                {
                    case 1: TransferFund(); break;
                    case 2: FundTransfareStatement(); break;
                    case 3: AccountStatement(); break;
                    case 0: return;
                    default: throw new InvalidOperationException();
                }
            } while (menuChoice != 0);
        }

    }
}