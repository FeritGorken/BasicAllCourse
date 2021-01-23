using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractReplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Sınıf sınıf = new Customer();//customer sınıfı kalıtım aldığı için sınıf tipindedir.
            Motor.Data();
        }

    }
    abstract class Sınıf
    {
        //abstract olmayan class içinde abstract metod tanımlayamayız, abstract olan class ta abstract ve abstract olmayan metod tanımlanır
        public void Degeryaz()
        {
            Console.WriteLine("Test");
        }
        public abstract void Yaz();
    }
   
    class Motor
    {
        //static class olup static olmayan metod tanımlayamayız.static class olmayıp içinde static metod tanımlarız
        public static void Data()
        {
            Console.WriteLine("Test");
        }

    }
    class Customer : Sınıf
    {
        public override void Yaz()
        {
            Console.WriteLine("Test");
        }
    }

}
