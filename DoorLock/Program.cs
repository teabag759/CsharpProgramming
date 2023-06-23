using System;

namespace DoorLock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passcodeNumber1 = 8;
            int passcodeNumber2 = 7;
            int passcodeNumber3 = 4;
            int passcodeNumber4 = 5;

            Console.WriteLine("number1");
            int userInput1 = int.Parse(Console.ReadLine());
            Console.WriteLine("number2");
            int userInput2 = int.Parse(Console.ReadLine());
            Console.WriteLine("number3");
            int userInput3 = int.Parse(Console.ReadLine());
            Console.WriteLine("number4");
            int userInput4 = int.Parse(Console.ReadLine());

            //if(userInput1 == passcodeNumber1)
            //{
            //    if(userInput2 == passcodeNumber2) 
            //    {
            //        if(userInput3 == passcodeNumber3)
            //        {
            //            if (userInput4 == passcodeNumber4) { Console.WriteLine("문이 열렸습니다."); }
            //        }
            //    }
            //}
            //else { Console.WriteLine("비밀번호가 틀렸습니다."); }


            if (userInput1 == passcodeNumber1 && userInput2 == passcodeNumber2
                && userInput3 == passcodeNumber3 && userInput4 == passcodeNumber4)
            {
                Console.WriteLine("문이 열렸습니다.");
            }
            else { Console.WriteLine("비밀번호가 틀렸습니다."); }
        }
    }
}
