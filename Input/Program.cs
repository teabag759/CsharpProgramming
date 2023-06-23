using System;

namespace Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("글자를 입력하고 엔터 키를 누르세요.");
            string userInput = Console.ReadLine();

            Console.Write("입력한 글은 ");
            Console.Write(userInput);
            Console.WriteLine("입니다.");


            Console.WriteLine("첫 번째 숫자를 입력하세요");
            string userInput1 = Console.ReadLine();
            /*int number1 = int.Parse(userInput1);*/
            double number1 = double.Parse(userInput1);

            Console.WriteLine("두 번째 숫자를 입력하세요.");
            string userInput2 = Console.ReadLine();
            //int number2 = int.Parse(userInput2);
            double number2 = double.Parse(userInput2);

            Console.Write(number1);
            Console.Write(" + ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(number1 + number2);
            
        }
    }
}
