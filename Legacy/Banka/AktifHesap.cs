using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Banka
{
    public class AktifHesap : ITransfer
    {
        private decimal _bakiye;
        public decimal Bakiye => _bakiye;

        public bool Cek(decimal miktar)
        {
            if (_bakiye >= miktar)
            {
                _bakiye -= miktar;
                return true;
            }
            Console.WriteLine("Bakiye yetersiz!");
            return false;
        }

        public bool TransferYap(IBankaHesap aliciHesap, decimal miktar)
        {
            bool sonuc = Cek(miktar);
            if (sonuc)
            {
                aliciHesap.Yatir(miktar);
            }
            return sonuc;
        }

        public void Yatir(decimal miktar) => _bakiye += miktar;
        public override string ToString() =>
            $"Aktif hesap bakiye bilgisi : {_bakiye,6:C}";
    }
}
