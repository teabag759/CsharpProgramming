using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 심화 10-1 숫자 맞추기 게임
            Random random = new Random();

            Console.WriteLine("수비수가 숫자를 골랐습니다.");
            int randomNum = random.Next(1, 101);

            //Console.WriteLine(randomNum);

            while (true)
            {
                int userInput = int.Parse(Console.ReadLine());

                if (userInput == randomNum)
                {
                    Console.WriteLine("정답입니다.");
                    break;
                }

                else if (userInput < randomNum)
                { Console.WriteLine("더 큰 숫자입니다."); }

                else
                { Console.WriteLine("더 작은 숫자입니다."); }
            }



            // 10-2 가위바위보 게임
            int scissors = 1;
            int rock = 2;
            int paper = 3;

            Random random2 = new Random();
            int randomNum2 = random2.Next(1, 4);
            //Console.WriteLine(randomNum2);

            Console.WriteLine("가위(1), 바위(2), 보(3) 중 하나를 입력하세요.");

            while (true)
            { 
                int userInput2 = int.Parse(Console.ReadLine());

                if (userInput2 == randomNum2)
                {
                    Console.WriteLine("비겼습니다.");
                }
                else if (((userInput2 == scissors) && (randomNum2 == paper)) ||
                    ((userInput2 == rock) && (randomNum2 == scissors)) ||
                    ((userInput2 == paper) && (randomNum2 == rock)))
                {
                    Console.WriteLine("이겼습니다.");
                    break;
                }
                else 
                {
                    Console.WriteLine("졌습니다.");
                    break;
                }

            }


            // 10-2 POCU
            Random random3 = new Random();
            int computerInput = random3.Next(1, 4);

            Console.WriteLine("가위(1), 바위(2), 보(3) 중 하나를 입력하세요.");
            int userInput3 = int.Parse(Console.ReadLine());


            while (true)
            {
                if (userInput3 >= 1 && userInput3 <= 3)
                {
                    int result = computerInput - userInput3;

                    if (result == -1 || result == 2)
                    {
                        Console.WriteLine("졌습니다.");
                        break;
                    }
                    else if (result == -2 || result == 1)
                    {
                        Console.WriteLine("이겼습니다.");
                        break;
                    }
                    else { Console.WriteLine("비겼습니다."); }
                }
                else { Console.WriteLine("올바른 값이 아닙니다."); }
            }



            Console.ReadLine();

        }
    }
}
