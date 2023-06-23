using System;

namespace HCP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 심화 5-1
            Console.WriteLine("number1");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("number2");
            string userInput2 = Console.ReadLine();

            double number1 = double.Parse(userInput1);
            double number2 = double.Parse(userInput2);

            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 / number2);


            // 5-2 분모가 되는 값에 0을 넣으면?
                // 무한대로 표현!
                // number1, 2의 타입을 int로 할 경우 오류 발생 


            // 5-3
            Console.WriteLine("주머니의 동전 = 10개");
            int inPouch = 10;
            Console.WriteLine("어머니가 넣은 동전의 개수?");
            int Mcoins = int.Parse(Console.ReadLine());
            Console.WriteLine("아람이가 꺼낸 동전의 개수?");
            int Acoins = int.Parse(Console.ReadLine());
            Console.WriteLine("우람이가 꺼낸 동전의 개수?");
            int Ucoins = int.Parse(Console.ReadLine());

            Console.WriteLine("주머니에 남아 있는 동전의 개수 = ");
            Console.WriteLine(inPouch + Mcoins - Acoins - Ucoins);
        }
    }
}
