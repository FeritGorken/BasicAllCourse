using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Topla(6, 4));
            //1. parametre,2.parametre,3.dönüş tipi
            //Func<int, int, int> add = Topla;
            //Console.WriteLine(add(1, 2));

            //parametresiz ama int döndürür
            Func<int> getRandomMetod = delegate ()
              {
                  Random random = new Random();
                  return random.Next(1, 100);
              };
            Console.WriteLine(getRandomMetod());
            Console.ReadLine();


        }
        static int Topla(int x,int y)
        {
            return x + y;
        }
    }
}
