using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Cizim
{
    public sealed class Pozisyon
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString() =>
            $"(x,y) = ({X},{Y})";
    }
    public sealed class Boyut
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }
        public override string ToString() =>
            $"Genislik : {Genislik}, Yukseklik : {Yukseklik}";
    }
    public abstract class Sekil
    {
        public Sekil()
        {
            Console.WriteLine("Base class -> ctor.");
        }
        public Pozisyon Pozisyon { get; } = new Pozisyon();
        public Boyut Boyut { get; } = new Boyut();

        public virtual void Ciz()
        {
            Console.WriteLine($"Sekil {Pozisyon} - {Boyut}");
            for (int i = 0; i < Pozisyon.Y; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("{0}{1}",new String(' ',Pozisyon.X),new String('-',Boyut.Genislik));
            for (int i = 0; i < Boyut.Yukseklik; i++)
            {
                Console.WriteLine("{0}|{1}|", new String(' ', Pozisyon.X), new String(' ',Boyut.Genislik-2)); ;
            }
            Console.WriteLine("{0}{1}", new String(' ', Pozisyon.X), new String('-', Boyut.Genislik));
        }
        public virtual void Tasi(Pozisyon yeniPozisyon)
        {
            Pozisyon.X = yeniPozisyon.X;
            Pozisyon.Y = yeniPozisyon.Y;
            Ciz();
        }
        public abstract void YenidenBoyutlandir(int yeniGenislik, int yeniYukseklik);
    }
}
