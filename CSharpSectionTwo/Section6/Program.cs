using System;

namespace Section6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.SetValue(153); 
            Console.WriteLine("Value: " + number.GetValue()); 
            Console.WriteLine("IsZero: " + number.IsZero()); 
            Console.WriteLine("IsPositive: " + number.IsPositive()); 
            Console.WriteLine("IsNegative: " + number.IsNegative()); 
            Console.WriteLine("IsOdd: " + number.IsOdd()); 
            Console.WriteLine("IsEven: " + number.IsEven()); 
            Console.WriteLine("IsPrime: " + number.IsPrime()); 
            Console.WriteLine("GetCountOfDigits: " + number.GetCountOfDigits()); 
            Console.WriteLine("GetSumOfDigits: " + number.GetSumOfDigits()); 
            Console.WriteLine("GetReverse: " + number.GetReverse()); 
            Console.WriteLine("ToWords: " + number.ToWords()); 
            Console.WriteLine("IsArmstrong: " + number.IsArmstrong());
            Console.WriteLine("GetFibonacci: " + number.GetFibonacci()); 
            Console.WriteLine("isPalindrome: " + number.isPalindrome()); 
           
        }
    }
}
