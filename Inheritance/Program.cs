using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance
            Sınıf sınıf = new Sınıf
            {
                Id = 1,
                Kodu = 2
            };
            sınıf.DegerYaz();

            Okul okul = new Okul();
            okul.Id = 2;
            okul.Kodu = 3;
            okul.DegerYaz();


            Motor[] motor = new Motor[]
            {
                new Araba()
                {
                    ArabaId=5,
                    Beygir=8
                },
                new Otobus()
                {
                    MotorId=6,
                    Beygir=9
                }
            };
            Araba araba = new Araba
            {
                ArabaId = 6,
                Beygir=7
            };
            Console.WriteLine("Araba ID: {0} Araba Beygir: {1}", araba.ArabaId, araba.Beygir);
            Console.WriteLine("Beygir: " + araba.Beygir);
            foreach (var item in motor)
            {
                Console.WriteLine("Kalıtım Alınan Foreach Result: {0}",item.Beygir);//Motordan Kalıtım alınan değerleri döndük
            }

            #endregion
            Console.ReadLine();

        }
    }

    class Sınıf
    {
        public int Id { get; set; }
        public int Kodu { get; set; }

        public void DegerYaz()
        {
            Console.WriteLine("Sınıf Metodu Deger Yaz");
        }
    }
    class Okul
    {
        public int Id { get; set; }
        public int Kodu { get; set; }

        public void DegerYaz()
        {
            Console.WriteLine("Okul Metodu Deger Yaz");
        }
    }
    class Araba:Motor
    {
        public int ArabaId { get; set; }
    }
    class Otobus:Motor
    {
        public int MotorId { get; set; }
    }
    class Motor
    {
        public int Beygir { get; set; }
    }
}
