using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Sayilar
{
    class Matematik
    {
        public static double UstAl(double taban,double kuvvet)
        {
            double sonuc = 1;
            for (int i = 0; i < kuvvet; i++)
            {
                sonuc *= taban;
                ///Console.WriteLine(sonuc);
            }
            return sonuc;
        }
        public static int[] AsalCarpanlar(int a)
        {
            string carpanListesi = "";
            int i = 2;
            while (a > 1)
            {
                if (a % i == 0)
                {
                    a /= i;
                    carpanListesi += i.ToString() + ",";
                }
                else i++;
            }
            carpanListesi = carpanListesi.Substring(0,carpanListesi.Length-1);
            string[] carpanlar = carpanListesi.Split(",");
            int[] b = new int[carpanlar.Length];

            for (i = 0; i < b.Length; i++)
            {
                b[i] = Convert.ToInt32(carpanlar[i]);
            }

            return b;            
        }
        public static int[] AsalCarpanlar2(int a)
        {
            string carpanListesi = "";
            int i = 2;
            while (a > 1)
            {
                if (a % i == 0)
                {
                    a = a / i;
                    carpanListesi += i.ToString() + ",";
                }
                else i++;
            }
            carpanListesi = carpanListesi.Substring(0, carpanListesi.Length - 1);
            string[] carpanlar = carpanListesi.Split(",");

            string b = carpanlar[0];
            string c = b;

            for ( i = 0; i < carpanlar.Length; i++)
            {
                if (!(b==carpanlar[i]))
                {
                    c = c + "," + carpanlar[i];
                    b = carpanlar[i];
                }
            }
            carpanlar = c.Split(',');
            int[] asalCarpanlari = new int[carpanlar.Length];
            for (i = 0; i < asalCarpanlari.Length; i++)
            {
                asalCarpanlari[i] = Convert.ToInt32(carpanlar[i]);
            }
            return asalCarpanlari;
        }
        public static int AsalCarpanlarinToplami(int a)
        {
            int[] b = AsalCarpanlar2(a);
            int toplam = 1;
            for (int i = 0; i < b.Length; i++)
            {
                toplam += b[i];
            }
            return toplam;
        }

        public static int AsalCarpanlarinCarpimi(int a)
        {
            int[] b= AsalCarpanlar2(a);
            int carpim = 1;
            for (int i = 0; i < b.Length; i++)
            {
                carpim *= b[i];
            }
            return carpim;
        }

        public static int OKEK(int a , int b)
        {
            int s = 1;
            while (a != 1 && b != 1)
            {
                int bol = 2;
                for (int i = 1; i <= (a > b ? a : b); i++)
                {
                    if (a % bol == 0 || b % bol == 0)
                    {
                        s *= bol;
                        if (a % bol == 0)
                        {
                            a = a / bol;
                        }
                        if (b % bol == 0)
                        {
                            b = b / bol;
                        }
                    }
                    else
                    {
                        bol++;
                    }
                }
            }
            return s;
        }

        public static int OBEB(int a, int b)
        {
            int s = 1;
            while (a != 1 && b != 1)
            {
                int bol = 2;
                for (int i = 2; i <= (a > b ? a : b); i++)
                {
                    if (a % bol == 0 || b % bol == 0)
                    {
                        if (a % bol == 0 && b % bol == 0)
                        {
                            s *= bol;
                        }
                        if (a % bol == 0)
                        {
                            a = a / bol;
                        }
                        if (b % bol == 0)
                        {
                            b = b / bol;
                        }
                    }
                    else
                    {

                        bol++;
                    }
                }
            }
            return s;
        }

        public static int Faktoriyel(int a)
        {
            int sonuc = 1;
            if (a<=1) return 1;
            for (int i = 1; i <= a; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }

    }
}
