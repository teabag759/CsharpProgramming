using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Dog
    {
        protected int eyes, nose, mouth, ears;
        protected string kind;

        public void Bark()
        {
            Console.WriteLine("멍멍");
        }

        public void PudleInfo()
        {
            Console.WriteLine("눈 : {0}", eyes);
            Console.WriteLine("코 : {0}", nose);
            Console.WriteLine("입 : {0}", mouth);
            Console.WriteLine("귀 : {0}", ears);
            Console.WriteLine("종류 : {0}", kind);
        }
    }

    public class Pudle : Dog
    {
        public Pudle()
        {
            eyes = 2;
            nose = 1;
            mouth = 1;
            ears = 2;
            kind = "푸들";
        }
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
