using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ListCollections
            List<Customer> customers = new List<Customer>()
            {
                new Customer
                {
                    id=1,
                    kodu=2
                },
                new Customer
                {
                    id=3,
                    kodu=4
                }
            };
            var cst = new Customer[]
            {
                new Customer
                {
                    id=5,
                    kodu=6
                },
                new Customer
                {
                    id=7,
                    kodu=8
                }
            };
            customers.AddRange(cst);
            foreach (var item in customers)
            {
                Console.WriteLine(item.id + " ***** " + item.kodu);
            }
            //customers.Clear();//Listeyi temizler
            Console.WriteLine("Count: {0}", customers.Count);
            Console.WriteLine("********");
            var cust = customers.Contains(new Customer { id = 1, kodu = 2 }); //içeriyor mu -> false verir çünkü adresine gidip bulması gerek.
            Console.WriteLine("Contains: {0}", cust);
            Console.WriteLine("********");
            var cus = new Customer
            {
                id = 1,
                kodu = 2
            };
            Console.WriteLine(customers.IndexOf(cus));//kaçıncı indexte yer alıyor
            Console.WriteLine("********");
            var csts = new Customer
            {
                id = 1,
                kodu = 3
            };
            customers.Insert(0, csts);//verilen index değerine ekle
            foreach (var item in customers)
            {
                Console.WriteLine(item.id + " ***** " + item.kodu);
            }
            Console.WriteLine("********");
            customers.Remove(csts);//kaldır
            foreach (var item in customers)
            {
                Console.WriteLine(item.id + " ***** " + item.kodu);
            }
            Console.WriteLine("********");
            customers.RemoveAll(x => x.id == 5);//id si 5 olanın hepsini kaldır
            customers.RemoveAt(0);//verilen indexteki datayı siler
            #endregion
            Console.ReadLine();

        }
    }
    class Customer
    {
        public int id { get; set; }
        public int kodu { get; set; }
    }
}
