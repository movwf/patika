using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Banka
{
    public class MevduatHesabi:IBankaHesap
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

        public void Yatir(decimal miktar) =>
            _bakiye += miktar;
        public override string ToString() =>
            $"Bakiyeniz : {_bakiye,6:C}";
    }
}
