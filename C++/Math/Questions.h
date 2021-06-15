#include <iostream>
#include "Solutions.cpp"

using namespace std;

namespace Questions{

const char *Data[] = {
    "1 - Mutlak Deger",
    "2 - Buyukten Kucuge",
    "3 - Fibionacci",
    "4 - Dikdortgen",
    "5 - 8x2 Matris",
    "6 - Onluk Diziler",
    "7 - Matriste Asal",
    "8 - 5'te 5",
    "9 - Yuzde Tek",
    "10 - Toplam Overload",
    "11 - Kucukten Buyuge Bin",
    "12 - Bese Bes Sirali",
    "13 - Kare Kup",
    "14 - Manav Envanteri",
    "15 - Yaziyla Iki Basamak",
    "16 - Kelime Uzunlugu",
    "17 - Asal Yazdir",
    "18 - Sirali Dizi",
    "19 - OndanIkiye",
    "20 - Sesli Harfler",
    "21 - Tersten Yaz",
    "22 - Pascal Ucgeni",
    "23 - 4x3 ~ 3x4 -> 4x4",
    "24 - Rant Dizisi",
    "25 - Onluk Tarama",
    "26 - Desen Tarama",
    "27 - Transpoz",
    "28 - Mukemmel Sayi",
    "29 - Onlu Kaydirma",
    "30 - n'e Kadar Kare",
    "31 - Asal Mi ?",
    "32 - Yasakli Cumle",
    "33 - Uc Basamak Karesi",
    "34 - Ikide Bir",
    "35 - Kargocu",
    "36 - Gecti Kaldi",
    "37 - Grafik",
    "38 - Matris Ver",
    "39 - Kosegenler Toplami",
    "40 - Cerceve Toplami"
};

int DataLength(){
    int len = sizeof (Data) / sizeof (Data[0]);
    return len;
}

string getData(int line){
    return Data[line];
}

void RunProgram(int ProgramId){
    switch(ProgramId){
        case 1:
            MutlakDeger();
        break;
        case 2:
            BuyuktenKucuge();
        break;
        case 3:
            Fabionacci();
        break;
        case 4:
            Dikdortgen();
        break;
        case 5:
            SekizIkiMatris();
        break;
        case 6:
            OnlukDiziler();
        break;
        case 7:
            MatristeAsal();
        break;
        case 8:
            BesteBes();
        break;
        case 9:
            YuzdeTek();
        break;
        case 10:
            ToplamOverload();
        break;
        case 11:
            KucuktenBuyugeBin();
        break;
        case 12:
            BeseBesSirali();
        break;
        case 13:
            KareKup();
        break;
        case 14:
            ManavEnvanteri();
        break;
        case 15:
            YaziylaIkiBasamak();
        break;
        case 16:
            KelimeUzunlugu();
        break;
        case 17:
            ArasindaAsalYazdir();
        break;
        case 18:
            SiraliDizi();
        break;
        case 19:
            OndanIkiye();
        break;
        case 20:
            SesliHarfler();
        break;
        case 21:
            TerstenYaz();
        break;
        case 22:
            PaskalUcgeni();
        break;
        case 23:
            DorteUcUceDort();
        break;
        case 24:
            RantDizisi();
        break;
        case 25:
            OnlukDiziTarama();
        break;
        case 26:
            DesenTarama();
        break;
        case 27:
            Transpoz();
        break;
        case 28:
            MukemmelSayi();
        break;
        case 29:
            OnluKaydirma();
        break;
        case 30:
            LimiteKare();
        break;
        case 31:
            AsalMi();
        break;
        case 32:
            YasakliCumle();
        break;
        case 33:
            UcBasamakKare();
        break;
        case 34:
            IkideBir();
        break;
        case 35:
            Kargocu();
        break;
        case 36:
            GectiKaldi();
        break;
        case 37:
            Grafik();
        break;
        case 38:
            MatrisOlustur();
        break;
        case 39:
            KosegenlerToplami();
        break;
        case 40:
            CerceveToplami();
        break;
        default:
            cout<<"|  Out of functions"<<endl;
        break;
    }
}

}
