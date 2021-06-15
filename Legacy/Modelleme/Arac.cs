using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Modelleme
{
    public class Arac : Tasit
    {
        #region Fields
        private string marka, model, renk;
        private int yil;
        #endregion

        #region Properties
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Renk { get => renk; set => renk = value; }
        public int Yil { get => yil; set => yil = value; }
        #endregion

        #region Constructors
        public Arac()
        {

        }
        public Arac(string marka, string model, string renk, int yil)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            Yil = yil;
        }
        
        #endregion

        #region Methods
        public void Calistir() =>
            Console.WriteLine("Arac calisti.");
        public void Durdur() =>
            Console.WriteLine("Arac durdu.");

        ///public override string ToString()
        ///{
        ///    Console.WriteLine("{0}",new string('=',15));
        ///    Console.WriteLine($"{this.Marka}");
        ///    Console.WriteLine($"{this.Model}");
        ///    Console.WriteLine($"{this.Renk}");
        ///    Console.WriteLine($"{this.Yil}");
        ///    Console.WriteLine($"{this.Motor}");
        ///    Console.WriteLine($"{this.Hacim}");
        ///    Console.WriteLine("");
        ///    return "";
        ///}
        #endregion



    }
}
