using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Params-ref-default parameters
            #region Ref-Out

            int sayi1 = 5;
            int sayi2 = 10;
            Console.WriteLine("Sayi 1: {0}", sayi1);
            //refte başlangıç değeri atamak zorunda, outta başlangıç değer atanmaasına gerek yoktur.
            //outta seçime bağlı ister atanır ister atanmaz ama refte zorunlu
            Swap(ref sayi1, sayi2);
            Console.WriteLine("Sayi 1: {0}", sayi1);

            #endregion
            #region Params
            int[] values = new int[]
            {
                1,2,3,4,5,6,7,8,9
            };
            int[] degerler = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = Topla(values);
            Console.WriteLine("Params Metod Result: {0}",result);
            #endregion
            #region Default Parameter
            int sonuc = Multiple(sayi1, sayi2);
            Console.WriteLine("Default Parameter Result: {0}", sonuc);
            //değer girilmişse onu kabul eder girilmemişse metoddakini kabul eder.
            #endregion
            #endregion
            Console.ReadLine();

        }
        #region Ref-Out Metod
        static void Swap(ref int a, int b)
        {
            a = 8;
        }
        #endregion
        #region Params Metod
        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += item;
            }
            return toplam;
        }
        #endregion
        #region Default Parameter Metod
        static int Multiple(int a,int b=5)
        {
            return a * b;
        }
        #endregion
    }

}
