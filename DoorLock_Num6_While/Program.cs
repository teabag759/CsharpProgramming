using System;

namespace DoorLock_Num6_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumbers = { 8, 7, 0, 3, 3, 4 };
            int[] userInput = new int[6];


            while (true)
            { 
                Console.WriteLine("number1");
                userInput[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("number2");
                userInput[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("number3");
                userInput[2] = int.Parse(Console.ReadLine());
                Console.WriteLine("number4");
                userInput[3] = int.Parse(Console.ReadLine());
                Console.WriteLine("number5");
                userInput[4] = int.Parse(Console.ReadLine());
                Console.WriteLine("number6");
                userInput[5] = int.Parse(Console.ReadLine());



                if (userInput[0] == passcodeNumbers[0] && userInput[1] == passcodeNumbers[1]
                    && userInput[2] == passcodeNumbers[2] && userInput[3] == passcodeNumbers[3]
                    && userInput[4] == passcodeNumbers[4] && userInput[5] == passcodeNumbers[5])
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
                else { Console.WriteLine("비밀번호가 틀렸습니다."); }
            }
        }
    }
}
