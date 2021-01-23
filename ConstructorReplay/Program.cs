using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorReplay
{
    class Program
    {
        static void Main(string[] args)
        {

            //Deneme deneme = new Deneme("fsadf","fsfs");
            //deneme.BilgiYaz();
            //deneme._a = "f";
            //deneme._b = "b";
            //deneme.BilgiYaz();

            //A a = new A();
            //A a = new A(3);

            //C c = new C(5, 6, 7);
            //c.Yaz();
            #region Constructor
            //Constructorlı
            Manager manager = new Manager(new Sınıf());
            manager.DegerYaz();
            //Değer atamayla
            CustomerManager customerManager = new CustomerManager();
            customerManager.deger = new Motor();
            customerManager.Yazdir();

            Deneme deneme = new Deneme("Ferit", "Görken");
            deneme.DegerYaz();

            A a = new A(5);

            C c = new C(10, 12, 14);

            #endregion

            Console.ReadLine();
        }
    }
    class Sınıf : IDeger
    {
        public void Yaz()
        {
            Console.WriteLine("Sınıf");
        }
    }
    class Motor : IDeger
    {
        public void Yaz()
        {
            Console.WriteLine("Motor");
        }
    }
    interface IDeger
    {
        void Yaz();
    }
    class Manager
    {
        public IDeger _deger;
        public Manager(IDeger deger)
        {
            _deger = deger;
        }
       public void DegerYaz()
        {
            _deger.Yaz();
        }
    }
    class CustomerManager
    {
        public IDeger deger;
        public void Yazdir()
        {
            deger.Yaz();
        }
    }

    class Deneme
    {
        public string text1;
        public string text2;
        public Deneme(string yazi1,string yazi2)
        {
            text1 = yazi1;
            text2 = yazi2;
        }
        public Deneme()
        {

        }
        public void DegerYaz()
        {
            Console.WriteLine(text1 + " ***** " + text2);
        }
    }
    //base ile classlar arasında constructorda gezilir.
    //ilk base metodunu yazar sonra child yazılır ata b child a
    class A :B
    {
        public A()
        {

        }
        public A(int x):base(x) 
        {
            Console.WriteLine("A classı Value: {0}", x); 
        }
    }
    class B
    {
        public B()
        {

        }
        public B(int y)
        {
        Console.WriteLine("B classı Value: {0}", y);
        }
    }
    //This kendi içindeki constructorda dolaşmayı sağlar.
    class C
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public C(int x)
        {
            this.x = x;
            Console.WriteLine("x degeri: {0}", x);
        }
        public C(int y,int z)
        {
            this.y = y;
            this.z = z;
        }
        public C(int x, int y, int z) : this(x)
        {
            Console.WriteLine("Degerler: {0}-{1}-{2}", x, y, z);
        }
    }
    //Base classın contructorı parametreliyse onun constructırına değer göndermek zorundayız.
    class X : Y   
    {
        private int x;
        public X(int x):base(x)
        {
            this.x = x;
        }
    }
    class Y
    {
        private int y;
        public Y(int y)
        {
            this.y = y;
        }
    }
    
}
