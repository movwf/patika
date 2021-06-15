using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Cizim
{
    public class Dikdortgen : Sekil
    {
        public Dikdortgen()
        {
            Console.WriteLine("Derived Class -> ctor.");
        }
        public override void Ciz()
        {
            Console.WriteLine($"Dikdortgen {Pozisyon} - {Boyut}");
            for (int i = 0; i < Pozisyon.Y; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("{0}{1}", new String(' ', Pozisyon.X), new String('-', Boyut.Genislik));
            for (int i = 0; i < Boyut.Yukseklik; i++)
            {
                Console.WriteLine("{0}|{1}|", new String(' ', Pozisyon.X), new String(' ', Boyut.Genislik - 2)); ;
            }
            Console.WriteLine("{0}{1}", new String(' ', Pozisyon.X), new String('-', Boyut.Genislik));
        }
        public override void Tasi(Pozisyon yeniPozisyon)
        {
            Console.WriteLine("Yeni konum : ({0},{1})",yeniPozisyon.X,yeniPozisyon.Y);
            base.Tasi(yeniPozisyon);
        }
        public override void YenidenBoyutlandir(int yeniGenislik, int yeniYukseklik)
        {
            Boyut.Genislik = yeniGenislik;
            Boyut.Yukseklik = yeniYukseklik;
            Ciz();
        }
    }
}
