using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeReplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                id = 5,
                ayak = 10,
                kodu = 8
                //bacak = 5
            };
        }
    }
    [ToTable("Customers")]
    class Customer
    {
        [RequiredProperty]
        public int id { get; set; }
        public int kodu { get; set; }
        public int ayak { get; set; }
        [Obsolete("Bunu Kullanmayın")] //Uyarı verdirtir bilgiyi yazar
        public int bacak { get; set; }
    }
    class ToTableAttribute : Attribute
    {
        private string v;
        public ToTableAttribute(string v)
        {
            this.v = v;
        }
    }

    //Attributeusage nerede kullanılsın->constructor ve hepsinde diye tanımladım,Allowmultiple çoklu kullanılsın mı ayarı
    [AttributeUsage(AttributeTargets.All | AttributeTargets.Constructor,AllowMultiple =true)]
    class RequiredPropertyAttribute : Attribute
    {

    }

}
