using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Sayilar
{
    class Dosya
    {
		/// <summary>
		/// Proje dizinindeki bir dosyanin dosya yolunu olusturur.
		/// </summary>
		/// <param name="DosyaAdi">Dosya Adi</param>
		/// <returns>Dosya yolunu doner.</returns>
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
		/// <summary>
		/// Dosya yolundaki text dosyasini okuyup sirali stringe cevirir.
		/// </summary>
		/// <param name="dosyaYol">Dosya yolu.</param>
		/// <returns>Sirali bir string doner.</returns>
		public static string satirOku(string dosyaYol)
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
		/// <summary>
		/// Satirdan okunan veriyi string dizisine cevirir.
		/// </summary>
		/// <param name="liste">Okunan sirali string verisi</param>
		/// <returns>Data dizisi verir</returns>
		public static string[] ListeToData(string liste)
		{
			liste.TrimEnd(',');
			string[] data = liste.Split(',');
			return data;
		}
		/// <summary>
		/// Data dizisindeki degerleri yeni bir diziye tasir.
		/// </summary>
		/// <param name="data">Data dizisi</param>
		/// <param name="a">Yeni dizi</param>
		/// <returns>Dolu diziyi dondurur.</returns>
		public static string[] dataToDizi(string[] data, string[] a)
		{
			for (int i = 0; i < data.Length-1; i++)
			{
				a[i] = data[i];
			}
			return a;
		}
		/// <summary>
		/// Belirli bir string dizisini dosyaya yazdirir.
		/// </summary>
		/// <param name="dosyaAdi">Dosya adi</param>
		/// <param name="line">String dizisi</param>
		public static void IcineYaz(string dosyaAdi,string[]line)
		{
			string dosyaYol = DosyaYolu(dosyaAdi);
			using (StreamWriter sw = new StreamWriter(dosyaYol))
			{
				foreach  (string a in line)
				{
					sw.WriteLine(a);
					Console.WriteLine(a);
				}
			}
		}
		/// <summary>
		/// Halihazirda ici dolu veya bos olan dosyanin uzerine yeni satirlar ekler.
		/// </summary>
		/// <param name="dosyaAdi">Dosya adi</param>
		/// <param name="a">Eklenmek istenen dizi</param>
		public static void UstuneEkle(string dosyaAdi,string[]a)
		{
			string dosyaYol = DosyaYolu(dosyaAdi);
			//Altina ekle
			using (StreamWriter sw = new StreamWriter(dosyaYol,append:true))
			{
				foreach (string b in a)
				{
					sw.WriteLine(b);
					Console.WriteLine(b);
				}
			}

		}
		/// <summary>
		/// Filestream yontemiyle string ifadesini dosya icine yazdirir.
		/// </summary>
		/// <param name="fs">Filestream ogesi</param>
		/// <param name="a">Yazdirilacak text</param>
		public static void TextEkle(FileStream fs, string a)
		{
			byte[] info = new UTF8Encoding(true).GetBytes(a);
			fs.Write(info, 0, info.Length);
			fs.WriteByte(13);// Enter \n
		}
		/// <summary>
		/// Console üzerinden girilen isimleri belirtilen dosyaya ekler.
		/// </summary>
		/// <param name="dosyaAdi">Eklenecek dosya adi</param>
		public static void IsimListesiOlustur(string dosyaAdi)
		{
			string dosyaYol = Dosya.DosyaYolu(dosyaAdi);
			string ad = "";
			try
			{

				using (FileStream fs = new FileStream(dosyaYol,
					FileMode.Append, FileAccess.Write,
					FileShare.None))
				{
					while (ad != "cikis")
					{
						Console.WriteLine("Lutfen eklemek istediginiz bir isim girin : \n");
						Console.WriteLine("~~Cikmak icin \"cikis\" yaziniz~~");
						ad = Console.ReadLine();
						if (fs.CanWrite)
						{ 
							if (ad == "cikis")
							{
								break;
							}
							TextEkle(fs, ad);
							Console.WriteLine("Basariyla kaydedildi.");
						}
						else
						{
							
						}
					}
					fs.Close();
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
		}
		/// <summary>
		/// Dosya ile alakali bilgiri getirir.
		/// </summary>
		/// <param name="dosyaAdi">Bilgisi istenilen dosya adi.</param>
		public static void DosyaBilgisi(string dosyaAdi)
		{
			string dosyaYol = DosyaYolu(dosyaAdi);
			var fi = new FileInfo(dosyaYol);
			Console.WriteLine("Bu dosya mevcut mu : {0}", fi.Exists ? "Evet" : "Hayir");
			if (fi.Exists)
			{
				Console.WriteLine("Dosya adi : {0}", fi.Name);
				Console.WriteLine("Dosya yolu : {0}", fi.FullName);
				Console.WriteLine("Dosya uzunlugu : {0}", fi.Length);
				Console.WriteLine("Dosya uzantisi : {0}", fi.Extension);
				Console.WriteLine("Dosya olusturma zamani : {0}", fi.CreationTime);
				Console.WriteLine("Dosya son erisim zamani : {0}", fi.LastAccessTime);
				Console.WriteLine("Dosya son yazma zamani : {0}", fi.LastWriteTime);
			}
			
		}
		/// <summary>
		/// Kaynagi verilen dosyanin icerigini hedefte istenen dosyaya kopyalar.
		/// (Backup log tutmak icin uygun olabilir.)
		/// </summary>
		/// <param name="kaynak">Kopyalanacak kaynak</param>
		/// <param name="hedef">Kopyalanacak hedef</param>
		public static void KopyaOlustur(string kaynak,string hedef)
		{
			try
			{
				FileInfo fi = new FileInfo(kaynak);
				fi.CopyTo(hedef);
				Console.WriteLine("{0} kaynakli dosya {1} kopyalandi.", kaynak, hedef);
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
		}
		/// <summary>
		/// Hedefteki dosyayi siler.
		/// </summary>
		/// <param name="hedef">Silmek istenilen dosyanin tam adresi.</param>
		public static void DosyaSil(string hedef)
		{
			try
			{
				FileInfo fi = new FileInfo(hedef);
				fi.Delete();
				Console.WriteLine("{0} basariyla silindi.",hedef);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
