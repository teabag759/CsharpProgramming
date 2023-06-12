using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass_Overriding
{
    public class Dog
    {
        virtual public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }

    public class Pudle : Dog
    { 
        public override void Bark() 
        {
            Console.WriteLine("왈왈");
        }
    }

    class Program
    { 
        static void Main(string[] args) 
        {
            Pudle pd = new Pudle();
            pd.Bark();

            Dog dog = new Dog();
            dog.Bark();

            dog = new Pudle();
            dog.Bark();
        }
    }
}
