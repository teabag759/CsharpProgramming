﻿using System;

namespace Gugudan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 2; i < 10; i++)
            // for (int i = 2; i < 10; i = i + 2)   // 짝수 단
            {
                Console.Write(i); 
                Console.WriteLine("단");
                
                for (int j = 1; j < 10; j++) 
                {
                    Console.Write(i + "x" + j + " = " + i * j);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
