﻿using System;

namespace HCP06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 심화 6-1
            Console.WriteLine("첫 번째 숫자를 입력하세요");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("두 번째 숫자를 입력하세요.");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("연산자를 입력하세요.");
            string inputOperator = Console.ReadLine();

            Console.Write(number1);
            Console.Write(inputOperator);
            Console.Write(number2);
            Console.Write(" = ");

            if (inputOperator == "+") { Console.WriteLine(number1 + number2); }

            else if (inputOperator == "-") { Console.WriteLine(number1 - number2); }

            else if (inputOperator == "*") { Console.WriteLine(number1 * number2); }

            else if (inputOperator == "/") { Console.WriteLine(number1 / number2); }

            else if (inputOperator == "%") { Console.WriteLine(number1 / number2); }


            // 6-2
            Console.WriteLine("숫자를 입력하세요.");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput > 20 &&  userInput % 3 == 0) { Console.WriteLine("20보다 큰 3의 배수입니다."); }
            else { Console.WriteLine("조건에 맞지 않는 수 입니다."); }
        }
    }
}

