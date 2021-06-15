#include <iostream>
#include <math.h>
#include <list>

using namespace std;

int MutlakDeger(){
    // Girilen sayı ve sonuç için değişkenler ata
    int GirilenSayi, Sonuc;
    // Mutlak değeri alınacak sayıyı iste.
    cout << "| Mutlak Değerinin alınmasını istedğiniz sayıyı girin : ";
    cin >> GirilenSayi;
    // Eğer girilen sayı 0 dan küçük ise -1 ile çarp veya büyük ise olduğu halinde göster.
    Sonuc = GirilenSayi<0 ? GirilenSayi * -1 : GirilenSayi;
    // Sonucu yazdır.
    cout << "| Sonuc : " << Sonuc << endl;

    return 0;
}

int BuyuktenKucuge(){
    // Sayılar ve sonuç için değişkenleri ata.
    int Sayilar[3], Tarama = 1, Gecici;

    // Sayıları kullanıcıdan al
    for(int i = 0; i < 3; i++){
       cout << "| " << i + 1 << ". Sayıyı Girin : ";
       cin >> Sayilar[i];
    }

    // Büyükten küçüğe sıralayarak diziyi güncelle
    while(Tarama < 3){
        for(int i = 0; i < 2; i++){
            if(Sayilar[i] < Sayilar[i+1]){
                Gecici = Sayilar[i];
                Sayilar[i] = Sayilar[i+1];
                Sayilar[i+1] = Gecici;
            }
        }
        Tarama ++;
    }

    // Sonucu yazdır
    cout << "| Sonuç : [ ";

    // Diziyi ekrana yazdır
    for(int i = 0; i < 3; i++){
        cout << Sayilar[i]<<" ";
    }

    cout << "]" << endl;

    return 0;
}

int Fabionacci(){
    // Fabionacci sayı adedi ve iterasyon sayılarını tanımlayalım.
    int Limit, Sayi1 = 0, Sayi2 = 1, Sonraki = 0;

    // Adedi alalım.
    cout << "| Limit değerini girin : ";
    cin >> Limit;

    cout << "| Fibonacci : ";

    for (int i = 1; i <= Limit; ++i) {
        // Ilk ikisini yazdırır.
        if(i == 1) {
            cout << Sayi1 << ", ";
            continue;
        }
        if(i == 2) {
            cout << Sayi2 << ", ";
            continue;
        }
        // Devam eden sayıyı 2 sayıyı toplayarak oluştur. Ve sayıları yerleştir.
        Sonraki = Sayi1 + Sayi2;
        Sayi1 = Sayi2;
        Sayi2 = Sonraki;

        cout << Sonraki << ", ";
    }

    cout << endl;

    return 0;
}

int Dikdortgen(){
    // Dikdörtgen değerlerini ata
    int a, b, alan, cevre, kosegen;

    // Kısa kenar değerini al.
    cout << "| Lütfen dikdörtgenin kısa kenar uzunluğunu girin : ";
    cin >> a;

    // Uzun kenar değerini al.
    cout << "| Lütfen dikdörtgenin uzun kenar uzunluğunu girin : ";
    cin >> b;

    // Alanı hesapla ve ekrana yazdır
    alan = a * b;
    cout << "| Alan : "<<alan<<" br²"<<endl;

    // Çevreyi hesapla ve ekrana yazdır
    cevre = 2 * (a + b);
    cout << "| Çevre : "<<cevre<<" br"<<endl;

    // Kosegen hesapla ve ekrana yazdır
    kosegen = sqrt( pow(a , 2) + pow(b , 2) );
    cout << "| Kosegen : "<<kosegen<<" br"<<endl;

    return 0;
}

int SekizIkiMatris(){
    // Matrisi tanımla
    int Matris[8][2], Baslangic = 16 ;

    // Matrisi doldur
    for(int i = 0; i < 8; i++){
        for(int k = 0; k < 2; k++){
            Matris[i][k] = Baslangic;
            Baslangic --;
        }
    }

    // Matrisi ekrana yazdır
    cout<<"| Matris : "<<endl;
    for(int i = 0; i < 8; i++){
        for(int k = 0; k < 2; k++){
            cout<<Matris[i][k]<<(Matris[i][k]<10?"  ":" ");
        }
        cout<<endl;
    }


    return 0;
}

int OnlukDiziler(){
    // Dizileri tanımla
    int Dizi1[] = {7,5,15,3,8,2,10,13,11,1};
    int Dizi2[] = {2,6,20,1,7,5,11,4,3,9};
    int Sonuc[10];

    // Eslenen her bir sayıyı karşılaştır
    for(int i = 0; i < 10; i++){
        Sonuc[i] = (Dizi1[i] < Dizi2[i])
                ? Dizi2[i]
                  : Dizi1[i] ;
    }

    // İlk diziyi yazdır
    cout<<"| 1. dizi   : ";
    for(int i = 0; i < 10; i++){
        cout<<Dizi1[i]<<" ";
    }
    cout<<endl;

    // İkinci diziyi yazdır
    cout<<"| 2. dizi   : ";
    for(int i = 0; i < 10; i++){
        cout<<Dizi2[i]<<" ";
    }
    cout<<endl;

    // Yeni listeyi ekrana yazdır
    cout<<"| Yeni dizi : ";
    for(int i = 0; i < 10; i++){
        cout<<Sonuc[i]<<" ";
    }
    cout<<endl;

    return 0;
}

int MatristeAsal(){
    // Matrisi tanımla
    int Matris[5][2] = {
        {1,13},
        {17,8},
        {9,21},
        {5,63},
        {13,12}
    };
    // En Büyük Asal sayıyı tanımla
    int BuyukAsal= 0 , netice;

    // Matris içerisinde bulunan en büyük asal sayıyı bul ve Secilen'e ata.
    for(int i = 0; i < 5; i++){
        for(int k = 0; k < 2; k++){
            // Seçilen sayıyı bir değişkene ata
            int Secilen = Matris[i][k];
            // Eğer sayı 0 veya 1 degilse asallığı sorgula
            if( Secilen == 0 || Secilen == 1 ){
                BuyukAsal = 0;
                break;
            }else{
                // Seçilen sayının 2'den sayının yarısına kadar olan sayılarla alınan modu 0 a eşit değilse asal sayıdır.
                for (int j = 2; j <= Secilen / 2; j++) {
                    if (Secilen % j == 0) {
                        BuyukAsal = BuyukAsal != 0
                                ? BuyukAsal
                                : 0;
                        break;
                    }else{
                        // Eğer sayı asal ve bir önceki en büyük asal sayıdan da büyükse yeni değeri ata.
                        BuyukAsal = Secilen > BuyukAsal
                                ? Secilen
                                : BuyukAsal;
                        break;
                    }
                }
            }
        }
    }

    // En büyük asal sayı değerini "netice" değişkenine ata.
    netice = BuyukAsal;

    // Ekrana yazdır
    cout<<"|  Seçilen : "<<netice<<endl;


    return 0;
}

int BesteBes(){
    // 5 adet 5'lik dizi ve netice değişkenini ata.
    int Dizi1[5]= {1,2,3,4,5},
        Dizi2[5] = {6,7,8,9,10},
        Dizi3[5] = {11,12,13,14,15},
        Dizi4[5] = {16,17,18,19,20},
        Dizi5[5] = {21,22,23,24,25};
    int netice = 0;

    // Dizinin elemanlarını toplayıp netice değişkenine ata
    for(int i = 0; i < 5; i++){
        netice += (Dizi1[i] + Dizi2[i] + Dizi3[i] + Dizi4[i] + Dizi5[i]);
    }

    // Netice'yi ekrana yazdır
    cout<<"| Netice : "<<netice<<endl;


    return 0;
}

int YuzdeTek(){
    // Tek sayı listesi ve limit
    list <int> TekSayi;

    // 1'den 100'e kadar olan sayıları seç
    for(int i = 1; i < 100; i++){
        // Tek haneli ise tek olan sayılar
        if(i < 10){
            if(i % 2 != 0){
                TekSayi.push_back(i);
            }
        }else{
            // Çift haneli ise
            // Basamak toplamını hesapla
            int Hesapla = ((i/10) + (i%10)) % 2;
            // Eğer basamak toplamı tek sayı ise -> 1
            if(Hesapla == 1){
                TekSayi.push_back(i);
            }
        }
    }

    // Listeyi yazdır
    cout<<"|  Tek sayı listesi : "<<endl;
    list<int>::iterator it;
    for(it = TekSayi.begin(); it != TekSayi.end(); ++it){
        cout<<"| - "<<*it<<endl;
    }

    return 0;
}

int Islem(int Sayi1, int Sayi2, bool Toplama){
    return Toplama
            ? Sayi1 + Sayi2
            : 0;
}
int Islem(int Sayi1, int Sayi2){
    return Sayi1 - Sayi2;
}
int ToplamOverload(){
    // Alınacak iki sayı için değişken ata
    int Sayi1, Sayi2, Sonuc;
    string Cevap;

    // Değerleri kullanıcıdan al
    cout << "|  1. Sayıyı Girin : ";
    cin >> Sayi1;

    cout << "|  2. Sayıyı Girin : ";
    cin >> Sayi2;

    cout << "| Toplama mı? (e/h) :";
    cin >> Cevap;

    // Eğer toplama onaylanırsa
    if(Cevap=="e"){
        Sonuc = Islem(Sayi1,Sayi2,true);
    }else{
        Sonuc = Islem(Sayi1,Sayi2);
    }

    // Sonucu yazdır
    cout<<"|  Sonuç : "<<Sonuc<<endl;


    return 0;
}

int KucuktenBuyugeBin(){
    // Dizi ve tasiyici atayın
    int Dizi[1000], DiziIndex = 0, Gecici;
    string Tasiyici;

    // Atanacak değerleri al
    while(true){
        cout<<"| Bir sayı girin veya durmak için \"e\" yazın : ";
        cin>>Tasiyici;
        // Eğer çıkmak istiyorsa veri alımını durdur.
        if(Tasiyici=="e"){break;}
        // Sayı 1-1000 arasında olmalı
        else if(stoi(Tasiyici) > 0 && stoi(Tasiyici) < 1000){
            Dizi[DiziIndex] = stoi(Tasiyici);
            Dizi[DiziIndex+1] = 0;
            for(int i = 0; i < DiziIndex; i++){
                for(int k = i+1; k < DiziIndex+1; k++){
                    // Eğer 1. sayı 2. sayıdan büyükse yer değiştir.
                    if(Dizi[i]>Dizi[k]){
                        Gecici = Dizi[i];
                        Dizi[i] = Dizi[k];
                        Dizi[k] = Gecici;
                    }
                }
            }
            // Atanan değer ve indexini yazdır.
            cout<<"|  Dizi["<<DiziIndex<<"] : "<<Dizi[DiziIndex]<<endl;
            // İterasyon için 1 arttır.
            DiziIndex++;
        }else{break;}
    }

    // Diziyi Görüntüle
    cout<<"|  Dizi : [";
    for(int i = 0; i < DiziIndex ; i++){
        cout<<Dizi[i]<<" ";
    }
    cout<<endl;

    return 0;
}

int BeseBesSirali(){
    // 5'e 5 bir matris oluştur
    int Matris[5][5] = {
        {13,2,1,5,4},
        {3,7,25,21,20},
        {6,23,17,12,8},
        {9,10,11,22,15},
        {14,16,18,19,0}
    };
    int Kucuk, Buyuk, SecilenAdres[2];

    // Matrisi Yazdır
    cout<<"| Matris : "<<endl;
    for(int i = 0; i < 5; i++){
        cout<<"| {";
        for(int k = 0; k < 5; k++){
            cout<<Matris[i][k]<<",";
        }
        cout<<"},"<<endl;
    }

    // En büyük sayıyı ve adresini bul
    while(true){
        int Secilen = Matris[1][1];
        for(int i = 0; i < 5; i++){
            for(int k = 0; k < 4; k++){
                if(Secilen<Matris[i][k+1]){
                    Secilen = Matris[i][k+1];
                    // Adres bilgisini al {i,k}
                    SecilenAdres[0] = i;
                    SecilenAdres[1] = k+1;
                    Buyuk = Secilen;
                }
            }
        }
        break;
    }

    // En büyük değeri adresiyle beraber yazdır
    cout<<"|  En Büyük Değer : "<<Buyuk<<" Adres : ["<<SecilenAdres[0]<<","<<SecilenAdres[1]<<"]"<<endl;

    // En küçük sayıyı ve adresini bul
    while(true){
        int Secilen = Matris[1][1];
        for(int i = 0; i < 5; i++){
            for(int k = 0; k < 4; k++){
                if(Secilen>Matris[i][k+1]){
                    Secilen = Matris[i][k+1];
                    // Adres bilgisini al {i,k}
                    SecilenAdres[0] = i;
                    SecilenAdres[1] = k+1;
                    Kucuk = Secilen;
                }
            }
        }
        break;
    }

    // En küçük değeri adresiyle beraber yazdır
    cout<<"|  En Küçük Değer : "<<Kucuk<<" Adres : ["<<SecilenAdres[0]<<","<<SecilenAdres[1]<<"]"<<endl;

    return 0;
}

int KareKup(){
    // Sonuçlar için matris oluştur.
    int Matris[10][3] = {};
    int Satir = 0, Deger, Karesi, Kupu;

    while(true){
        string option;

        // Sayıyı iste
        cout<<"|  Lütfen bir sayı girin veya çıkış yapın (\"K\") : ";
        cin>>option;
        if(option=="K"){break;}
        // Değeri ekle
        Deger = stoi(option);
        Matris[Satir][0] = Deger;
        // Karesini ekle
        Karesi = pow(Deger,2);
        Matris[Satir][1] = Karesi;
        // Küpünü ekle
        Kupu = pow(Deger,3);
        Matris[Satir][2] = Kupu;

        cout<<"Değeri     Karesi     Küpü      "<<endl;
        cout<<string(32,'-')<<endl;


        // Sonuçları ekrana yazdır
        for(int i = 0; i < Satir + 1; i++ ){
            // Her bir değeri yan yana yazdır.
            cout<<Matris[i][0]<<string((10-to_string(Matris[i][0]).length()),' ')<<" ";
            cout<<Matris[i][1]<<string((10-to_string(Matris[i][1]).length()),' ')<<" ";
            cout<<Matris[i][2]<<string((10-to_string(Matris[i][2]).length()),' ')<<endl;
        }

        // Bir sonraki satıra geç
        Satir ++;
    }

    return 0;
}

int ManavEnvanteri(){
    // Depoyu fulleyelim
    string Meyveler[10] = {
        "Muz", "Elma", "Şeftali", "Kivi", "Mandalina", "Erik", "Çilek", "Domates", "Mango", "Portakal"
    };

    while(true){
        string option, Sonuc;

        // Meyve İsmi Alalım
        cout<<"|  Meyve ismi giriniz veya çıkış (\"e\") : ";
        cin>>option;

        if(option=="e"){break;}

        // Stokları kontrol edelim eğer yoksa sipariş geçelim
        for(int i = 0; i < 10; i++){
            if(Meyveler[i]==option){
                Sonuc = "|  Stokta mevcut.";
                break;
            }else{
                Sonuc = "|  Sipariş geçildi.";
            }
        }

        // Sonucu ekrana yazdır
        cout<<Sonuc<<endl;
    }




    return 0;
}

int YaziylaIkiBasamak(){
    // Sayıyı iki parçaya ayırmak için değişken atayalım
    int Onlar, Birler;
    // Basamakların sözel hallerini bir diziye kaydedelim.
    string YaziylaOnlarBasamagi[9] = {
        "on","yirmi","otuz","kırk","elli","altmış","yetmiş","seksen","doksan"
    };
    string YaziylaBirlerBasamagi[9] = {
        "bir","iki","üç","dört","beş","altı","yedi","sekiz","dokuz"
    };
    string Sonuc = "";

    // Kullanıcıdan bir sayı isteyelim (10-99)
    int option;

    cout<<"| Lütfen sayı giriniz : ";
    cin>>option;

    // Sayı aralığını sorgulayalım
    if(option >= 10 && option < 100){
        Onlar = option / 10;
        Birler = option % 10;

        // Eğer 10'un katlarıysa
        if(Birler == 0){
            Sonuc = YaziylaOnlarBasamagi[Onlar-1] ;
        }else{
            // Basamakları yazıya çevirelim.
            Sonuc += YaziylaOnlarBasamagi[Onlar-1] + " ";
            Sonuc += YaziylaBirlerBasamagi[Birler-1];
        }

        // Sonucu yazdıralım
        cout<<"|  Sayi : "<<option<<" Yazıyla : "<<Sonuc<<endl;

    }else{
        cout<<"| Lütfen 10-100 aralığında bir sayı girerek tekrar deneyin.";
    }


    return 0;
}

int KelimeUzunlugu(){
    int Uzunluk=0;

    // Kelimeyi alalım
    string input;

    cout<<"| Lütfen bir kelime giriniz : ";
    cin>>input;

    // Uzunluğunu hesaplayalım.
    for(int i = 0; i < (int)input.length(); i++){
        Uzunluk++;
    }

    // Ekrana yazdıralım
    cout<<"|  Uzunluk : "<<Uzunluk<<endl;


    return 0;
}

int ArasindaAsalYazdir(){
    // Alınacak iki sayıyı belirleyelim
    int Sayi1, Sayi2, Bolen = 2;
    bool AsalMi = true;

    // Sayıları alalım
    cout << "| 1. Sayıyı girin ( Alt Limit - En az 2 ) : ";
    cin >> Sayi1;

    cout << "| 2. Sayıyı girin ( Üst Limit ) : ";
    cin >> Sayi2;

    // Asal olan sayıları yazdıralım
    for(int i = Sayi1; i < Sayi2;i++){
        while(Bolen < i){
            if(i==2){ cout<<"| - 2"<<endl; }

            if(i % Bolen == 0){
                AsalMi = false;
                break;
            }else{
                AsalMi = true;
            }
            Bolen++;
        }
        Bolen = 2;
        // Asal olan sayıyı yazdıralım
        if(AsalMi){
            cout<<"|  - "<<i<<endl;
        }
    }


    return 0;
}

int SiraliDizi(){
    // 4'e 4'luk matris oluşturalım
    int Matris[4][4] = {
        {1,4,7,9},
        {5,6,9,2},
        {2,7,3,8},
        {3,5,8,6}
    };
    int Gecici[4] = {};
    int OncekiSatir, SatirToplam = 0;

    // Orjinal Matrisi Yazdır
    cout<<"| Orjinal Matris "<<endl;
    for(int i = 0; i < 4; i++){
        for(int k = 0; k < 4; k++){
            cout<<Matris[i][k]<<" ";
        }
        cout<<endl;
    }

    // Satır Değerlerini Topla
    for(int i = 0; i < 4; i++){
        OncekiSatir = Matris[i][0] +  Matris[i][1] +  Matris[i][2] +  Matris[i][3];
        for(int k = i+1; k < 4; k++){
            SatirToplam = Matris[k][0] +  Matris[k][1] +  Matris[k][2] +  Matris[k][3];
            if(OncekiSatir>SatirToplam){
                // Yer değiştir
                Gecici[0] = Matris[i][0];
                Gecici[1] = Matris[i][1];
                Gecici[2] = Matris[i][2];
                Gecici[3] = Matris[i][3];

                Matris[i][0] = Matris[k][0];
                Matris[i][1] = Matris[k][1];
                Matris[i][2] = Matris[k][2];
                Matris[i][3] = Matris[k][3];

                Matris[k][0] = Gecici[0];
                Matris[k][1] = Gecici[1];
                Matris[k][2] = Gecici[2];
                Matris[k][3] = Gecici[3];

                break;
            }
        }
    }

    // Yeni Matrisi Yazdır
    cout<<"| Yeni Matris "<<endl;
    for(int i = 0; i < 4; i++){
        for(int k = 0; k < 4; k++){
            cout<<Matris[i][k]<<" ";
        }
        cout<<endl;
    }

    return 0;
}

int OndanIkiye(){
    // Alınacak değer için değişken ata
    int Sayi;
    string Ikili;

    // Dönüştürülecek Değeri Al
    cout<<"|  Lütfen dönüştürülecek değeri girin : ";
    cin>>Sayi;

    // 10'dan 2'lik tabana çevir

    while(true){
        Ikili += to_string(Sayi % 2);
        if(Sayi<2){break;}
        Sayi = Sayi / 2;
    }

    // 2'lik tabanda sayıyı yazdır
    cout<<"|  2'lik tabanda karşılığı : "<<Ikili<<endl;

    return 0;
}

int SesliHarfler(){
    // Bir sesli harf dizisi oluşturalım.
    char16_t Sesli[] = {'a','e',u'ı','i','o',u'ö','u',u'ü'};
    int SesliHarfSayisi = 0;
    string Cumle;

    // Cumleyi alalım
    cout<<"|  Lütfen bir cumle yazın : ";
    cin>>Cumle;
    // Eğer cümle 20 karakterden uzunsa programı bitir.
    if(Cumle.length()>20){ return 0;}

    // Sesli harfleri sayalım.
    for(int i = 0; i < (int)(Cumle.length()); i++){
        // Her bir harfi sesli harf listesinde ara
        for(int k=0; k < (int)(sizeof (Sesli)/sizeof (Sesli[0]));k++){
            // Kaç harfin küçük hali sesli dizisinde varsa Sesli harf sayısını arttır.
            if(Cumle[i]==Sesli[k]){
                SesliHarfSayisi++;
                break;
            }
        }
    }
    // Sesli harf sayısını yazdıralım.
    cout<<"|  Sesli harf sayısı : "<<SesliHarfSayisi<<endl;

    return 0;
}

int TerstenYaz(){
    // Cumle ve tersi için bir değişken atayalım.
    string Cumle, TersCumle;

    // Cumleyi alalım
    cout<<"|  Lütfen bir cumle yazın : ";
    cin>>Cumle;
    // Eğer cümle 20 karakterden uzunsa programı bitir.
    if(Cumle.length()>20){ return 0;}

    // Cümleyi tersine çevirelim
    for(int i = Cumle.length();i >= 0 ;i--){
        TersCumle += (char32_t)Cumle[i];
    }

    // Cümleyi ekrana yazdıralım
    cout<<"| Cümlenin ters hali : "<<TersCumle<<endl;

    return 0;
}

int PaskalUcgeni(){
    int BasamakSayisi, Sayi = 1;

    cout << "| Lütfen istediğiniz basamak sayısını girin : ";
    cin >> BasamakSayisi;

    for(int i = 0; i < BasamakSayisi; i++){
        // Boşlukları yazdır.
        for(int bosluk = 1; bosluk <= BasamakSayisi-i; bosluk++) {cout <<"  ";}
        // Rakamları yazdıralım
        for(int j = 0; j <= i; j++){
            // Eğer başta ve sondaysa 1 yaz
            if (j == 0 || i == 0) {Sayi = 1;}
            // Değilse
            else{ Sayi = Sayi * ( i - j + 1 ) / j; }
            // Sayılar arasında boşluk yaz.
            cout << Sayi << "   ";
        }
            cout << endl;
    }

    return 0;
}

int DorteUcUceDort(){
    // 4x3, 3x4 ve 4x4 matrisleri oluşturalım.
    int DorteUc[4][3] = {
        {1,2,3},
        {4,5,6},
        {7,8,9},
        {1,2,3}
    };
    int UceDort[3][4] = {
        {1,2,3,4},
        {5,6,7,8},
        {9,1,2,3}
    };
    int Sonuc[4][4];

    // Matrisleri ekrana yazdıralım
    cout<<"|--4x3 Matris"<<endl;
    for(int i = 0; i < 4; i++){
        for(int k = 0; k < 3; k++){
            cout<<DorteUc[i][k]<<" ";
        }
        cout<<endl;
    }
    cout<<"|--3x4 Matris"<<endl;
    for(int i = 0; i < 3; i++){
        for(int k = 0; k < 4; k++){
            cout<<UceDort[i][k]<<" ";
        }
        cout<<endl;
    }

    // Çarpma işlemini yapalım
    for(int i = 0; i< 4; i++){
        // İlk satırdan başlayalım
        for(int k = 0; k < 4; k++){
            Sonuc[i][k] = DorteUc[i][k] * UceDort[k][i];
        }
    }

    // Sonucu gösterelim
    cout<<"|--Sonuc ( 4x4 )"<<endl;
    for(int i = 0; i < 4; i++){
        for(int k = 0; k < 4; k++){
            cout<<Sonuc[i][k]<<(Sonuc[i][k]>=10?string(2,' '):string(3,' '));
        }
        cout<<endl;
    }


    return 0;
}

int RantDizisi(){
    // Girilecek sayı ve 10'luk diziyi tanımlayalım.
    int Dizi[10] = {}, Sayi;
    int SonIndex = 0, Gecici, Fark = 0, YeniFark, RantIndex;

    // Değerleri alalım
    while(true){
        cout<<"|  Lütfen eklenecek değeri girin : ";
        cin>>Sayi;

        // Girilen değeri diziye kaydet
        Dizi[SonIndex] = Sayi;
        SonIndex ++;

        // Diziyi küçükten büyüğe sırala
        for(int i = 0; i < SonIndex ; i++){
            if(Dizi[i+1] != 0 && Dizi[i] > Dizi[i+1]){
                // Bir sonraki değer ile yer değiştir
                Gecici = Dizi[i+1];
                Dizi[i+1] = Dizi[i];
                Dizi[i] = Gecici;
             }
        }

        // Eğer dizi dolmuşsa
        if(SonIndex==10){
            // Diziyi göster
            cout<<"| Oluşturulan dizi : [";
            for(int i = 0; i < 10; i++){
                cout<<Dizi[i]<<" ,";
            }
            cout<<"]"<<endl;

            // Dizideki elemanlar arası en büyük farkı bul
            for(int i = 0; i < SonIndex; i++){
                if(i != SonIndex - 1){
                    YeniFark = Dizi[i+1] - Dizi[i];
                    if(YeniFark > Fark){
                        Fark = YeniFark;
                        RantIndex = i;
                    }
                }
            }

            // Farkı yazdır
            cout<<"| Dizinin "<<RantIndex<<". indisinden "
                <<(RantIndex+1)<<". indisine geçerken "
                <<Fark<<" birimlik artış yaşanmıştır."<<endl;

            break;
        }
    }

    return 0;
}

int OnlukDiziTarama(){
    // Girilecek sayı ve 10'luk diziyi tanımlayalım.
    int Dizi[10] = {}, Sayi;
    int SonIndex = 0;

    // Değerleri alalım
    while(true){
        cout<<"|  Lütfen eklenecek değeri girin : ";
        cin>>Sayi;

        // Eğer sayı mevcutsa uyarı ver.
        for(int i = 0; i < 10; ++i){
            if(Sayi == Dizi[i]){
                cout<<"|  Girdiğiniz değer dizi'de mevcut.";
                break;
            }else{
                if(i==9){
                    Dizi[SonIndex] = Sayi;
                    SonIndex++;
                }
            }
        }
        if(SonIndex == 10){break;}
    }

    // Diziyi göster
    cout<<"| Oluşturulan dizi . [";
    for(int i = 0; i < 10; i++){
        cout<<Dizi[i]<<" ,";
    }
    cout<<"]"<<endl;

    return 0;
}

int DesenTarama(){
    // Desen için bir matris tanımlayalım
    char Desen[15][15];

    // a = b vektörünü tarayalım
    for(int i = 0; i < 15; i++){
        Desen[i][i] = '*';
    }

    // a = b ters diyagonalını çizelim
    for(int i = 0; i< 15; i++){
        Desen[i][14-i] = '*';
    }

    // Yatayda kenarortay çiz
    for(int i = 0; i< 15; i++){
        Desen[7][i] = '*';
    }

    // Dikeyde kenarortay çiz
    for(int i = 0; i< 15; i++){
        Desen[i][7] = '*';
    }

    // Yıldız olmayan kısımları boşlukla doldur
    for(int i = 0; i < 15; i++){
        for(int k = 0; k < 15; k++){
            if(Desen[i][k] != '*'){
                Desen[i][k] = ' ';
            };
        }
    }
    // Bugfix
    Desen[4][12] = ' ';

    // Deseni ekrana yazdır.
    cout<<"|--Desen"<<endl;
    for(int i = 0; i < 15; i++){
        for(int k = 0; k < 15; k++){
            cout<<Desen[i][k]<<" ";
        }
        cout<<endl;
    }

    return 0;
}

int Transpoz(){
    // 3x3 ve Sonuc Matrisini tanımla
    int Matris[3][3], Transpoz[3][3];

    // Matrise değerleri ekle
    for(int i = 0; i < 3; i++){
        for(int k = 0; k < 3; k++){
            cout<<"|  Lütfen eklenecek değeri girin : ";
            cin>>Matris[i][k];
        }
    }

    // Matrisi göster
    cout<<"|--Matris :"<<endl;
    for(int i = 0; i < 3; i++){
        for(int k = 0; k < 3; k++){
            cout<<Matris[i][k]<<" ";
        }
        cout<<endl;
    }
    cout<<endl;

    // Transpozunu al
    for(int i = 0; i < 3; i++){
        for(int k = 0; k < 3; k++){
            Transpoz[k][i] = Matris[i][k];
        }
    }


    // Transpoz matrisi göster
    cout<<"|--Transpoz Matris :"<<endl;
    for(int i = 0; i < 3; i++){
        for(int k = 0; k < 3; k++){
            cout<<Transpoz[i][k]<<" ";
        }
        cout<<endl;
    }

    return 0;
}

int MukemmelSayi(){
    // Alınacak sayı ve toplam için değişken ata
    int Sayi ,Toplam = 0;

    // Sayıyı alalım
    cout<<"|  Bir sayı girin : ";
    cin>>Sayi;

    // Tam bölenleri göster
    cout<<"|  "<<Sayi<<" sayısının kendisi hariç pozitif tam bölenleri; ";
    for(int i = 1; i < Sayi; i++) {
        if(Sayi % i == 0) {
            cout<<i<<", ";
            Toplam += i;
        }
    }
    cout<<endl;

    // Mükemmel olmaklığını sorgula ve ekrana yazdır.
    if(Toplam == Sayi) {
        cout<<"|  Sonuç : Mükemmel"<<endl;
    }else{
        cout<<"|  Sonuç : Sıradan"<<endl;
    }

    return 0;
}

int OnluKaydirma(){
    // Onluk dizi ve kaydirma indexini tanimla
    int Dizi[10] = {}, Sayi, Index = 0;

    // Değerleri al
    while(true){
        cout<<"|  Bir sayı girin : ";
        cin>>Sayi;

        if(Sayi==0){break;}

        // Dizi üzerinde tarama yap
        for(int i = Index; i >= 0; i--){
            if(i == 0){ Dizi[i] = Sayi; break; }
            // Diziyi sonun kadar sağa kaydır
            Dizi[i] = Dizi[i - 1];
        }
        if(Index < 9){Index++;}
    }

    // Diziyi yazdır
    cout<<"|--Dizi : [";
    for(int i = 0; i < 10; i++){
        cout<<Dizi[i]<<",";
    }
    cout<<"]"<<endl;

    return 0;
}

int LimiteKare(){
    // Limit değeri için değişken ata
    int Limit;

    // Limit değerini al
    cout<<"|  Lütfen limit değerini giriniz : ";
    cin>>Limit;


    // Limit değerine kadar olan sayıların karelerini yazdır
    for(int i = 1; i < Limit; i++){
        cout<<(i*i)<<endl;
    }


    return 0;
}

int AsalMi(){
    // Kontrol edilecek Sayı değişkenini ata
    int Sayi;

    // Değeri al
    cout<<"|  Lütfen sayıyı giriniz : ";
    cin>>Sayi;

    // Asallık Kontrolü Yapalım
    for(int i = 2; i < Sayi;i++){
        if(Sayi==2){ cout<<"| Sonuc : ASAL"<<endl; break; }
        if(Sayi % i == 0){
            cout<<"|  Sonuc : ASAL DEĞİL"<<endl;
            break;
        }else if(Sayi % i != 0 && i == Sayi - 1){
            cout<<"|  Sonuc : ASAL"<<endl;
        }
    }

    return 0;
}

int YasakliCumle(){
    // Cumle ve geçici harf listesi için değişken ata
    string Cumle, Gecici;

    // Cumleyi al
    cout<<"|  Lütfen cümleyi giriniz : ";
    cin>>Cumle;

    // Cümle 10 karakterden uzak ise programı sonlandır.
    if(Cumle.length()>10){return 0;}

    // Cümleyi kırp
    for(int i = 0; i < (int)Cumle.length(); i++){
        for(int k = i + 1; k < (int)Cumle.length(); k++){
            if(Cumle[i]==Cumle[k]){break;}
            else{
                Gecici += Cumle[i];
                break;
            }
        }
    }

    // Sonucu yazdır
    cout<<"|--Kırpılmış hali : "<<Gecici<<endl;

    return 0;
}

int UcBasamakKare(){
    // Alınacak sayı, karelerin toplamı ve basamak değerleri için değişken ata
    int Sayi, KareToplam = 0, Basamak;

    // Değeri al
    cout<<"| Basamaklarının karesi alınacak sayıyı girin (100-999) : ";
    cin>>Sayi;

    // Basamaklarına ayır ve karelerini al
    for(int i = 0; i < 3; i++){
        // Basamak değerini hesapla
        Basamak = (int)(Sayi % 10);
        Sayi /= 10;
        KareToplam += Basamak * Basamak;
    }

    // Sonucu yazdır
    cout<<"|--Karelerin toplamı : "<<KareToplam<<endl;

    return 0;
}

int IkideBir(){
    // Karşılaştırılacak sayılar için değişken ata.
    int a, b;

    // Değerleri al
    cout<<"|  a sayısının değerini girin : ";
    cin>>a;
    cout<<"|  b sayısının değerini girin : ";
    cin>>b;

    // Karşılaştırmayı yap
    if(a == 2 * b){cout<<"|--"<<a<<" sayısı "<<b<<" sayısının 2 katıdır."<<endl;}
    else{cout<<"|--"<<a<<" sayısı "<<b<<" sayısının 2 katı değildir."<<endl;};

    return 0;
}

int Kargocu(){
    // Ücret ve ağırlık bilgileri için değişken ata.
    int Ucret, Agirlik;
    double AgirlikFazlasi;

    // Ağırlık değerini al.
    cout<<"|  Kargonuz kaç gr ? : ";
    cin>>Agirlik;

    if(Agirlik <= 150){
        Ucret = 10;
    }else{
        AgirlikFazlasi = Agirlik - 150;
        // Her 25gr fazlası için ücret hesapla
        Ucret = 10 + ceil(AgirlikFazlasi/25) * 2;
    }

    // Ucreti ekrana yaz
    cout<<"|--Ücret : "<<Ucret<<endl;

    return 0;
}

int GectiKaldi(){
    // Notlar için değişken ata.
    int N1, N2, N3;

    // Notların değerini al.
    cout<<"|  1. Notu giriniz : ";
    cin>>N1;
    cout<<"|  1. Notu giriniz : ";
    cin>>N2;
    cout<<"|  1. Notu giriniz : ";
    cin>>N3;

    // Geçti/Kaldı hesapla
    if((N1 * 0.3 + N2 * 0.2 + N3 * 0.5) >= 70){
        cout<<"|--Sonuç : GEÇTİ"<<endl;
    }else{
        cout<<"|--Sonuç : KALDI"<<endl;
    }


    return 0;
}

int Grafik(){
    // Fonksiyona göre alınacak değer hesapla
    double Sayi;

    // Değeri al
    cout<<"|  Fonksiyona girilecek değeri girin : ";
    cin>>Sayi;


    // Hesapla
    if(Sayi >= -6 && Sayi < 0){
        // [-6,0) -> 1
        cout<<"|--f("<<Sayi<<") = 1"<<endl;
    }else if(Sayi >= 0 && Sayi <= 2){
        // [0,2) -> [0,2)
        cout<<"|--f("<<Sayi<<") = "<<Sayi<<endl;
    }else if(Sayi > 2 && Sayi < 4){
        // [2,4) -> 3
        cout<<"|--f("<<Sayi<<") = 3"<<endl;
    }else if(Sayi >= 4 && Sayi <= 6){
        // [4,6] -> 0~-2
        cout<<"|--f("<<Sayi<<") = "<<(Sayi-4)*-1<<endl;
    }

    return 0;
}

int** MatrisYap(int Satir, int Sutun){
    int** Matris = new int*[Satir];
    int AtancakDegerler[20] = {0,0,0,0,0,1,2,3,0,2,4,6,0,3,6,9,0,4,8,12};

    // Matrisi doldur
    for(int i = 0; i < Satir; i++){
        Matris[i] = new int[Sutun];
        for(int k = 0; k < Sutun; k++){
            Matris[i][k] = AtancakDegerler[i*4+k];
        }
    }
    return Matris;
}
int MatrisOlustur(){
    int** a;

    a = MatrisYap(5,4);

    // Matrisi yazdır
    cout<<"|--Matris : "<<endl;
    for(int i = 0; i < 5; i++){
        for(int k = 0; k < 4; k++){
            cout<<a[i][k]<<" ";
        }
        cout<<endl;
    }

    return 0;
}

int KosegenlerToplami(){
    // Matris ve köşegenler toplamı için değişken ata
    int Matris[4][4] = {};
    int Toplam = 0;

    // Matrisi doldur
    for(int i = 0; i < 4; i++){
        for(int k = 0; k < 4; k++){
            cout<<"|  Matris("<<i<<","<<k<<") değerini girin : ";
            cin>>Matris[i][k];
            // Kosegenleri topla
            if(i == k || (i  + k == 3)){
                Toplam += Matris[i][k];
            }
        }
    }

    // Toplamı yazdır
    cout<<"|--Köşegenler toplamı : "<<Toplam<<endl;

    return 0;
}

int CerceveToplami(){
    // Matris ve çevre toplamı için değişken ata
    int Matris[4][4] = {};
    int Toplam = 0, Satir = 4, Sutun = 4;

    // Matrisi doldur
    for(int i = 0; i < 4; i++){
        for(int k = 0; k < 4; k++){
            cout<<"|  Matris("<<i<<","<<k<<") değerini girin : ";
            cin>>Matris[i][k];
        }
    }

    // Çevreyi topla
    for(int i = 0; i < 4; i++){
        for(int k = 0; k < 4; k++){
                // Ust ve alt parçalar
                if(i == 0 || i == 3){
                    Toplam += Matris[i][k];
                }
                // Sağ ve sol parçalar
                if(k == 0 || k == 3){
                    Toplam += Matris[i][k];
                }
            }
    }

    // Koseleri çıkar.
    Toplam -= Matris[0][0] + Matris[Sutun-1][Sutun-1];
    Toplam -= Matris[Satir-1][0] + Matris[0][Satir-1];


    // Toplamı yazdır
    cout<<"|--Çevre toplamı : "<<Toplam<<endl;

    return 0;
}












