﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            //int[] sayi = new int[2];
            //sayi[0] = 5;
            //sayi[1] = 2;
            //int[] sayi = { 4, 5, 6, 1, 5 };
            //foreach (var item in sayi)
            //{
            //    toplam += item;
            //}
            int[] ss = new int[] { 4, 54, 5 };
            int[] sss = new int[3] { 4, 54, 5 };
            string[] str = { "fsdaf", "gsdgf", "sdgf" };
            foreach (var item in str)
            {

                Console.WriteLine(item);
            }

            #region Çok Boyutlu Dizi
                               //0          //1          //2
                            //0  1  2    //0  1  2    //0  1  2
            int[,] dizi = { { 4, 5, 6 }, { 7, 8, 9 }, { 1, 2, 3 } };
            Console.WriteLine(dizi[2,1]);

                                              //0                                        //1
                                 //0          //1          //2              //0          //1          //2
                              //0  1  2    //0  1  2    //0  1  2        //0  1  2    //0  1  2    //0  1  2
            int[,,] arr = { { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, { { 7, 8, 9 }, { 4, 5, 6 }, { 3, 2, 1 } } };
            //mantık 0,1,2 diye ayırırken ona göre paranteze almak 
            #endregion

            Console.ReadLine();
        }
    }
}
