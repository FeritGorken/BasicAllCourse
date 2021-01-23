using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //ulaşmak için
            var customerManager = CustomerManager.CreateSingleton();
            //işlemler
            customerManager.Save();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        //nesnenin önceden oluşup oluşmadığını kontrol edicem
        //daha önceden oluşturulmuşu varsa onu döndür yoksa yeni oluştur
        //static olur
        private static CustomerManager _customerManager;


        //thread kontrolü yapma
        //nesneyi üretmek isteyeni kitle işlemi yapsın sonra diğer threade geçsin
        static object _lockObject = new object();


        //private contructor oluştur
        //constructor olup dışardan erişilemez
        private CustomerManager()
        {

        }
        //singleton örneği metodu static olur
        //kendisini döndürür
        //private olduğu için burdan ulaşabilir hale getiriyoruz
        public static CustomerManager CreateSingleton()
        {
            //customer manageriin bir kere üretildiğinden emin olma
            //thread 2 taraftan aynı anda dublice nesneyi üretmesin diye
            lock(_lockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }
           
            return _customerManager;

            //diğer yazımı
            //null değilse customer manager döndür null ise yeni customer manager döndür
            //return _customerManager ?? (_customerManager = new CustomerManager());
        }
        //Business Metodu static yazmamaya tercih edilir.
        //create as singletondan buraya ulaşıldı.
        public void Save()
        {
            Console.WriteLine("Save");
        }
    }
}
