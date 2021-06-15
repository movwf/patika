using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Banka
{
    public interface IBankaHesap
    {
        void Yatir(decimal miktar);
        bool Cek(decimal miktar);
        decimal Bakiye { get; }
    }
}
