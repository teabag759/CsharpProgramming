using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;

namespace HCP07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 심화 7-1
            Console.WriteLine("학생 숫자를 입력하세요.");
            int studentCount = int.Parse(Console.ReadLine());

            int[] ages = new int[studentCount];
            string[] names = new string[studentCount];
            double[] heights = new double[studentCount];
            double[] weights = new double[studentCount];

            Console.WriteLine("몇 번째 학생의 정보를 추가할까요?");
            int studentNumber = int.Parse(Console.ReadLine());

            if (studentNumber >= 0 && studentNumber <= studentCount - 1)
            {
                Console.WriteLine("나이를 입력하세요.");
                ages[studentNumber] = int.Parse(Console.ReadLine());

                Console.WriteLine("이름을 입력하세요.");
                names[studentNumber] = Console.ReadLine();

                Console.WriteLine("키를 입력하세요.");
                heights[studentNumber] = double.Parse(Console.ReadLine());

                Console.WriteLine("몸무게를 입력하세요.");
                weights[studentNumber] = double.Parse(Console.ReadLine());


                Console.Write(studentNumber);
                Console.WriteLine("번째 학생");
                Console.Write("이름: ");
                Console.WriteLine(names[studentNumber]);
                Console.Write("나이: ");
                Console.WriteLine(ages[studentNumber]);
                Console.Write("키: ");
                Console.WriteLine(heights[studentNumber]);
                Console.Write("몸무게: ");
                Console.WriteLine(weights[studentNumber]);
            }
            else
            {
                Console.Write("0에서 ");
                Console.Write(studentCount - 1);
                Console.WriteLine("사이의 숫자를 입력하세요.");
            }


            // 7-2
            string[] subjects = { "국어", "영어", "수학", "과학", "사회" };
            double[] scores = new double[subjects.Length];
            

            Console.Write("국어 성적: ");
            scores[0] = double.Parse(Console.ReadLine());
            Console.Write("영어 성적: ");
            scores[1] = double.Parse(Console.ReadLine());
            Console.Write("수학 성적: ");
            scores[2] = double.Parse(Console.ReadLine());
            Console.Write("과학 성적: ");
            scores[3] = double.Parse(Console.ReadLine());
            Console.Write("사회 성적: ");
            scores[4] = double.Parse(Console.ReadLine());

            double sum = scores.Sum();
            Console.WriteLine("총점: " + sum);
            double avg = scores.Sum() / scores.Length;
            Console.WriteLine("평균: " + avg);



        }
    }
}
