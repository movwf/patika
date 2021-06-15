using System;

namespace Sayilar
{
    class Stringler
    {
        public static string CharToStr(char[] a)
        {
            return new string(a);
        }

        public static void Desen1(char a = '*', int n = 5)
        {
            for (int i = 0; i <=n;  i++)
            {
                Console.Write("{0,10}\n",new string(a,i));
            }
        }

        public static void Desen2(char c='!', int n = 4)
        {
            for (int i = n; i >= 0; i--)
            {
                Console.Write("{0}\n",new string(c,i));
            }
        }

        public static void KarakterSeti(int baslangicIndis = 65,
            int bitisIndis = 90,
            int satirKarakterSayisi = 5)
        {
            for (int i = baslangicIndis; i <= bitisIndis; i++)
            {
                Console.Write("{0,5}-{1,5}",
                    i,(char)i);
                if (i%satirKarakterSayisi==0)
                {
                    Console.Write("\n");
                }
            }
        }
        public static int[] StringToInt(string b)
        {
            string[] c = b.Split(',');
            int[] d = new int[c.Length];

            for (int i = 0; i < c.Length; i++)
            {
                d[i] = Convert.ToInt32(c[i]);
            }
            return d;
        }
        public static string[] IntToString(int a)
        {
            string c = a.ToString();
            string[] d = new string[c.Length];

            for (int i = 0; i < c.Length; i++)
            {
                d[i] = Convert.ToString(c[i]);
            }
            return d;
        }
        /// <summary>
        /// Verilen stringi string dizisine çevirir.
        /// </summary>
        /// <param name="a">Girilen string.</param>
        /// <returns>Her harfini diziye cevirir.</returns>
        public static string[] StringToDizi(string a)
        {
            string b = "";

            for (int i = 0; i < a.Length; i++)
            {
                b += a[i] + ",";
            }
            b = b.Substring(0, b.Length - 1);
            string[] c = b.Split(',');
            return c;
        }
        /// <summary>
        /// Bir stringdeki sesli harfleri sayar.
        /// </summary>
        /// <param name="a">Girilen string ifade.</param>
        /// <returns>Sesli harf sayisini doner.</returns>
        public static int SesliHarfSay(string a)
        {
            string[] b = StringToDizi(a);
            string[] c = {"a","e","ı","i","o","ö","u","ü"};
            int say = 0;
            for (int i = 0; i < b.Length; i++)
            {
                ///Console.WriteLine("{0}", b[i]);
                int k = 0;
                while (k < c.Length)
                {
                    if (b[i] == c[k])
                    {
                        ///Console.WriteLine("Sesli harf => {0}",c[k]);
                        say++;
                    }
                    k++;
                }
            }
            return say;
        }
        /// <summary>
        /// Bir stringdeki sessiz harfleri sayar.
        /// </summary>
        /// <param name="a">Girilen string ifade.</param>
        /// <returns>Sessiz harf sayisini doner.</returns>
        public static int SessizHarfSay(string a)
        {
            int b = a.Length;
            int d = SesliHarfSay(a);
            int c = b-d;
            return c;
        }
    }
}
