using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] st = new string[3];
            ////her tipi alır
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("fsadfa");
            //arrayList.Add(5);
            //arrayList.Add(true);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //List<Sınıf> sınıfs = new List<Sınıf>()
            //{
            //    new Sınıf
            //    {
            //        ayak=5,
            //        kisi=10
            //    },
            //    new Sınıf
            //    {
            //        ayak=2,
            //        kisi=8
            //    }
            //};
            //foreach (var item in sınıfs)
            //{
            //    Console.WriteLine(item.kisi + "" + item.ayak);
            //}
            Sınıf sınıf = new Sınıf()
            {
                ayak = 10,
                kisi = 8
            };
            var data = GetSınıfs(sınıf);
            foreach (var item in data)
            {
                Console.WriteLine(item.ayak);
            }
            Console.ReadLine();
        }
        static List<Sınıf> GetSınıfs(Sınıf sınıf)
        {
            List<Sınıf> sınıfs = new List<Sınıf>()
            {
                new Sınıf
                {
                    ayak=sınıf.ayak,
                    kisi=sınıf.kisi
                }
            };
            return sınıfs;
        }
    }
    class Sınıf
    {
        public int ayak { get; set; }
        public int kisi { get; set; }
    }
}
