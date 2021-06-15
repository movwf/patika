using System;
using System.IO;

namespace OOP
{
    class Dukkan
    {
        private string _adi;
        public Dukkan()
        {
            Banner();
            SatirIci("Ne yapmak istiyorsunuz : ");
            Console.Write("||     ");
            string a = Convert.ToString(Console.ReadLine());
            AraSatir();
            if (a == "giris")
            {
                SatirIci("Giris bilgilerini giriniz :");
                AraSatir();
                Console.Write("|| Ad : ");
                Adi = Convert.ToString(Console.ReadLine());
                Console.Write("|| Sifre : ");
                string pass = Convert.ToString(Console.ReadLine());
                for (int i = 0; i < 2; i++)
                {
                    if (LogIn(Adi, pass))
                    {
                        Console.Clear();
                        Banner();
                        SatirIci("Basariyla giris yaptiniz!");
                        AraSatir();
                        IsLogIn = true;
                        Oyun();
                        break;
                    }
                    else if(!(LogIn(Adi,pass)))
                    {
                        SatirIci("Kullanici bilgilerini yanlis girdiniz.Tekrar deneyiniz!");
                        Console.Write("|| Ad : ");
                        Adi = Convert.ToString(Console.ReadLine());
                        Console.Write("|| Sifre : ");
                        pass = Convert.ToString(Console.ReadLine());
                        IsLogIn = false;
                        AraSatir();
                    }
                }
                
            }
            else if (a == "kayit")
            {
                SatirIci("Kayit bilgilerini giriniz :");
                AraSatir();
                Console.Write("|| Ad : ");
                Adi = Convert.ToString(Console.ReadLine());
                Console.Write("|| Yas : ");
                Yas = Convert.ToInt32(Console.ReadLine());
                Console.Write("|| Bir sifre belirleyin : ");
                string sifre = Convert.ToString(Console.ReadLine());
                Register(Adi, sifre);
                AraSatir();
                Oyun();
            }
            else if (a == "cikis")
            {
                AraSatir();
            }
            else
            {
                SatirIci("Gorusuruz!");
                AraSatir();
            }
        }
        public string Adi { get => _adi ; set => _adi = value; }
        public int Yas { get; set; }
        public int YasBilgisi()
        {
            string uname = Adi;
            int yasBilgisi = 0;
            string line;
            string liste = "";
            ///int dosyaSatir = 0;
            StreamReader fs = new StreamReader(DosyaYolu("Kullanicilar.txt"));
            while ((line = fs.ReadLine()) != null)
            {
                liste += line + ';';
            }
            fs.Close();

            ///Console.WriteLine(liste);
            liste = liste.TrimEnd(';');
            string[] kullanici = liste.Split(';');
            string[] kontrol;
            ///Console.WriteLine(kullanici.Length);

            for (int i = 1; i < kullanici.Length; i++)
            {
                kontrol = kullanici[i].Split(',');
                if (kontrol[0] == uname)
                {
                    yasBilgisi = Convert.ToInt32(kontrol[1]);
                }
            }
            return yasBilgisi;
        }
        public void Banner()
        {
            AraSatir();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("||{0}||", new string(' ', 71));
            }
            Console.WriteLine("||{0}D.U.K.K.A.N{1}||", new string(' ', 30), new string(' ', 30));
            Console.WriteLine("||{0}Bir acayip satis oyunu!{1}||", new string(' ', 24), new string(' ', 24));
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("||{0}||", new string(' ', 71));
            }
            AraSatir();
        }
        public void Oyun()
        {
            AraSatir();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("||{0}||", new string(' ', 71));
            }
            SatirIci("Oyun Asamalari :");
            SatirIci("----------------");
            SatirIci("1) Urun Liste");
            SatirIci("2) Urun Sat");
            SatirIci("3) Cikis Yap");
            SatirIci("4) Profili Goruntule");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("||{0}||", new string(' ', 71));
            }
            AraSatir();
            SatirIci("Bir secenek girin :");
            AraSatir();
            Console.Write("||     ");
            string secenek = Convert.ToString(Console.ReadLine());
            if (secenek == "1") UrunListe();
            else if (secenek == "2") UrunSat();
            else if (secenek == "3") Cikis();
            else if (secenek == "4") Profil();
        }
        public static void SatirIci(string a)
        {
            string b = "";
            if (a.Length<71)
            {
                int solBosluk = 5, sagBosluk = 66-a.Length;
                string x = new string(' ', solBosluk);
                string y = new string(' ', sagBosluk);
                b = "||" + x + a + y + "||";
            }
            Console.WriteLine(b);
        }
        public static void AraSatir()
        {
            Console.WriteLine("{0}", new string('=', 75));
        }
        public void UrunListe()
        {
            ///string[] urunListe = {"Kamera","20","Laptop","10","Telefon","15"};
            string[] urunListe = UrunListesi();
            AraSatir();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("||{0}||", new string(' ', 71));
            }
            SatirIci("Satilabilir Urunler :");
            SatirIci("----------------");
            for (int i = 0; i < urunListe.Length-2; i++)
            {
                string s ="-" + urunListe[i]+"("+urunListe[i+1]+"puan)";
                SatirIci(s);
                i++;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("||{0}||", new string(' ', 71));
            }
            AraSatir();
            SatirIci("<= Geri don(1)");
            AraSatir();
            Console.Write("||     ");
            string secenek = Convert.ToString(Console.ReadLine());
            if (secenek == "1") Oyun();
        }
        public int UrunSat()
        {
            AraSatir();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("||{0}||", new string(' ', 71));
            }
            Console.WriteLine("||{0}Satacagin urunun ismini gir :{1}||", new string(' ', 21), new string(' ', 21));
            Console.Write("||     ");
            string satUrun = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("||{0}||", new string(' ', 71));
            }
            AraSatir();
            string[] a = UrunListesi();
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].ToLower()==satUrun.ToLower())
                {
                    k = Convert.ToInt32(a[i+1]);
                }
            }
            if (k == 0)
            {
                    SatirIci("Belirttiginiz urun bulunamadi.");
                Oyun();
            }
            else
            {
                SatirIci("Urun satildi ve "+k+" deneyim kazandiniz.");
                AraSatir();
                DeneyimKazan(k);
                SatirIci("Ne yapmak istiyorsunuz ? : ");
                SatirIci("1) Menuye don");
                SatirIci("2) Urun Sat");
                SatirIci("3) Cikis Yap");
                AraSatir();
                Console.Write("||     ");
                string secenek = Convert.ToString(Console.ReadLine());
                if (secenek == "1") Oyun();
                else if (secenek == "2") UrunSat();
                else if (secenek == "3") Cikis();

            }
            return k;
        }
        public void Profil()
        {
            AraSatir();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("||{0}||", new string(' ', 71));
            }
            string deneyim = Convert.ToString(DeneyimGetir(Adi));
            int yasi = YasBilgisi();
            SatirIci("Kullanici Bilgileri :");
            SatirIci("----------------");
            SatirIci("Adi : "+Adi);
            SatirIci("Yas : "+ yasi);
            SatirIci("Deneyim : "+deneyim+" puan");
            SatirIci("");
            SatirIci("<= Geri don (1)");
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("||{0}||", new string(' ', 71));
            }
            AraSatir();
            Console.Write("||     ");
            string secenek = Convert.ToString(Console.ReadLine());
            if (secenek == "1") Oyun();
        }
        public static int DeneyimGetir(string uname)
        {
            string a = SiraliSatirOku(DosyaYolu("Deneyim.txt"));
            int aLength = a.Length - 1;
            a = a.Substring(0,aLength);
            string[] b = a.Split(';');
            string[] c = new string[2];
            int exp = 0;
            for (int i = 0; i < b.Length; i++)
            {
                c[0] = b[i].Split(',')[0];
                c[1] = b[i].Split(',')[1];
                exp = Convert.ToInt32(c[1]);
                if (uname == c[0])
                {
                    return exp;
                }
            }

            return exp;
        }
        public void DeneyimKazan(int exp)
        {
            DeneyimYaz(exp,Adi);
        }
        public void DeneyimYaz(int exp,string uname)
        {
            string a = SiraliSatirOku(DosyaYolu("Deneyim.txt"));
            int aLength = a.Length - 1;
            a = a.Substring(0, aLength);
            string[] b = a.Split(';');
            string[] c = new string[2];
            string yeniListe = "";
            for (int i = 0; i < b.Length; i++)
            {
                c[0] = b[i].Split(',')[0];
                c[1] = b[i].Split(',')[1];
                if (uname == c[0])
                {
                    exp += Convert.ToInt32(c[1]);
                    string liste = c[0] + "," + exp + ";";
                    yeniListe += liste;
                }
                else
                {
                        yeniListe += c[0] + "," + c[1] + ";";
                }
            }
            int x = yeniListe.Length - 1;
            yeniListe = yeniListe.Substring(0, x);
            string[] yeniListe2 = yeniListe.Split(";");

            using StreamWriter sw = new StreamWriter(DosyaYolu("Deneyim.txt"));
                foreach (string satir in yeniListe2)
                {
                    sw.WriteLine(satir);
                }
        }
        public void Cikis()
        {
            Console.Clear();
            AraSatir();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("||{0}||", new string(' ', 71));
            }
            Console.WriteLine("||{0}{1}{2}||",
                new string(' ', 31),"Güle Güle", new string(' ', 31));
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("||{0}||", new string(' ', 71));
            }
            AraSatir();
        }
        public static string DosyaYolu(string DosyaAdi)
        {
            string dosyaYol = "";
            try
            {
                string[] yol = Directory.GetCurrentDirectory().Split("\\");
                for (int i = 0; i < yol.Length - 3; i++)
                {
                    dosyaYol += yol[i] + '\\';
                }
                dosyaYol += DosyaAdi;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dosyaYol;
        }
        public static string SatirOku(string dosyaYol)
        {
            string line;
            string paket = "";
            using (StreamReader sr = new StreamReader(dosyaYol))
            {

                while ((line = sr.ReadLine()) != null)
                {
                    paket += line + ',';
                }
            }
            return paket;
        }
        public static string SiraliSatirOku(string dosyaYol)
        {
            string line;
            string paket = "";
            using (StreamReader sr = new StreamReader(dosyaYol))
            {

                while ((line = sr.ReadLine()) != null)
                {
                    paket += line + ';';
                }
            }
            return paket;
        }

        public static string[] UrunListesi()
        {
            string dosyaYol = DosyaYolu("Urunler.txt");
            string[] liste = SiraliSatirOku(dosyaYol).Split(';');
            string s = "";
            for (int i = 0; i < liste.Length; i++)
            {
                s += liste[i]+",";
            }
            int a = s.Length - 1;
            string p = s.Substring(0, a);
            string[] urunListesi = p.Split(',');
            return urunListesi;
        }
        public bool IsLogIn {get; set; }
        public bool LogIn(string uname,string pwd)
        {
            string line;
            string liste="";
            ///int dosyaSatir = 0;
            StreamReader fs = new StreamReader(DosyaYolu("Kullanicilar.txt"));
                while ((line = fs.ReadLine()) != null)
                { 
                    liste += line + ';';
                }
                fs.Close();

            ///Console.WriteLine(liste);
            liste = liste.TrimEnd(';');
            string[] kullanici = liste.Split(';');
            string[] kontrol;
            bool cool = false;
            ///Console.WriteLine(kullanici.Length);
            
            for (int i = 1; i < kullanici.Length; i++)
            {
               kontrol = kullanici[i].Split(',');
                if (kontrol[0]==uname&&kontrol[2]==pwd)
                {
                    cool = true;
                }
            }
            return cool;
        }
        public void Register(string uname,string pwd)
        {
            string info = uname+","+Yas+","+pwd;
            string info2 = uname + ",1";
            using StreamWriter fs = new StreamWriter(DosyaYolu("Kullanicilar.txt"), append: true);
            fs.Write("\n");    
            fs.Write(info);
            fs.Close();
            using StreamWriter sw = new StreamWriter(DosyaYolu("Deneyim.txt"), append: true);
            sw.Write("\n");
            sw.Write(info2);
            SatirIci("Basariyla kayit oldunuz!");
        }
    }
}
