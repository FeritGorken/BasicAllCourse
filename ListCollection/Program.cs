using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Dizi - List
            int[] sayilar = new int[3];
            sayilar[0] = 5;
            sayilar[1] = 5;
            sayilar[2] = 5;
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********************************");
            List<int> numbers = new List<int>(sayilar);
            numbers.Add(4);
            numbers.Add(4);
            numbers.Add(4);
            numbers.Add(4);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Remove(5);
            numbers.RemoveAt(5);
            numbers.BinarySearch(5);//hangi indexde
            Console.WriteLine("***********************************");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            #endregion


            #region ListCollection
            List<Customer> customers = new List<Customer>()
            {
                new Customer
                {
                    Id=1,
                    Kodu=1
                },
                new Customer
                {
                    Id=2,
                    Kodu=2
                }
            };
            foreach (var item in customers)
            {
                Console.WriteLine("Id: "+item.Id + " ******** " + "Kodu: "+item.Kodu);
            }

            var customer = new Customer[]
            {
                new Customer
                {
                    Id=6,
                    Kodu=7
                },
                new Customer
                {
                    Id=8,
                    Kodu=9
                }
            };
            customers.AddRange(customer);
            Console.WriteLine("AddRanged List");
            foreach (var item in customers)
            {
                Console.WriteLine("Id: " + item.Id + " ******** " + "Kodu: " + item.Kodu);
            }

            List<Customer> cst = customers.Where(a => a.Id == 1).ToList();
            Console.WriteLine(cst.Capacity);

            #endregion


            Console.ReadLine();


        }
    }
    class Customer
    {
        public int Id { get; set; }
        public int Kodu { get; set; }
    }
}
