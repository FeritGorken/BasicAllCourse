using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor motor = new Motor();
            motor.Add();
            motor.Deger();
            
            Console.ReadLine();
        }
    }
   abstract class Sınıf
    {
        //abstract olmayan ve olan kullanılır.
        public void Add()
        {
            Console.WriteLine("add");
        }
        public abstract void Deger();

    }
    class Motor : Sınıf
    {
        public new void Add()
        {
            base.Add();
            Console.WriteLine("dadas");
        }
        public override void Deger()
        {
            Console.WriteLine("fsdf");
        }
    }

    class deg
    {
        public static void Yaz()
        {
            Console.WriteLine("fsdf");
        }
    }
}
