using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IProductDal>().To<ProductDal>().InSingletonScope();
            ProductManager productManager = new ProductManager(kernel.Get<IProductDal>());
            //ProductManager productManager = new ProductManager(new ProductDal());
            productManager.Save();
            Console.ReadLine();
        }
    }
    interface IProductDal
    {
        void Save();
    }
    class ProductDal:IProductDal
    {
        public void Save()
        {
            Console.WriteLine("fsda");
        }
    }
    class ProductManager
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Save()
        {
            //newleyerek bağlanmamak gerekli
            //ProductDal productDal = new ProductDal();
            _productDal.Save();
        }
    }
}
