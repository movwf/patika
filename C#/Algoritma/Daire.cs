using System;
using System.Collections.Generic;
using System.Text;

namespace Sayilar
{
    public class Daire
    {
        /// <summary>
        /// Dairenin Alanini Hesaplar
        /// </summary>
        /// <param name="r">Yaricap</param>
        /// <returns>Dairenin alanini doner.</returns>
        public static double Alani(double r)
        {
            return Cember.pi * r * r;
        }
        public static double DilimAlan(double r, int x)
        {
            return Cember.pi * r * r * x / 360;
        }
    }
}
