using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Dog
    {
        protected int eyes, noes, mouse, ears;
        protected string kinds;
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }

    public class Pudle : Dog
    {
        public Pudle()
        {
            base.eyes = 2;
            base.noes = 1;
            base.mouse = 1;
            base.ears = 2;
            base.kinds = "푸들";
        }
    }

    public void PudleInfo()
    {
        Console.WriteLine("눈 : {0}", base.eyes);
        Console.WriteLine("코 : {0}", base.noes);
        Console.WriteLine("입 : {0}", base.mouse);
        Console.WriteLine("귀 : {0}", base.ears);
        Console.WriteLine("종류 : {0}", base.kinds);
    }

    class Program
    { 
        static void Main(string[] args) 
        {
            Pudle pd = new Pudle();
            pd.PudleInfo();
            pd.Bark();
        }
    }
}
