using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateReplay
{
    public delegate int ReturnDelegateInt(int x, int y);
    public delegate void VoidDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            #region Delegate
            Employee employee = new Employee();
            ReturnDelegateInt returnDelegate = employee.Topla;
            //returnDelegate += employee.Carp;
            Console.WriteLine(returnDelegate(4, 5));

            VoidDelegate voidDelegate = employee.DegerYaz;
            voidDelegate += employee.Yaz;
            voidDelegate();
            #endregion


            Console.ReadLine();
        }
      
    }
    class Employee
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }
        public int Carp(int a, int b)
        {
            return a * b;
        }
        public void Yaz()
        {
            Console.WriteLine("Yaz");
        }
        public void DegerYaz()
        {
            Console.WriteLine("DegerYaz");
        }
    }
}
