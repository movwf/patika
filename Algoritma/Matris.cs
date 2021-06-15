using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Sayilar
{
    class Matris
    {
        /// <summary>
        /// Bir matrisin ekrana yazdirir.
        /// </summary>
        /// <param name="a">Girilen matris</param>
        public static void Yazdir(int[,] a)
        {
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
                for (int j = 0; j < satir; j++)
                {
                    for (int k = 0; k < sutun; k++)
                    {
                        Console.Write("a[{0},{1}] = >",j, k);
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("{0,3}  \t", a[j, k]);
                        Console.ResetColor();
                    }
                    Console.WriteLine("\n");
                }
        }
        /// <summary>
        /// Hata mesajlarina ozel tasarim
        /// </summary>
        /// <param name="mesaj">Hata mesajini yeni haliyle doner.</param>
        public static void YazdirHata(string mesaj)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}\a{1}\a{2}\n",
                new string(' ',5),mesaj, new string(' ', 5));
            Console.ResetColor();
        }
        /// <summary>
        /// Min ve Maks arasinda rastgele degerler ile bir matris olusturur.
        /// </summary>
        /// <param name="satir">Satir sayisi</param>
        /// <param name="sutun">Sutun sayisi</param>
        /// <param name="maks">Rastgele deger (Maks)</param>
        /// <param name="min">Rastgele deger(Min)</param>
        /// <returns>Bir matris doner</returns>
        public static int[,] Olustur(int satir,int sutun, int min,int maks)
        {
            int[,] b = new int[satir,sutun];
                for (int j = 0; j < satir; j++)
                {
                    for (int k = 0; k < sutun; k++)
                    {
                        b[j, k] = new Random().Next(min,maks); 
                    }
                }
            return b;

        }
        /// <summary>
        /// Bir matrisin elemanlarini toplar.
        /// </summary>
        /// <param name="a">Girilen matris</param>
        /// <returns>Toplami doner.</returns>
        public static int ElemanlariTopla(int[,]a)
        {
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
            int toplam = 0;
            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    toplam += a[i,k];
                }
            }
            return toplam;
        }
        /// <summary>
        /// Satir ve sutun degerleri girilen birim matrisi olusturur
        /// </summary>
        /// <param name="satir">Girilen satir</param>
        /// <param name="sutun">Girilen sutun</param>
        /// <returns>Birim matris doner.</returns>
        public static int[,] BirMatris(int satir,int sutun)
        {
            int[,] b = new int[satir, sutun];
            for (int j = 0; j < satir; j++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    b[j, k] = 1;
                }
            }
            return b;
        }
        /// <summary>
        /// Min ve Maks arasinda rastgele degerler ile kosegen matris olusturur.
        /// </summary>
        /// <param name="satir">Satir sayisi</param>
        /// <param name="sutun">Sutun sayisi</param>
        /// <param name="maks">Rastgele deger (Maks)</param>
        /// <param name="min">Rastgele deger(Min)</param>
        /// <returns>Kosegen matris doner</returns>
        public static int[,] KosegenMatris(int satir, int sutun,int min,int maks)
        {
            int[,] b = new int[satir, sutun];
            for (int j = 0; j < satir; j++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    if (k==j) {
                        b[j, k] = new Random().Next(min,maks);
                    }
                    else
                    {
                        b[j, k] = 0;
                    }
                    
                }
            }
            return b;
        }
        /// <summary>
        /// Verilen degere gore bir skaler matris olusturur.
        /// </summary>
        /// <param name="satir">Satir sayisi</param>
        /// <param name="sutun">Sutun sayisi</param>
        /// <param name="deger">Skaler deger</param>
        /// <returns>Skaler matris doner</returns>
        public static int[,] SkalerMatris(int satir, int sutun,int deger)
        {
            int[,] b = new int[satir, sutun];
            for (int j = 0; j < satir; j++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    if (k == j)
                    {
                        b[j, k] = deger;
                    }
                    else
                    {
                        b[j, k] = 0;
                    }

                }
            }
            return b;
        }
        /// <summary>
        /// Verilen degerler ile simetrik bir matris olusturur.
        /// </summary>
        /// <param name="satir">Istenilen satir sayisi</param>
        /// <param name="sutun">Istenilen sutun sayisi</param>
        /// <param name="min">Rastgele deger (min)</param>
        /// <param name="maks">Rastgele deger(maks)</param>
        /// <returns>Simetrik bir matris doner.</returns>
        public static int[,] SimetrikMatris(int satir,int sutun,int min,int maks)
        {
            int[,] a = new int[satir, sutun];
            if (satir != sutun)
            {
                YazdirHata("Lutfen kare bir matris olusturacak sekilde deger giriniz!");
            }
            else
            {
                for (int i = 0; i < satir; i++)
                {
                    for (int k = 0; k < sutun; k++)
                    {
                        if (i == k)
                        {
                            a[i, k] = new Random().Next(min, maks);
                        }
                        else
                        {
                            a[i, k] = a[k, i] = new Random().Next(min, maks);
                        }
                    }
                }
            }
                return a;
        }
        /// <summary>
        /// Bir matrisin kare matris olmakligini kontrol eder.
        /// </summary>
        /// <param name="a">Girilen matris</param>
        /// <returns>Dogru veya yanlis doner.</returns>
        public static bool KareMatrisMi(int[,]a)
        {
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
            if (satir==sutun)
            {
                return true;
            }else return false;
        }
        /// <summary>
        /// Bir matrisin birim matris olup olmadigini kontrol eder.
        /// </summary>
        /// <param name="a">Girilen matris.</param>
        /// <returns>Evet veya hayir doner.</returns>
        public static bool BirimMatrisMi(int[,] a)
        {
            bool b = true;
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
            for (int j = 0; j < satir; j++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    if (j == k&& a[j,k]==1)
                    {
                            ///Console.WriteLine("{0}",a[j,k]);
                            b = true;
                    }
                    else if (a[j, k] == 0)
                    {
                        b=true;
                    }
                    else b=false;
                }
            }
            return b;
        }
        /// <summary>
        /// Bir matrisin simetrik olmakilgini kontrol eder.
        /// </summary>
        /// <param name="a">Girilen matris.</param>
        /// <returns>Evet veya hayir doner.</returns>
        /// 
        public static bool SimetrikMatrisMi(int[,] a)
        {
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
            int sorgu = 0;
            int sorgu2 = 0;
            if (satir != sutun)
            {
                YazdirHata("Lutfen kare bir matris olusturacak sekilde deger giriniz!");
                return false;
            }
            else
            {
                for (int i = 0; i < satir; i++)
                {
                    for (int k = 0; k < sutun; k++)
                    {
                        int b = a[i, k];
                        int c = a[k, i];
                        if (b == c)
                        {
                            sorgu++;
                        }
                        else sorgu2++;
                    }

                }
            }
 
            ///Console.WriteLine("Sorgu : {0}", sorgu);
            ///Console.WriteLine("Sorgu 2 : {0}", sorgu2);
            ///Console.WriteLine("Digeri : {0}", ((a.Length - satir) / 2 * sutun));
            if (sorgu == ((a.Length - satir) / 2 * sutun))
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Bir matrisin kosegen matris olmakligini kontrol eder.
        /// </summary>
        /// <param name="a">Girilen matris.</param>
        /// <returns>Evet veya hayir degeri doner.</returns>
        public static bool KosegenMatrisMi(int[,]a)
        {
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
            bool sorguKosegen = false;
            bool sorguDiger = false;
            bool y = false;
            for (int j = 0; j < satir; j++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    if (j == k)
                    {
                        if (a[j, k] != 0)
                        {
                            sorguKosegen = true;
                        }
                    }
                    else
                    {
                        if (a[j, k] == 0)
                        {
                            sorguDiger = true;
                        }
                        else sorguDiger = false;
                    }

                }
            }
            if (sorguKosegen == sorguDiger)
            {
                y = true;
            }
            else y = false;
            return y;
        }
        /// <summary>
        /// Bir matrisin ust ucgen matris olmakligini kontrol eder.
        /// </summary>
        /// <param name="a">Girilen matris.</param>
        /// <returns>Evet veya hayir degeri doner.</returns>
        public static bool UstUcgenMatrisMi(int[,] a)
        {
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
            int x = 0;
            int z = 1;
            bool y1 = false, y2 = false, sonuc = false;
            for (int i = 0; i < satir; i++)
            {
                for (int k = x; k < sutun; k++)
                {
                    if (a[i,k]!=0)
                    {
                        y1 = true;
                    }
                }
                x++;
            }
            for (int i = 1; i < satir; i++)
            {
                for (int k = 0; k < z; k++)
                {
                    if (a[i,k]==0)
                    {
                        y2 = true;
                    }
                }
                z++;
            }
            if (y1==y2==true)
            {
                sonuc = true;
            }
            return sonuc;
        }
        /// <summary>
        /// Bir matrisin alt ucgen matris olmakligini kontrol eder.
        /// </summary>
        /// <param name="a">Girilen matris.</param>
        /// <returns>Evet veya hayir degeri doner.</returns>
        public static bool AltUcgenMatrisMi(int[,] a)
        {
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
            int x = 1;
            int z = 1;
            bool y1 = false, y2 = false, sonuc = false;
            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < z; k++)
                {
                    if (a[i, k] != 0)
                    {
                        y1 = true;
                    }
                }
                x++;
            }

            for (int i = 0; i < satir; i++)
            {
                for (int k = z; k < sutun; k++)
                {
                    if (a[i, k] == 0)
                    {
                        y2 = true;
                    }
                }
                z++;
            }
            if (y1 == y2 == true)
            {
                sonuc = true;
            }
            return sonuc;
        }
        /// <summary>
        /// Matrisin diyagonal elemanlarini listeler.
        /// </summary>
        /// <param name="a">Girilen matris.</param>
        /// <returns>Eleman listesi döner.</returns>
        public static int[] DiyagonalElemanlar(int[,]a)
        {
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
            int[] liste = new int[sutun];
            for (int j = 0; j < satir; j++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    if (j == k)
                    {
                        liste[k] = a[j, k];
                    }
                }
            }
            return liste;
        }
        /// <summary>
        /// Matrisin ters diyagonal elemanlarini listeler
        /// </summary>
        /// <param name="a">Girilen matris</param>
        /// <returns>Ters diyagonal elemanlari doner.</returns>
        public static int[] TersDiyagonalElemanlar(int[,] a)
        {
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
            int[] liste = new int[sutun];

            int x = satir - 1;
            int y = 0;
            for (int j = x; j >= 0; j--)
            {
                for (int k = 0; k < sutun; k++)
                {
                    if (j + k == sutun -1)
                    {
                        liste[y] = a[j, k];
                        y++;
                    }
                }
            }
            return liste;
        }
        /// <summary>
        /// Diyagonal elemanları bulur ve birbiriyle carpar.
        /// </summary>
        /// <param name="a">Girilen matris</param>
        /// <returns>Carpim sonucunu doner.</returns>
        public static int DiyagonalCarpim(int[,]a)
        {
            int[] liste = DiyagonalElemanlar(a);
            int carpim = 1;
            for (int i = 0; i < liste.Length; i++)
            {
                carpim *= liste[i];
            }
            return carpim;
        }
        /// <summary>
        /// Ters diyagonal elemanları bulur ve birbiriyle carpar.
        /// </summary>
        /// <param name="a">Girilen matris</param>
        /// <returns>Carpim sonucunu doner.</returns>
        public static int TersDiyagonalCarpim(int[,] a)
        {
            int[] liste = TersDiyagonalElemanlar(a);
            int carpim = 1;
            for (int i = 0; i < liste.Length; i++)
            {
                carpim *= liste[i];
            }
            return carpim;
        }
        /// <summary>
        /// Buyuk bir matristen istenilen parcayi alir.
        /// </summary>
        /// <param name="a">Girilen matris</param>
        /// <param name="baslSatir">Baslangic satiri</param>
        /// <param name="satir">Alinmak istenen satir sayisi</param>
        /// <param name="sutun">Alinmak istenen sutun sayisi</param>
        /// <returns>Alinan parca matrisi doner</returns>
        public static int[,] ParcaAlX(int[,]a,int baslSatir,int satir,int sutun)
        {
            int aSatir = a.GetLength(0);
            int aSutun = a.GetLength(1);
            int[,] b = a;

            if (baslSatir > aSatir || satir > aSatir - baslSatir + 1 || sutun > aSutun)
            {
                YazdirHata("Lutfen degerleri kontrol edin!");
            }
            else
            {
                int[,] c = new int[satir, sutun];
                for (int i = 0; i < satir; i++)
                {
                    for (int k = 0; k < sutun; k++)
                    {
                        c[i, k] = b[baslSatir - 1, k];
                    }
                    baslSatir++;
                }
                return c;
            }
            return a;
        }
        /// <summary>
        /// Matris'e ait trace(iz) degerini doner.
        /// </summary>
        /// <param name="a">Girilen matris.</param>
        /// <returns>Matrisin izini doner.</returns>
        public static int Trace(int[,]a)
        {
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
            int toplam = 0;
            for (int j = 0; j < satir; j++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    if (j == k)
                    {
                        toplam += a[j, k];
                    }
                }
            }
            return toplam;
        }
        /// <summary>
        /// Matrisin transpoz(devrik) halini döner.
        /// </summary>
        /// <param name="a">Girilen matris</param>
        /// <returns>Transpoz matris döner.</returns>
        public static int[,] Transpoz(int[,]a)
        {
            int[,] b = a;
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
            int[,] c = new int[sutun,satir];
            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    c[k, i] = b[i, k];
                }
            }
            return c;
        }
        /// <summary>
        /// İki matrisi karsilastirip esit olmakligini doner.
        /// </summary>
        /// <param name="a">Girilen ilk matris</param>
        /// <param name="b">Girilen ikinci matris</param>
        /// <returns>Esit ise dogru doner.</returns>
        public static bool Karsilastirma(int[,]a,int[,]b)
        {
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
            int satir2 = b.GetLength(0);
            int sutun2 = b.GetLength(1);
            bool sonuc = false;
            if (satir != satir2 || sutun != sutun2) return false;

            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    if (a[i,k]==b[i,k])
                    {
                        sonuc = true;
                    }
                    else
                    {
                        sonuc = false;
                        break;
                    }
                }
            }

            return sonuc;            
        }
        /// <summary>
        /// 2x2 Matrislerin Determinantini hesaplamada kullanilir
        /// </summary>
        /// <param name="a">Girilen matris</param>
        /// <returns>Determinantini doner.</returns>
        public static int Deter2X2(int[,]a)
        {
            int sonuc1 = 1,sonuc2 = 1;
            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    if (i == k)
                    {
                        sonuc1 *= a[i, k];
                    }
                    else
                    {
                        sonuc2 *= a[i, k];
                    }                
                }
            }
            return Sayi.MutlakDeger(sonuc1-sonuc2);
        }
        /// <summary>
        /// Herhangi boyutta bir matrisin determinantini bulur.
        /// </summary>
        /// <param name="a">Girilen Matris</param>
        /// <returns>Determinant degerini doner.</returns>
        public static int Determinant(int[,]a)
        {
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
            int[,] b = a;
            int yeniDuzen = satir + satir - 1;
            int[,] c = new int[yeniDuzen,sutun];
            ///Yeni olusan matrisin ilk satirlarini doldur.
            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    c[i, k] = b[i,k];
                }
            }
            ///Ilk satirlari altina ekle
            int yeniSatir = satir + satir-2;
            for (int i = satir; i < yeniDuzen; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    c[i, k] = a[i-satir,k];
                    ///Console.WriteLine("[{0}-{1}]",i,k);
                }
            }
            int sonuc = 0,sonuc2 = 0;
            int deger = 0 , deger2 = 0;
            for (int i = 0; i < satir; i++)
            {
                deger = DiyagonalCarpim(ParcaAlX(c, i + 1, satir, sutun));
                sonuc += deger;
                ///Console.WriteLine("Deger : {0}",deger);
            }
            for (int i = 0; i < satir; i++)
            {
                deger2 = TersDiyagonalCarpim(ParcaAlX(c, i + 1, satir, sutun));
                sonuc2 += deger2;
                ///Console.WriteLine("Deger : {0}",deger);
            }
            ///Console.WriteLine(Sayi.MutlakDeger(sonuc2-sonuc));
            return sonuc2-sonuc;
        }
        /// <summary>
        /// Bir matrisi skaler bir deger ile genisletir.
        /// </summary>
        /// <param name="a">Girilen matris</param>
        /// <param name="c">Skaler deger</param>
        /// <returns>Genislemis matrisi doner.</returns>
        public static int[,] SkalerCarpim(int[,]a,int c)
        {
            int satir = a.GetLength(0);
            int sutun = a.GetLength(1);
            int[,] b = a;
            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    b[i, k] *= c;
                }
            }
            return b;
        }
        /// <summary>
        /// Verilen degerler ile ust ucgen matris olusturur.
        /// </summary>
        /// <param name="satir">Istenilen satir sayisi</param>
        /// <param name="sutun">Istenilen sutun sayisi</param>
        /// <param name="min">Rastgele deger (min)</param>
        /// <param name="maks">Rastgele deger(maks)</param>
        /// <returns>Ust ucgen bir matris doner.</returns>
        public static int[,] UstUcgenMatris(int satir, int sutun,int min,int maks)
        {
            int[,] a = new int[satir,sutun];
            int z = 0;
            for (int i = 0; i < satir; i++)
            {
                for (int k = z; k < sutun; k++)
                {
                    a[i,k] = new Random().Next(min,maks);
                }
                z++;
            }
            return a;
        }
        /// <summary>
        /// Verilen degerler ile alt ucgen matris olusturur.
        /// </summary>
        /// <param name="satir">Istenilen satir sayisi</param>
        /// <param name="sutun">Istenilen sutun sayisi</param>
        /// <param name="min">Rastgele deger (min)</param>
        /// <param name="maks">Rastgele deger(maks)</param>
        /// <returns>Alt ucgen bir matris doner.</returns>
        public static int[,] AltUcgenMatris(int satir, int sutun, int min, int maks)
        {
            int[,] a = new int[satir, sutun];
            int z = 1;
            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < z; k++)
                {
                    a[i, k] = new Random().Next(min, maks);
                }
                z++;
            }
            return a;
        }

    }
}
