using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionClass
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Extension
            char[] dizi = "ferit".KarakterlereCevir();
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            int sayi1 = 5;
            int sayi2 = "45".TamSayiCevir();
            int res = sayi1 + sayi2;
            Console.WriteLine("Sonuc: {0}" , res);
            int sayi3 = 7.5.TamSayiCevir();
            Console.WriteLine(sayi3);



            #endregion
            Console.ReadLine();
        }
    }
    static class Extensions
    {
        public static char[] KarakterlereCevir(this string text)
        {
            char[] chars = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                chars[i] = text[i];
            }
            return chars;
        }
        public static int TamSayiCevir(this object val)
        {
            int result = Convert.ToInt32(val);
            return result;
        }
    }
}
