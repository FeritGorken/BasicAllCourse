using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //tip alınır,instance oluşturulur,Gettype ile tip alınıp içindeki metod alınır,invoke ile çalıştırılır.
            //DortIslem dortIslem = new DortIslem(2, 6);
            //Console.WriteLine(dortIslem.Topla(5, 6));
            //Console.WriteLine(dortIslem.Topla2());

            var tip = typeof(DortIslem);
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,4,7);
            //Console.WriteLine(dortIslem.Topla(5, 1));
            var instance = Activator.CreateInstance(tip, 4, 7);
            object[] data=new object[]{ 5,5};
            Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance,null));
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla");
            Console.WriteLine(methodInfo.Invoke(instance, data));

            var metodlar = tip.GetMethods();
            foreach (var info in metodlar)
            {
                Console.WriteLine("MetodAdı : {0}", info);
                foreach (var item in info.GetParameters())
                {
                    Console.WriteLine("Parametreler {0}", item);
                }
            }


            Console.ReadLine();
        }
    }
    class DortIslem
    {
        public int _sayi1;
        public int _sayi2;
     
        public DortIslem(int first,int second)
        {
            _sayi1 = first;
            _sayi2 = second;
        }
        public int Topla(int a,int b)
        {
            return a + b;
        }
        public int Topla2()
        {
            return _sayi1 +_sayi2;
        }
        public int Carp(int a, int b)
        {
            return a * b;
        }
        public int Bol(int a, int b)
        {
            return a / b;
        }
        public int Cikar(int a, int b)
        {
            return a - b;
        }
    }
}
