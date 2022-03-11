namespace Paasword
{
    internal class password1
    {
        

        public static void Main(string[] args)
        {

            
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNum = false;
            bool hasSpecialLetter = false;

            int PasswordConditionCount = 0;

            Console.Write("Enter your password: ");
            string input = Console.ReadLine();

            // Lenght 
            var longenoght = CheckLenght(input);
            if (!longenoght)
            {
                Console.WriteLine("Your password is less than 8 char or more than 16 char");
            }
            // contains space?
            var includesSpace = Space_Enter(input);
            if (!includesSpace)
            {
                Console.WriteLine("Your password contains enter or space");
            }   
            if (input.Any(char.IsUpper))
            {
                hasUpper = true;
            }
            if (input.Any(char.IsLower))
            {
                hasLower = true;
            }
            if (input.Any(char.IsDigit))
            {
                hasNum = true;
            }
            // special Characters
            var includespecial = ContainsSpecialChar(input);
            if (includespecial)
            {
               hasSpecialLetter = true;
            }
            if (hasUpper == true)
            {
               PasswordConditionCount++;
            }
            if (hasNum == true)
            {
                PasswordConditionCount++;
            }
            if (hasLower == true)
            {
                PasswordConditionCount++;
            }
            if (hasSpecialLetter == true)
            {
                PasswordConditionCount++;
            }
            if (PasswordConditionCount < 3)
            {
                Console.WriteLine("Your password doesn't contains Upper, lower, number or special character");
            }
            string[] stringArray = { "test", "password", "hello", "bla" };
            foreach (string x in stringArray)
            {
                if (input.Contains(x))
                {
                    Console.WriteLine("Your password contains words");
                }
            }
            char previousElement = ' ';
            char prepreviousElement = ' ';
            foreach (char ch in input)
            {
                CheckThreeDigits(ch, previousElement, prepreviousElement);           

                prepreviousElement = previousElement;
                previousElement = ch;

            }
            Console.WriteLine("The Password You entered is : " + input);
        }
        private static void CheckThreeDigits(char current, char previous, char preprevious)
        {
            if (char.IsDigit(current) && char.IsDigit(previous) && char.IsDigit(preprevious))
            {
                if (current == previous && current == preprevious)
                {
                    Console.WriteLine("Your password is not valid beacuse same numbers");
                }
                if (previous == current - 1 && preprevious == current - 2)
                {
                    Console.WriteLine("Numbers are in order");
                }
                if (previous == current + 1 && preprevious == current + 2)
                {
                    Console.WriteLine("Numbers are in order 2");
                }                
            }            
        }

        private static bool ContainsSpecialChar(string password)
        {
            var specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-";
            foreach (var ch in specialCharacters)
                if (password.Contains((ch)))
                {
                    Console.WriteLine("Special character included");
                    return true;
                }
            return false;
        }
        private static bool CheckLenght(string passwordlenght)
        {
            if (passwordlenght.Length < 8 || passwordlenght.Length > 16)
            {
               
                return false;
            }
            return true;
        }
        private static bool Space_Enter(string space_enter)
        {
            if (space_enter.Contains("  ") || space_enter.Contains("\r\n"))
            {
                return false;
            }
            return true;  
        }
    }   

}


