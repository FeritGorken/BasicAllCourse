using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    public delegate void MyDelegate();
    public delegate void MyDelegate2(string data);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessages();
            //customerManager.ShowAlert();


            MyDelegate myDelegate = customerManager.SendMessages;
            myDelegate += customerManager.ShowAlert;
           // myDelegate -= customerManager.ShowAlert;
            myDelegate();


            MyDelegate2 myDelegate2 = customerManager.careAlert;
            myDelegate2("ferit");


            Console.ReadLine();
        }

      
    }
    class CustomerManager
    {
        public void SendMessages()
        {
            Console.WriteLine("send");
        }
        public void ShowAlert()
        {
            Console.WriteLine("alert");
        }

        public void careAlert(string text)
        {
            Console.WriteLine("text   ----   {0}",text);
        }


    }
}
