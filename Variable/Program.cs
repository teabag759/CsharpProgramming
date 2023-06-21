using System;

namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string appleCountDescription = "바구니 안에 담긴 사과의 개수: ";
            Console.Write(appleCountDescription);
            int appleCount = 12;
            Console.WriteLine(appleCount);

            appleCount = appleCount - 2;
            appleCountDescription = "내가 먹고 난 뒤에 " + appleCountDescription;

            Console.Write(appleCountDescription);
            Console.WriteLine(appleCount);


            //#################### Wrong Variable ########################

            int appleCount02 = 12;
            //10 = appleCount;
            int pearCount;

            Console.WriteLine(appleCount02);
            //Console.WriteLine(pearCount);
                // 변수에 값을 넣지 않고 사용하면 오류!
        }
    }
}
