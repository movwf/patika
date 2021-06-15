using System;

namespace Sayilar
{
    class Sayi
    {
        public static int UstuInt(int a, int b)
        {
            int c = a;
            if (b == 0)
            {
                return 1;
            }
            for (int i = 1; i < b; i++)
            {
                a *= c;
            }
            return a;
        }
        public static bool AsalMi(int a)
        {

            if (a <= 1)
            {
                Console.Write("En kucuk asal sayi 2'dir.");
                return false;
            }

            bool kontrol = true;

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    kontrol = false;
                    break;
                }
            }

            return kontrol;
        }
        public static int MutlakDeger(int a)
        {
            if (a > 0 || a == 0)
            {
                return a;
            }
            else return -1 * a;
        }
        public static int RakamlarToplami(int a)
        {
            int toplam = 0, rakam = 0;

            while (a > 0)
            {
                rakam = a % 10;
                toplam += rakam;
                a = a / 10;
            }
            return toplam;
        }
        public static int SayilarinToplami(int n, int m)
        {
            int toplam = 0;
            if (m>n) {
                while (n<=m)
                {
                    toplam += n;
                    n++;
                }
                return toplam;
            }
            else
            {
                Console.Write("\n M, N'den kucuktur.\n");
                return toplam;
            }
        }
        public static int SayilarinToplamiFormul(int n, int m)
        {
            int toplam = 0;
            if (m > n)
            {
                return (m+n)*(m-n+1)/2;
            }
            else
            {
                Console.Write("\n M, N'den kucuktur.\n");
                return toplam;
            }
        }
        public static int CiftSayilarinToplami(int n, int m)
        {
            int toplam = 0;
            if (m > n)
            {
                while (n <= m)
                {
                    if (n % 2 == 0) 
                    {
                        toplam += n;
                    }
                    n++;
                }
                return toplam;
            }
            else
            {
                Console.Write("\n M, N'den kucuktur.\n");
                return toplam;
            }
        }
        public static int TekSayilarinToplami(int n, int m)
        {
            int toplam = 0;
            if (m > n)
            {
                while (n <= m)
                {
                    if (n % 2 == 1)
                    {
                        toplam += n;
                    }
                    n++;
                }
                return toplam;
            }
            else
            {
                Console.Write("\n M, N'den kucuktur.\n");
                return toplam;
            }
        }
        /// <summary>
        /// Binary sayilari Decimal'e cevirir.
        /// </summary>
        /// <param name="a">Binary girlen sayi.</param>
        /// <returns>Decimal degerini doner.</returns>
        public static int BinaryToDecimal(int a)
        {
            int toplam = 0, rakam = 0;
            int i = 0;
            while (a > 0)
            {
                rakam = a % 10;
                if (rakam != 0 && rakam != 1)
                {
                    ///Console.WriteLine("Lutfen binary bir sayi girin!");
                    break;
                }
                ///Console.WriteLine("Rakam : {0}",rakam);
                toplam += rakam * Sayi.UstuInt(2, i);
                ////Console.WriteLine("Toplam : {0}", toplam);
                a = a / 10;
                i++;
            }
            return toplam;
        }
        /// <summary>
        /// Farkli tabandan aldigi sayiyi istenilen tabana cevirir ve yazar.
        /// </summary>
        /// <param name="a">Sayi</param>
        /// <param name="taban1">Sayi'nin tabani</param>
        /// <param name="taban2">Istenilen taban</param>
        public static void TabanCevir(int a,int taban1,int taban2)
        {
            int b = a;
            int i = 0;
            int rakam = 0;
            int toplam = 0;
            string[] d = Stringler.IntToString(a);
            int[] e = new int[d.Length];
            for (i = 0; i < d.Length; i++)
            {
                e[i] = Convert.ToInt32(d[i]);
                ///Console.WriteLine("e{0}={1}",i,e[i]);
            }
            int[] g = Diziler.TersCevirInt(e);
            int carpan = 1;
            for (i = 0; i < e.Length; i++)
            {
                carpan = Sayi.UstuInt(taban1, i);
                ///Console.WriteLine("carpan{0}={1}", i, carpan);
                toplam += g[i] * carpan;
            }
            Console.WriteLine("10'luk tabanda : ({0})10",toplam);
            i = 0;
            int yeniSayi = 0;
            while (toplam > 0)
            {
                rakam = toplam % taban2;
                ///Console.WriteLine("Gelen rakam : {0}", rakam);
                yeniSayi += rakam * Sayi.UstuInt(10, i);
                ///Console.WriteLine("Debug yeni sayi = {0}", yeniSayi);
                toplam /= taban2;
                i++;
            }
            Console.WriteLine("({0}){1} = ({2}){3}", b, taban1, yeniSayi, taban2);
        }

    }
}
