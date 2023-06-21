using System;


namespace ConsoleWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 여기에 코드를 작성합니다. 
            Console.WriteLine("WriteLine을 쓰면");
            Console.WriteLine("한 줄씩 나옵니다.");
            Console.Write("Write는 아닙니다.");
            Console.Write("이어져서 나오죠?");
                // Write() 함수는 출력 뒤에 새 줄을 만들지 않음.
            Console.WriteLine("WriteLine 뒤에 Write를 썼습니다.");

            Console.Write("바구니 안에 담긴 사과의 개수: ");
            Console.WriteLine(12);

            Console.Write("사과 바구니의 무게: ");
            Console.WriteLine(1.32);

            Console.WriteLine("!!?%$&");
            
            Console.WriteLine("큰따옴표 \" 출력");
        }
    }
}

