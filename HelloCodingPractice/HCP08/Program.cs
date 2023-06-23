using System;

namespace HCP08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 심화 8-1
            int[] passcodeNumbers = { 8, 7, 0, 3, 3, 4 };
            int[] userInput = new int[6];

            while (true)
            {
                int passcodeIndex = 0;
                while (passcodeIndex < passcodeNumbers.Length)
                {
                    Console.WriteLine((passcodeIndex + 1) + "번째 숫자를 넣어주세요.");
                    userInput[passcodeIndex] = int.Parse(Console.ReadLine());
                    passcodeIndex = passcodeIndex + 1;

                }


                if (userInput[0] == passcodeNumbers[0] && userInput[1] == passcodeNumbers[1]
                        && userInput[2] == passcodeNumbers[2] && userInput[3] == passcodeNumbers[3]
                        && userInput[4] == passcodeNumbers[4] && userInput[5] == passcodeNumbers[5])
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
                else { Console.WriteLine("비밀번호가 틀렸습니다."); }
            }


            // 8-2
            Console.WriteLine("학생 수를 입력하세요.");
            int studentNumbers = int.Parse(Console.ReadLine());

            double[] Kscores = new double[studentNumbers];
            double[] Mscores = new double[studentNumbers];
            double[] Escores = new double[studentNumbers];

            int studentCount = 0;
            while (studentCount < studentNumbers) 
            {
                Console.Write("국어 점수: ");
                Kscores[studentCount] = double.Parse(Console.ReadLine());
                Console.Write("수학 점수: ");
                Mscores[studentCount] = double.Parse(Console.ReadLine());
                Console.Write("영어 점수: ");
                Escores[studentCount] = double.Parse(Console.ReadLine());

                studentCount = studentCount + 1;
            }

            studentCount = 0;
            while (studentCount < studentNumbers) 
            {
                double totalScore = Kscores[studentCount] + Mscores[studentCount] + Escores[studentCount];
                double avgScore = totalScore / 3;

                Console.Write(studentCount + 1);
                Console.WriteLine("번째 학생의 총점: ");
                Console.WriteLine(totalScore);

                Console.Write(studentCount + 1);
                Console.WriteLine("번째 학생의 평균: ");
                Console.WriteLine(avgScore);

                studentCount = studentCount + 1;
            }


            Console.ReadLine();
        }
    }
}
