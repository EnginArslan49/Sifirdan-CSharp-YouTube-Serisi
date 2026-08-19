

/*
    ------------------------------------------------------------
        UYGULAMA 1 - Rastgele Sayı Üretme
    ------------------------------------------------------------

    Random sınıfını kullanarak 1 ile 100 arasında (100 dahil)
    rastgele bir tam sayı üret.

    Üretilen rastgele sayıyı ekrana yazdır.

    DİKKAT:
    Next(minValue, maxValue) kullanımında
    minValue dahil edilir,
    maxValue dahil edilmez.

    Bu nedenle 1 - 100 arasındaki değerleri
    elde etmek için üst sınırı doğru belirle.



Random degerUret = new Random(); // degerUret adında yeni bir Random sınıfı oluşturuldu

Console.WriteLine( degerUret.Next(1, 101) ); // 101 - 1 : 100 => 1 - 100
*/


















/*
    ------------------------------------------------------------
        UYGULAMA 2 - Rastgele Sayılar
    ------------------------------------------------------------

    Random sınıfını kullanarak iki farklı rastgele sayı üret.

    İlk sayı 10 ile 50 (50 dahil) arasında olacak şekilde oluştur.
    İkinci sayıyı da 45 ile 127 (127 dahil) arasında olacak şekilde oluştur.

    Daha sonra bu iki sayıyı kullanarak;

    - Toplama
    - Çıkarma

    işlemlerini gerçekleştir.

    İşlem sonuçlarını ekrana yazdır.

    DİKKAT:
    Rastgele sayıların üretileceği aralığı doğru belirle (max değeri 1 arttırarak yaz)!


Random uret = new Random();

int sayi1 = uret.Next(10, 51); // Her çalıştırmada 10 ile 50 sayıları arasında değer döndürür

int sayi2 = uret.Next(45, 128); // Her çalıştırmada 45 ile 127 sayıları arasında değer döndürür

Console.WriteLine($"Sayı 1: {sayi1}\nSayı 2: {sayi2} ");

Console.WriteLine( sayi1 + sayi2 ); // Toplam işleminin sonucunu döndürür

Console.WriteLine( sayi1 - sayi2 ); // Çıkarma işleminin sonucunu döndürür
*/



















/*
    ------------------------------------------------------------
        UYGULAMA 3 - Rastgele Sayı Tahmini
    ------------------------------------------------------------

    Random sınıfını kullanarak 1 ile 10 arasında
    rastgele bir sayı üret.

    Daha sonra bir tahmin değişkeni oluştur.

    Tahmin edilen sayı ile rastgele üretilen sayıyı
    karşılaştır.

    Karşılaştırmanın sonucunu ekrana yazdır.

    Ekran çıktısı:

    true  → Tahmin edilen sayı ile rastgele sayı aynı.
    false → Tahmin edilen sayı ile rastgele sayı farklı.
*/

Random uret = new Random(); // Random sınıfından örnek oluşturuldu

int randomSayisi = uret.Next(1, 11); // 1 ile 10 sayıları arasında bir sayı değeri döndürür

int tahminSayisi = 5;

Console.WriteLine( $"Random S.T.O. Sayı: {randomSayisi}" );

// DİKKAT
Console.WriteLine( randomSayisi == tahminSayisi ); // Yalnızca True veya False değer döndürür
