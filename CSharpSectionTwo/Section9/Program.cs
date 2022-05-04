using System;

namespace Section9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DebitCard debitCard = new DebitCard();
            debitCard.PIN = "12345D"; 
            Console.WriteLine(debitCard.PIN); 
            Console.ReadKey();
        }
    }
}
