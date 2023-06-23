using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorLock_Num6_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumbers = { 8, 7, 0, 3, 3, 4 };
            int[] userInput = new int[passcodeNumbers.Length];


            while (true)
            {
                for (int passcodeIndex = 0; passcodeIndex < passcodeNumbers.Length; passcodeIndex++)
                {
                    Console.Write(passcodeIndex);
                    Console.WriteLine("번째 숫자를 넣어주세요.");
                    userInput[passcodeIndex] = int.Parse(Console.ReadLine());
                }

                bool isPasswordCoreect = true;
                for (int passcodeIndex = 0; passcodeIndex < passcodeNumbers.Length; passcodeIndex++)
                {
                    if (userInput[passcodeIndex] != passcodeNumbers[passcodeIndex])
                    {
                        isPasswordCoreect = false;
                        Console.WriteLine("비밀번호가 틀렸습니다.");
                        break;
                    }
                }

                if (isPasswordCoreect)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }


            }
        }
    }
}
