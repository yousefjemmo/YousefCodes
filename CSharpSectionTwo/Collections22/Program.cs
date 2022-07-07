using System;
using System.Collections.Generic;
using System.Collections;

namespace Collections22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listClass = new ListExamples();
            var jaggedlist = new List<List<int>>()
            {
                new List<int>( ) { -3, 0, -4 },
                new List<int>( ) { 80, 99, 750, 99 },
                new List<int>( ) { 888, 333, 9898 }
            };

            foreach (var listitem in jaggedlist)
            {
                Console.Write("{");
                for (int i = 0; i < listitem.Count; i++)
                {
                    Console.Write(listitem[i]);
                    if (i < listitem.Count - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine("}");
            }

            Console.WriteLine("Largest number of each list:");
            Console.Write("{");
            var res = listClass.FindLargest(jaggedlist);
            for (int i = 0; i < res.Count; i++)
            {
                Console.Write(res[i]);
                if (i < res.Count - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("}"); 

        }
    }
}
