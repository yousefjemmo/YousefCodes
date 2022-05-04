namespace Section6
{
    internal class Number
    {

        private int value;



        public void SetValue(int value)
        {
            this.value = value;
        }



        public int GetValue()
        {
            return value;
        }


        public bool IsZero()
        {
            return value == 0;
        }



        public bool IsPositive()
        {
            return value > 0;
        }


        public bool IsNegative()
        {
            return value < 0;
        }


        public bool IsOdd()
        {
            return value % 2 != 0;
        }


        public bool IsEven()
        {
            return value % 2 == 0;
        }



        public bool IsPrime()
        {
            if (IsNegative())
                return false;
            else
            {
                for (int i = 2; i < value / 2; i++)
                {
                    if (value % i == 0)
                        return false;
                }
                return true;
            }
        }



        public static int Power(int baseNumber, int exponent, bool recursive = false)
        {
            if (!recursive)
            {
                int power = baseNumber;
                for (int i = 1; i < exponent; i++)
                {
                    power *= baseNumber;
                }
                return power;
            }
            else
            {
                if (exponent == 0)
                    return 1;
                else
                    return baseNumber * (Number.Power(baseNumber: baseNumber, exponent: exponent - 1, recursive: true));
            }
        }



        public int GetCountOfDigits()
        {
            int num = value;
            int count = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            return count;
        }



        public int GetSumOfDigits()
        {
            int num = value;
            int digit, sum = 0;
            while (num > 0)
            {
                digit = num % 10;
                num = num / 10;
                sum += digit;
            }
            return sum;
        }



        public int GetReverse()
        {
            int num = value;
            int digit;
            string reverse = "";
            while (num > 0)
            {
                digit = num % 10;
                num = num / 10;
                reverse += digit;
            }
            return int.Parse(reverse);
        }



        public string ToWords()
        {
            int num = GetReverse();
            int digit;
            string word, words = "";
            while (num > 0)
            {
                digit = num % 10;
                num = num / 10;
                word = Number.GetWord(digit);
                words += word;
            }
            return words;
        }



        public static string GetWord(int digit)
        {
            switch (digit)
            {
                case 0: return "Zero ";
                case 1: return "One ";
                case 2: return "Two ";
                case 3: return "Three ";
                case 4: return "Four ";
                case 5: return "Five ";
                case 6: return "Six ";
                case 7: return "Seven ";
                case 8: return "Eight ";
                case 9: return "Nine ";
                default: return "";
            }
        }


        public bool IsArmstrong()
        {
            int num = value;
            int digit, sum = 0;
            int numberOfDigits = GetCountOfDigits();
            while (num > 0)
            {
                digit = num % 10;
                sum += Power(baseNumber: digit, exponent: numberOfDigits, recursive: true);
                num = num / 10;
            }
            return value == sum;
        }

        public string GetFibonacci()
        {

            int a = 0, b = 1;
            string fibonacci = a + ", " + b + ", ";
            int c = a + b;
            while (c <= value)
            {
                c = a + b;
                if (c > value)
                    break;


                fibonacci += c + ", ";

                a = b;
                b = c;
            }
            return fibonacci;
        }


        public bool isPalindrome()
        {
            return value == GetReverse();
        }
    }
}
