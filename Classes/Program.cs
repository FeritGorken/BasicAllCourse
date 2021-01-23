using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer
            {
                Id = 10
            };
            Customer cust = new Customer();
            cust.Id = 15;
            Console.WriteLine(cust.Id);
            List<string> data = new List<string>() { "fsaf", "gfsadfd", "fasdfa" };
            var deger = data.Any(x => x.Contains("fsaf"));
            Console.WriteLine(deger);
            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Id { get; set; }
    }
}
