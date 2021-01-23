using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncsReplay
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Func
            //1. parametre,2.parametre,3.dönüş tipi
            //Topla 2 parametre alıyor ondan iki tane yazıldı 3. de dönüş tipi oldu
            Func<int, int, int> func = Topla;
            Console.WriteLine(func(2, 3));

            //return değeri int olduğu için func int değeri aldı.
            Func<int> getRandom = delegate ()
            {
                Random random = new Random();
                return random.Next(1,100);
            };
            Console.WriteLine(getRandom());

            //1. parametre,2.parametre,3.dönüş tipi
            Func<int, int, int> funcGetRandem = delegate (int a, int b)
                {
                    Random random = new Random();
                    return random.Next(a, b);
                };
            Console.WriteLine(funcGetRandem(2, 8));
            #endregion



            Console.ReadLine();
        }
        static int Topla(int a,int b)
        {
            return a + b;
        }
    }
}
