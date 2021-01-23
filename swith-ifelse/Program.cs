using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swith_ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            #region switch
            //switch (a)
            //{
            //    case 3:
            //        Console.WriteLine("Değer {0}", a);
            //        break;
            //    case 4:
            //        Console.WriteLine("Değer {0}", a);
            //        break;
            //    case 5:
            //        Console.WriteLine("Değer {0}",a);
            //        break;
            //    case 6:
            //        Console.WriteLine("Değer {0}", a);
            //        break;
            //    case 7:
            //        Console.WriteLine("Değer {0}", a);
            //        break;
            //    case 8:
            //        Console.WriteLine("Değer {0}", a);
            //        break;
            //    default:
            //        Console.WriteLine("yanlıs");
            //        break;

            //}
            #endregion
            #region if-else
            // if(a==2)
            // {
            //     Console.WriteLine("Değer {0}", a);
            // }
            // else if (a == 3)
            // {
            //     Console.WriteLine("Değer {0}", a);
            // }
            // else if (a == 4)
            // {
            //     Console.WriteLine("Değer {0}", a);
            // }
            //else if (a == 5)
            // {
            //     Console.WriteLine("Değer {0}", a);
            // }
            // else
            // {
            //     Console.WriteLine("Değer başka");
            // }
            #endregion
            //Console.WriteLine(a < 4 ? "fdsf":"fdsfa");
            Console.WriteLine(a < 10 ? "test" : a == 15 ? "deneme" : "tester");
            Console.ReadLine();

        }
    }
}
