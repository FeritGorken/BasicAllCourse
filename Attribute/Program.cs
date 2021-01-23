using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 5,
                Yas = 5,
                LastName="Görken"
            };
            CustomerDal customerDal = new CustomerDal();
            //customerDal.Add(customer);
            Console.ReadLine();
        }
    }
   // [ToTable("Customers")]//hangi tablo
    class Customer
    {
        public int Id { get; set; }
    //    [RequiredProperty]//zorunlu
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Yas { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("bunu kullanma")]//mesaj gösterme
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3}",customer.Id,customer.FirstName,customer.LastName,customer.Yas);
        }
    }

    //allowmultiple birden fazla kullanmayı sağlar
   // [AttributeUsage(AttributeTargets.All|AttributeTargets.Property,AllowMultiple =true)] //Require property hepsine gelir, .class yazarsak classlarda çalışır
    //class RequiredPropertyAttribute:Attribute
    //{

    //}

    //class ToTableAttribute:Attribute
    //{
    //    private string _tableName;
    //    public ToTableAttribute(string tableName)
    //    {
    //        _tableName = tableName;
    //    }
    //}
}
