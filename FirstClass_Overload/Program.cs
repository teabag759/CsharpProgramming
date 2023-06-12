using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass_Overload
{
    public class Zerg
    {
        public void Overload(int zerggling)
        {
            Console.WriteLine("저글링 {0} 마리", zerggling);
        }
        
        public void Overload(int zerggling, int hydra)
        {
            Console.WriteLine("저글링 {0} 마리 + 히드라 {0} 마리", zerggling, hydra);
        }

        public void Overload(int zerggling, int hydra, int lurker)
        {
            Console.WriteLine("저글링 {0} 마리 + 히드라 {0} 마리 + 럴커 {0} 마리", zerggling, hydra, lurker);
        }

        public void Overload(char zerggling)
        {
            Console.WriteLine("Zerggling {0} 등급", zerggling);
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            Zerg zerg = new Zerg();
            zerg.Overload(10);
            zerg.Overload(10, 20);
            zerg.Overload(10, 20, 30);
            zerg.Overload('A');
        }
    }
}
