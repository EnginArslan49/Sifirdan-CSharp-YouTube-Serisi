/*
    ============================================================
        C# SIFIRDAN EĞİTİM
        DERS 19 - RANDOM SINIFI
    ============================================================


    RANDOM SINIFI NEDİR?
    ------------------------------------------------------------
    Random sınıfı, program içerisinde rastgele değerler
    üretmek için kullanılır.

    Özellikle;
        - Rastgele sayı üretme
        - Şans / kura uygulamaları
        - Oyunlarda rastgele değerler oluşturma
        - Rastgele seçimler yapma
        - Test verileri oluşturma
    gibi durumlarda kullanılabilir.
*/



















/*
    ------------------------------------------------------------
        NEXT() METODU
    ------------------------------------------------------------

    Next() metodu, belirli bir aralıkta rastgele tam sayı
    üretmek için kullanılır.

    Aşağıda belirtilen 2 adet kullanımı vardır: 
        1) Maximum değer verilerek sayı üretme
        2) Minimum ve Maximum değer verilerek sayı üretme
*/

























/*
    ------------------------------------------------------------
        NEXT(MAXVALUE)
    ------------------------------------------------------------

    Belirtilen üst sınıra kadar rastgele bir tam sayı üretir.

    ÖNEMLİ:

    Üst sınır dahil değildir.

    Örneğin;

    Next(10)

    kullanıldığında üretilebilecek değerler:

    0 - 9

    arasındadır.




Random sayiUret = new Random(); // Random sınıfımızın tanımlaması (program aynı aynı sayfada yalnızca 1 defa oluşturulur)


Console.WriteLine( sayiUret.Next(51) ); // 0 - 50
*/

















/*
    ------------------------------------------------------------
        NEXT(MINVALUE, MAXVALUE)
    ------------------------------------------------------------

    Belirtilen alt ve üst sınır arasında rastgele bir
    tam sayı üretir.

    ÖNEMLİ:

    Alt sınır dahil edilir.
    Üst sınır dahil edilmez.
*/

Random rastgeleSayi = new Random();

Console.WriteLine( rastgeleSayi.Next( 23, 56 ) ); // 23 - 55





















/*
    ------------------------------------------------------------
        ÖZET
    ------------------------------------------------------------

    Random sınıfı → Rastgele değerler üretmek için kullanılır.

    Random → Sınıf
    random → Nesne
    Next() → Rastgele tam sayı üretir.

    Next(maxValue) → 0'dan maxValue - 1'e kadar değer üretir.

    Next(minValue, maxValue) → minValue dahil,
    maxValue hariç olacak şekilde değer üretir.
*/
