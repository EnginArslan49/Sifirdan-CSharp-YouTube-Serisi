/*
    ============================================================
        C# SIFIRDAN EĞİTİM
        DERS 13 - UYGULAMALAR PART 1
    ============================================================

    Bu bölümde aşağıdaki konularla ilgili uygulamalar yapılacaktır:

    1. Değişkenler
    2. Veri Tipleri
    3. Veri Tipi Dönüşümleri
    4. Aritmetik Operatörler
    5. Atama Operatörleri
    6. Arttırma ve Azaltma Operatörleri
*/








/*
    ------------------------------------------------------------
        UYGULAMA 1 - Değişkenler
    ------------------------------------------------------------

    Ad, soyad, yaş ve şehir bilgilerini değişkenlerde tut.
    Değişkenlerin değerlerini ekrana yazdır.


string ad = "Engin";
string soyad = "ARSLAN";
int yas = 23;
string sehir = "AĞRI";

Console.WriteLine("Kişi Adı: " + ad); // Engin
Console.WriteLine($"Soyad: {soyad}"); // ARSLAN
Console.WriteLine("Yaş: " + yas);     // 23
Console.WriteLine("Şehir: " + sehir); // AĞRI
*/









/*
    ------------------------------------------------------------
        UYGULAMA 2 - Ürün Bilgisi
    ------------------------------------------------------------

    Bir ürünün;
    - Adını             : string
    - Fiyatını          : double
    - Stok miktarını    : int

    değişkenlerde tut ve bilgileri ekrana yazdır.


string urunAdi = "Çikolata";
double fiyat = 15.99;
int stokMiktari = 150;


Console.WriteLine(urunAdi);     // Çikolata
Console.WriteLine(fiyat);       // 15.99
Console.WriteLine(stokMiktari); // 150
*/








/*
    ------------------------------------------------------------
        UYGULAMA 3 - Veri Tipleri
    ------------------------------------------------------------

    int, double, char, bool ve string veri tiplerini kullanarak değişkenler oluştur.

    Değişkenlerin değerlerini ekrana yazdır.


int sayi = 15;
double ondalikliSayilar = 15.55;
char sembol = '#';
bool dogruMu = true;
string renk = "Turuncu";

Console.WriteLine(sayi);                // 15
Console.WriteLine(ondalikliSayilar);    // 15,55
Console.WriteLine(sembol);              // #
Console.WriteLine(dogruMu);             // true
Console.WriteLine(renk);                // Turuncu
*/











/*
    ------------------------------------------------------------
        UYGULAMA 4 - Veri Tipi Dönüşümü
    ------------------------------------------------------------

    1) Bir int değeri double veri tipine dönüştür.

    2) Bir double değeri int veri tipine dönüştür.

    3) 2 int sayıyı string'e dönüştür ve ardından topla

    Dönüşüm sonucunda oluşan değerleri ekrana yazdır.



int sayi = 5;

double donusturulmusHal = Convert.ToDouble(sayi);

Console.WriteLine(donusturulmusHal.GetType()); // System.Double



double fiyat = 25.99;

int fiyat2 = (int)fiyat;

Console.WriteLine(fiyat2.GetType()); // System.Int32
Console.WriteLine(fiyat2);           // 25



int sayi1 = 58;
int sayi2 = 746;


Console.WriteLine(sayi1.ToString() + sayi2.ToString()); // 58746
*/










/*
    ------------------------------------------------------------
        UYGULAMA 5 - Aritmetik İşlemler
    ------------------------------------------------------------

    İki sayı tanımla.

    Bu iki sayı üzerinde;
    - Toplama
    - Çıkarma
    - Çarpma
    - Bölme
    - Mod alma

    işlemlerini gerçekleştir ve sonuçları ekrana yazdır.



int sayi1 = 10;
int sayi2 = 6;

double bolum = (double)sayi1 / (double)sayi2;

Console.WriteLine(sayi1 + sayi2); // 16

Console.WriteLine(sayi1 - sayi2); // 4

Console.WriteLine(sayi1 * sayi2); // 60

Console.WriteLine(bolum); // 1..

Console.WriteLine(sayi1 % sayi2); // 10 - 6 = 4
*/















/*
    ------------------------------------------------------------
        UYGULAMA 6 - Dikdörtgen Alan ve Çevre Hesaplama
    ------------------------------------------------------------

    Kısa kenar ve uzun kenar değişkenlerini oluştur.

    Dikdörtgenin;
    - Alanını
    - Çevresini

    Alan Formülü: Kısa Kenar * Uzun Kenar
    Çevre Formülü: 2 * (Kısa Kenar + Uzun Kenar)

    aritmetik operatörleri kullanarak hesapla.


double kisaKenar = 5;
double uzunKenar = 9;


double alan = kisaKenar * uzunKenar;
double cevre = 2 * (kisaKenar + uzunKenar);

Console.WriteLine($"Dikdörtgenin alanı: {alan}");
Console.WriteLine($"Dikdörtgenin çevresi: {cevre}");
*/







/*
    ------------------------------------------------------------
    UYGULAMA 7 - Atama Operatörleri
    ------------------------------------------------------------

    Bir sayı değişkeni oluştur.

    Bu değişkenin değerini sırasıyla;

    +=
    -=
    *=
    /=
    %=

    operatörlerini kullanarak değiştir.

    Her işlem sonrasında değişkenin değerini ekrana yazdır.



int sayi = 5;

// Console.WriteLine(sayi += 8); // 13

// Console.WriteLine(sayi -= 2); // 3

// Console.WriteLine(sayi *= 5); // 25

// Console.WriteLine(sayi /= 2); // 2

Console.WriteLine(sayi %= 2); // 5 - 4 = 1
*/









/*
    ------------------------------------------------------------
        UYGULAMA 8 - Artırma ve Azaltma Operatörleri
    ------------------------------------------------------------

    Bir sayı değişkeni oluştur.

    ++X
    X++
    --X
    X--

    kullanımlarını ayrı ayrı uygula.

    İşlem öncesindeki ve sonrasındaki değerleri gözlemle.
*/

int sayi = 10;

// Console.WriteLine(sayi++); // 10
// Console.WriteLine(++sayi); // 11


/*
Console.WriteLine(sayi--); // 10

Console.WriteLine(sayi); // 9
*/

Console.WriteLine(--sayi); // 9
Console.WriteLine(sayi);   // 9




/*
    ============================================================
        UYGULAMA 1 SONU
    ============================================================
*/