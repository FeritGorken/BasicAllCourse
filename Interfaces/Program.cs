using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Interfaces
            IBaseRepository deger = new Araba();
            deger.DegerYaz();
            IBaseRepository[] baseRepositories = new IBaseRepository[2]
            {
                new Araba(),
                new Otobus()
            };
            IBaseRepository[] baseRepository = new IBaseRepository[]
            {
                new Araba(),
                new Otobus()
            };
            foreach (var item in baseRepository)
            {
                item.DegerYaz();
            }

            BaseClass baseClass = new BaseClass();
            baseClass.Yazdir(new Araba());

            BaseStaticClass.Yazdir(new Otobus());
            #endregion
            Console.ReadLine();
        }
    }
 
    interface IBaseRepository
    {
        void DegerYaz();
    }
    class Araba : IBaseRepository
    {
        public void DegerYaz()
        {
            Console.WriteLine("Araba Class Work");
        }
    }
    class Otobus : IBaseRepository
    {
        public void DegerYaz()
        {
            Console.WriteLine("Otobüs Class Work");
        }
    }


    class BaseClass
    {
        public void Yazdir(IBaseRepository baseRepository)
        {
            baseRepository.DegerYaz();
        }
    }
    static class BaseStaticClass
    {
        public static void Yazdir(IBaseRepository baseRepository)
        {
            baseRepository.DegerYaz();
        }
    }

}
