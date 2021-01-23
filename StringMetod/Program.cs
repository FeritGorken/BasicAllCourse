using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Metods
            string sentences = "ferit gorken Spidya Developer";
            string[] deneme = { "ferit", "görken", "spidya", "developer" };
            string test = "deneme";
            string tester = "test";
            string tstr = "test";
            string tst = "                     test                   ";
            string e = "e";
            string r = "r";
            string d = "r";
            Console.WriteLine(string.Compare(e, r)); // e nin değer sıralaması e<r olduğu için -1
            Console.WriteLine(string.Compare(r, e)); // r değeri e den büyük r>e olduğu için 1
            Console.WriteLine(string.Compare(r, d)); // r ile d eşit sırada olduğu için 0
            bool res = Array.Exists(deneme, y => y == "ferit");
            Console.WriteLine("Array exist Result: {0}", res);//true flase
            var clone = test.Clone();
            Console.WriteLine($"Clone Result: {clone}"); //kelimeyi klonlar
            var contains = test.Contains("d");
            Console.WriteLine("Contains Result: {0}", contains); //true false
            var endswith = tester.EndsWith("st");
            Console.WriteLine("EndsWith Result: {0}", endswith);//true false
            var startswith = tstr.StartsWith("te");
            Console.WriteLine("StartsWith Result: {0}", startswith);//true false
            var lastindexsof = test.LastIndexOf("e");
            Console.WriteLine("Last Index Of Result: {0}", lastindexsof);//index numarasını verir.aynı harften varsa en sonra olanı baz alır.
            var indexsof = test.IndexOf("m");
            Console.WriteLine("IndexsOf Result: {0}", indexsof); // değer varsa index numarsını verir aynı harften var ise ilk olanı baz alır.yoksa -1 atar
            var insert = test.Insert(0, "Inserted Value ");
            Console.WriteLine("Inserted Result: {0}", insert);//verilen indexten sonra değer ekler
            var substring = test.Substring(0,3);
            Console.WriteLine("Substring Result: {0}", substring);//ilk değer hangi indexden başlanacağı ikincisi uzunluk o aralığı alır ekrana basar, Tek değer verilir o indexten başla gerisini al ekrana bas
            var remove = test.Remove(0,3);
            Console.WriteLine("Remove Result: {0}", remove); //ilk deger hangi indexten başlanacağı ikincisi uzunluk o aralığı siler geri kalanı basar,Tek değer verirsen indexden başlanır ekrana basılır
            var tolower = test.ToLower();
            Console.WriteLine("ToLower Result: {0}", tolower); // küçültür.
            var toupper = test.ToUpper();
            Console.WriteLine("ToUpper Result: {0}", toupper); //büyütür.
            var concat = string.Concat(test, tester);
            Console.WriteLine("Concat Result: {0}", concat);//Birleştirir.
            var equals = string.Equals(tstr, tester);
            Console.WriteLine("Equals Result: {0}", equals); // yazılar eşitmi aynı mı 
            var join = string.Join(",", deneme);
            Console.WriteLine("Join Result: {0}", join);//aralarına virgül koyar.
            var reverse = test.Reverse();
            foreach (var item in reverse)
            {
                Console.Write(item);//tersten yazar.
            }
            Console.WriteLine();
            string[] split = sentences.Split(' ');
            foreach (var item in split)
            {
                Console.WriteLine(item);
            }
            var trim = tst.Trim(' ');//boşlukları trimler
            Console.WriteLine("Trim Result: {0}", trim);
            
            #endregion

            Console.ReadLine();
        }
    }
}
