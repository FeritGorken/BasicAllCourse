using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("fsaf", "fsafsad"); //T string
            //int[] sa = new int[]{ 4,5};
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> data = utilities.BuildList<Customer>(
                new Customer
                {
                    FirstName = "fsaf"
                },
                new Customer
                {
                    FirstName = "fsfd"
                }
            );
            foreach (var item in data)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
    //T sadece class olabilir string fln yazılmaması için,
    //classlar newlenebilir olduğu için new koyuldu,
    //IEntityden referans alınan classlar olabilir
    interface IGenericRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Update(T entity);
        bool Remove(int id);
        T Get(int id);
    }
    interface IEntity
    {

    }
    class Customer:IEntity//IGenericRepositoryde belirtildiği gibi IEntityden kalıtım alan classlar gönderiliyor
    {
        public string FirstName { get; set; }
    }
    class Product:IEntity
    {
        public string FirstName { get; set; }
    }
    interface IProductDal:IGenericRepository<Product>//T Product
    {

    }
    interface ICustomerDal : IGenericRepository<Customer>
    {
        void Yaz();//Ya generictekileri yada customer için özel metod yazmak için interfaceler kullanılır.
    }
    class CustomerManager : ICustomerDal
    {
        public Customer Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Yaz()
        {
            throw new NotImplementedException();
        }
    }
    class ProductManager : IProductDal
    {
        public Product Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }



}
