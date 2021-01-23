using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //object lerde cast işlemi uygulanır.
            //object a = 5;
            //int b = (int)a;
            //Console.WriteLine(b);

            //dynamic a = 5;
            //int b = a;
            //Console.WriteLine(b);

            //var a = 5;
            //int b = a;
            //Console.WriteLine(b);
            string c = "5";
            int y;
            //int x = Int32.Parse(c);
            //int x = Convert.ToInt32(c);
            bool x = Int32.TryParse(c, out y);
            Console.WriteLine(x);


            //string a = Console.ReadLine();
            //Console.WriteLine("Değer:{0}",a);

            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Girilen değer: {0}",a);

            //double fd = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("değer : {0}", fd);

            if (day.monday == 0)
            {
                Console.WriteLine("doğru");
            }

            Console.WriteLine(Enum.Parse(typeof(day),"1"));
            //Parse ederken aynı isimde olmalı, index değeri verirken o indexe ait değer varsa onu döndürür
            //yoksa numarayı döndürür.
            Console.WriteLine(Enum.GetName(typeof(day),3)); //indexe göre değerini getirir. Değeri yoksa boş gösterir.
            Console.WriteLine(day.tuesday); //tuesday yazar
            Console.WriteLine((int)day.tuesday); //index değerini verir

            Console.WriteLine(day.monday.ToString("d")); //index değerini verir

            string[] sc = Enum.GetNames(typeof(day));
            foreach (var item in sc)
            {
                Console.WriteLine(item); //değerleri tek tek döndürür.
            }

            Console.ReadLine();
        }

       
    }
    enum day
    {
        monday,tuesday=2,sunday,wednesday
    }
}
