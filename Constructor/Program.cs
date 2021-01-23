using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sınıf sınıf = new Sınıf(10);
            //sınıf.DegerYaz();

            Manager manager = new Manager(new Oracle());
            manager.Log();


            Employee employee = new Employee();
            employee.logger = new Oracle();
            employee.Log();

            Console.ReadLine();
        }
    }
    class Sınıf
    {
        public int _id=5;
        public Sınıf(int id)
        {
            _id = id;
        }
        public Sınıf()
        {

        }
        public void DegerYaz()
        {
            Console.WriteLine("Değer {0}", _id);
        }
    }
    interface Logger
    {
        void ILogger();
    }
    class Database : Logger
    {
        public void ILogger()
        {
            Console.WriteLine("Logged database");
        }
    }
    class Oracle : Logger
    {
        public void ILogger()
        {
            Console.WriteLine("Logged Oracle");
        }
    }
    class Manager
    {
        private Logger logger;
        public Manager(Logger _logger)
        {
            logger = _logger;
        }
        public void Log()
        {
            logger.ILogger();
            Console.WriteLine("Add");
        }
    }

    class Employee
    {
        public Logger logger;
      
        public void Log()
        {
            logger.ILogger();
            Console.WriteLine("Add");
        }
    }
}
