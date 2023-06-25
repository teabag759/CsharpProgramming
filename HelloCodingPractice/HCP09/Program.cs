using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 심화 9-1
            int[] passcodeNumbers = { 8, 7, 0, 3, 3, 4 };
            int[] userInput = new int[passcodeNumbers.Length];


            for (int i = 0; i < 5; i++)
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



            // 9-2
            int[] thirdClass = { 1, 2, 3, 4, 5 };
            double[] studentScores = new double[10];
            double sum = 0;

            for (int i = 0; i < thirdClass.Length; i++)
            {
                Console.WriteLine(thirdClass[i] + "반 학생들의 성적을 입력하세요.");
                for (int j = 0; j < studentScores.Length; j++)
                {
                    studentScores[j] = double.Parse(Console.ReadLine());
                    sum = sum + studentScores[j];
                }

                Console.Write(thirdClass[i] + "반 학생들의 평균은 ");
                Console.WriteLine((sum / studentScores.Length) + "점 입니다.");
            }


            Console.ReadLine();

        }
    }
}
