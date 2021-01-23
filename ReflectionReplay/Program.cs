using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionReplay
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Reflection

            var type = typeof(Sınıf);
            var instance = Activator.CreateInstance(type);
            var constructorinstance = Activator.CreateInstance(type, 5, 6);

            object[] values = new object[]
            {
                5,6
            };

            var topla = instance.GetType().GetMethod("Topla").Invoke(instance, values);
            Console.WriteLine("Toplam Reflection Method Result: {0}", topla);
            var multiple = constructorinstance.GetType().GetMethod("Multiple").Invoke(constructorinstance, values);
            Console.WriteLine("Çarpım Reflection Method Result: {0}", multiple);

            
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla");
            Console.WriteLine("Toplam Sonuc:{0}",methodInfo.Invoke(instance, values));

            //instance.GetType().GetMethod == type.GetMethod();
            instance.GetType().GetMethod("Yaz").Invoke(instance, null);
            type.GetMethod("Yaz").Invoke(instance, null);//aynı işleve sahip

            var metodlar = type.GetMethods();
            foreach (var info in metodlar)
            {
                Console.WriteLine("MetodAdı : {0}", info);
                foreach (var item in info.GetParameters())
                {
                    Console.WriteLine("Parametreler {0}", item);
                }
            }
            #endregion
            Console.ReadLine();
        }
    }
    class Sınıf
    {
        public int _a { get; set; }
        public int _b { get; set; }
        public Sınıf(int a,int b)
        {
            _a = a;
            _b = b;
        }
        public Sınıf()
        {
                
        }
        public int ad { get; set; }
        public void Yaz()
        {
            Console.WriteLine("Yaz Metodu Çalıştırıldı.");
        }
        public int Topla(int a,int b)
        {
            return a + b;
        }
        public int Multiple(int a,int b)
        {
            return a * b;
        }
    }
}
