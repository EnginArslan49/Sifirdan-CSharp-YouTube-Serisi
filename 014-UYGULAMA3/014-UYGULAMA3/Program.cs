/*
    ------------------------------------------------------------
        UYGULAMA 1 - Karşılaştırma Operatörleri
    ------------------------------------------------------------

    18 yaşında (>=18) bir kişinin yetişkin olup olmadığını
    karşılaştırma operatörü kullanarak kontrol et.

    ÇIKTIYI AŞAĞIDAKİ FORMATTAKİ GİBİ VER!
        Kişinin yetişkinlik durumu: {TRUE veya FALSE}

        TRUE: Yetişkin anlamına gelir (>=18)
        FALSE: Yetişkin DEĞİLDİR (18'den küçüktür)



int yas = 17;

Console.WriteLine($"Kişinin yetişkinlik durumu: {yas >= 18}"); // 17 >= 18 :  False
*/



















/*
    ------------------------------------------------------------
        UYGULAMA 2 - Karşılaştırma Operatörleri
    ------------------------------------------------------------

    İki farklı sayı oluştur ve bu sayıların eşit olup
    olmadığını karşılaştırma operatörü kullanarak kontrol et.

    ÇIKTIYI AŞAĞIDAKİ FORMATTAKİ GİBİ VER!
        İlk sayı: {sayi1}, ikinci sayı: {sayi2}
        Sayıların birbirine eşit olma durumu: {TRUE veya FALSE}

        TRUE: İki sayı birbirine eşittir
        FALSE: Sayılar birbirine eşit DEĞİLDİR


int sayi1 = 49;
int sayi2 = 4;

Console.WriteLine( $"İlk sayı: {sayi1}, ikinci sayı: {sayi2}" );

Console.WriteLine( $"Sayıların birbirine eşit olma durumu: {sayi1 == sayi2}" ); // False

Console.Write("\n");

int sayi3 = 153;
int sayi4 = 153;

Console.WriteLine($"İlk sayı: {sayi3}, ikinci sayı: {sayi4}");

Console.WriteLine( $"Sayıların birbirine eşit olma durumu: {sayi3 == sayi4}" ); // True
*/














/*
    ------------------------------------------------------------
        UYGULAMA 3 - Mantıksal Operatörler (VE Operatörü)
    ------------------------------------------------------------

    Bir öğrencinin hem yaşının >= 18 hem de
    puanının >= 50 olup olmadığını mantıksal
    operatör kullanarak kontrol et.

    ÇIKTI ANLAMLARI:
        TRUE: Öğrencinin hem yaşı >= 18 hem de puanı >= 50'dir
        FALSE: Ya öğrencinin yaşı tutmuyor ya puanı ya da her iki koşul
                da FALSE değer döndürüyordur
        


int yas = 17;
double puan = 56;

Console.WriteLine( (yas >= 18) && (puan >= 50) ); // False + True : False
*/




















/*
    ------------------------------------------------------------
        UYGULAMA 4 - Mantıksal Operatörler (VEYA Operatörü)
    ------------------------------------------------------------

    Bir öğrencinin sınav puanının >= 50 YA DA
    proje puanının >= 70 olup olmadığını kontrol et.

    ÇIKTI ANLAMLARI:
        TRUE: Öğrencinin ya sınav puanı >= 50 ya da proje puanı >= 70'dir
        FALSE: Her 2 koşulda da değer FALSE dönüyordur
*/

int sinav = 49;
int proje = 70;

Console.WriteLine( (sinav >= 50) || (proje >= 70) ); // False + True : True
