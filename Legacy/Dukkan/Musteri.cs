using System;

namespace OOP
{
    class Musteri
    {
        private string _adi;
        private int _exp;
        public Musteri(string deneme)
        {
            Console.WriteLine(deneme);
        }
        public string Id { get; } = Guid.NewGuid().ToString();
        public string Adi{ get => _adi; set => _adi = value; }
        public int Yas { get; set; }
        public string Kim => $"{Adi} {Yas}";
        public void ExpArtir(int value)
        {
            _exp += value;
            Console.WriteLine("{0} deneyim puani eklendi.",value);
        }
        public string Seviye {
            get
            {
                if (_exp>100)
                {
                    return "Mudur";
                }else if(_exp==0){
                    return "Tanimsiz";
                }
                else
                {
                    return "Calisan";
                }
            }
            private set
            {
                if (_exp < 0)
                {
                    _exp = 0;
                }
            }
        }
        public void Yazdir ()
        {
            Console.WriteLine("{0}",new string('=',50));
            Console.WriteLine("|| Id : {0}", Id);
            Console.WriteLine("|| Adi : {0}", _adi);
            Console.WriteLine("|| Yasi : {0}", Yas);
            Console.WriteLine("|| Seviye : {0}", Seviye);
            Console.WriteLine("{0}", new string('=', 50));
        }
        public bool EsitMi(int x, int y) => x == y;
        public bool EsitMi(double x, double y) => x == y;
        public bool EsitMi(string x, string y) => x == y;
    }
}
