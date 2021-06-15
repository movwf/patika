using System;
using System.Collections.Generic;
using System.Text;

namespace Sayilar
{
    public class Diziler
    {
        public static int[] Olustur(int limit)
        {
            int[] dizi = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                dizi[i] = new Random().Next(1,100);
                Console.Write("Eklenen sayi : {0,5}\n",dizi[i]);
            }
            return dizi;
        }
        /// <summary>
        /// Dizinin 0. elamanini tekrarli bir sekilde
        /// kontrol ederek en buyuk olani bulur.
        /// </summary>
        /// <param name="dizi">İceri alinan dizi</param>
        /// <returns>enBuyuk</returns>
        public static int EnBuyuk(int[] dizi)
        {
            int eb = dizi[0];

            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > eb)
                {
                    eb = dizi[i];
                }
            }
            return eb;
        }
        /// <summary>
        /// Dizinin 0. elemanini tekrarli bir sekilde kontrol ederek
        /// en kucuk elemani bulur.
        /// </summary>
        /// <param name="dizi">Iceri alinan dizi.</param>
        /// <returns>enKucuk</returns>
        public static int EnKucuk(int[] dizi)
        {
            int ek = dizi[0];

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < ek)
                {
                    ek = dizi[i];
                }
            }
            return ek;
        }
        public static double ArtOrt(int[] dizi)
        {
            double toplam = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                toplam += dizi[i];
            }
            return toplam / dizi.Length;
        }
        public static double StdSap(int[] dizi)
        {
            double artort = ArtOrt(dizi);
            double toplam = 0;
            double x = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                
                x = dizi[i] - artort;
                toplam += Math.Pow(x,2);
            }
            
            return Math.Sqrt(toplam/(dizi.Length-1));
        }
        public static int[] TersCevirInt(int[]a)
        {
            int[] b = new int[a.Length];
            for (int i = b.Length-1; i >= 0; i--)
            {
                b[i] = a[a.Length - 1 - i];
            }
            return b;
        }
        public static void DiziOlustur2D(int b , int c)
        {
            int[,] a = new int[b, c];

            for (int i = 0; i < b; i++)
            {
                for (int k = 0; k < c; k++)
                {
                    a[i, k] = new Random().Next(1, 10);
                }
            }

            for (int i = 0; i < b; i++)
            {
                for (int k = 0; k < c; k++)
                {
                    Console.Write("a[{0},{1}]=>", i, k);
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("{0,3}  \t",a[i, k]);
                    Console.ResetColor();
                }
                Console.WriteLine("\n");
            }
        }

        public static void DiziOlustur3D(int c,int d,int e)
        {
            int[,,] a = new int[c, d, e];

            for (int o = 0; o < c; o++)
            {
                for (int n = 0; n < d; n++)
                {
                    for (int m = 0; m < e; m++)
                    {
                        a[o, n, m] = new Random().Next(1, 10);
                    }
                }
            }

            for (int j = 0; j < c; j++)
            {
                for (int k = 0; k < d; k++)
                {
                    for (int i = 0; i < e; i++)
                    {
                        Console.Write("a[{0},{1},{2}] = >", j, k, i, a[j, k, i]);
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("{0,3}  \t", a[j, k, i]);
                        Console.ResetColor();
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
