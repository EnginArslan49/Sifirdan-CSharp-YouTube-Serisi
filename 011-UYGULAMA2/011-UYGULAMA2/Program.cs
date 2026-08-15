/*
    ============================================================
        C# SIFIRDAN EĞİTİM
        DERS 13 - UYGULAMALAR PART 2
    ============================================================

    Bu bölümde aşağıdaki konular ele alanıcaktır.
        1) Dizi Oluşturma
        2) Dizi Elemanlarına Erişme
        3) Dizi Elemanı Değiştirme
        4) Dizi Metotları
        5) Çok Boyutlu Dizi Oluşturma
        6) Çok Boyutlu Dizi Elemanlarına Erişme
*/












/*
    ------------------------------------------------------------
        UYGULAMA 1 - Dizi Oluşturma
    ------------------------------------------------------------

    Tek boyutlu ve 4 elemanlı bir int dizisi oluştur.

    Dizinin elemanlarına sırasıyla değerler ata.


int[] dizim = new int[4];


dizim[0] = 25;
dizim[1] = 6;
dizim[2] = 85;
dizim[3] = 1004;


foreach (int eleman in dizim)
{
    Console.WriteLine(eleman);
}

*/

/*
    NOT: Bir dizinin index numarasını öğrenmek için aşağıdaki formül uygulanır:
        hangiElemanaUlaşmakİstiyoruz?
            ElemanSayisi - 1
*/







/*
    ------------------------------------------------------------
        UYGULAMA 2 - Dizi Elemanlarına Erişme
    ------------------------------------------------------------

    4 elemanlı tek boyutlu bir sayı dizisi oluştur.

    Dizinin;

    - İlk elemanına => 0
    - Son elemanına => istenenElemanSayisi - 1 (4 - 1)

    indeks numarası kullanarak eriş.



int[] dizim2 = new int[] { 986, 46, 45, 3235 };


Console.WriteLine( dizim2[0] ); // index numarası ile erişilir : 986

Console.WriteLine( dizim2[4 - 1] ); // : 3235

Console.WriteLine(dizim2[3]); // : 3235
*/











/*
    ------------------------------------------------------------
        UYGULAMA 3 - Dizi Elemanı Değiştirme
    ------------------------------------------------------------

    6 elemanlı tek boyutlu bir sayı dizisi oluştur ve değer ata.

    Dizinin 4. elemanının değerini 23 olarak değiştir ve ekrana yazdır



int[] dizim3 = new int[6];


dizim3[0] = 56;
dizim3[1] = 45;
dizim3[2] = 78;
dizim3[3] = 45; // Bu satırdaki değer değişecek!
dizim3[4] = 67;
dizim3[5] = 946;

Console.WriteLine("Dizinin değiştirilmeden önceki değeri: " + dizim3[3]); // 45

// Yeni değer ataması
dizim3[4 - 1] = 23;

Console.WriteLine("Dizinin değiştirildikten sonraki değeri: " + dizim3[3]); // 23
*/











/*
    ------------------------------------------------------------
        UYGULAMA 4 - Dizi Metotları
    ------------------------------------------------------------

    6 elemanlı tek boyutlu bir sayı dizisi oluştur.

    Ardından aşağıdaki işlemleri sırasıyla gerçekleştir:

    A) Dizinin eleman sayısını bul.             => Length
    B) Diziyi küçükten büyüğe doğru sırala.     => Sort
    C) Dizinin son (6.) elemanının değerini 1255 olarak değiştir.



int[] dizim4 = new int[] { 65, 81, 345, 54, 31, 9756 };


// Console.WriteLine(dizim4.Length); // 6

foreach (var item in dizim4)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n");

Array.Sort(dizim4); // büyükten küçüğe sıralama yapacaktır


foreach (var item in dizim4){
    Console.WriteLine(item);
}
*/















/*
    ------------------------------------------------------------
        UYGULAMA 5 - Çok Boyutlu Dizi Oluşturma
    ------------------------------------------------------------

    2 satır ve 3 sütundan oluşan bir çok boyutlu string dizisi oluştur.

    Dizinin her satırına ve sütununa farklı değerler ata.
*/


// string[,] dizim5 = new string[2, 3];

/*
    GÖRSELLEŞTİRME:
        0,0     0,1     0,2
        1,0     1,1     1,2
*/


/*
dizim5[0, 0] = "Engin";
dizim5[0, 1] = "Selvi";
dizim5[0, 2] = "Hüma";

dizim5[1, 0] = "Yusuf";
dizim5[1, 1] = "Zümra";
dizim5[1, 2] = "Güneş";
*/












/*
    ------------------------------------------------------------
        UYGULAMA 6 - Çok Boyutlu Dizi Elemanlarına Erişme
    ------------------------------------------------------------

    3x3 boyutunda çok boyutlu bir sayı dizisi oluştur.

    Dizinin;

    - İlk satırındaki ilk elemana ilk elemana,
    - İkinci satırındaki ikinci elemana ve
    - Üçüncü satırındaki üçüncü elemanlara sırasıyla değer ata

    indeks kullanarak ekrana yazdır.
*/


int[,] dizim5 = new int[3, 3];

/*
    GÖRSELLEŞTİRME:
        0,0     0,1     0,2
        1,0     1,1     1,2
        2,0     2,1     2,2
*/

dizim5[0, 0] = 65;
dizim5[0, 1] = 412;
dizim5[0, 2] = 589;

dizim5[1, 0] = 568;
dizim5[1, 1] = 896;
dizim5[1, 2] = 56;


dizim5[2, 0] = 65;
dizim5[2, 1] = 78;
dizim5[2, 2] = 87;


/*
    İLK SATIR İLK ELEMAN
        Console.WriteLine( dizim5[0, 0] ); // 65
*/


/*
    İKİNCİ SATIR İKİNCİ ELEMAN
        Console.WriteLine( dizim5[1,1] ); // 896
*/


/*
    ÜÇÜNCÜ SATIR ÜÇÜNCÜ ELEMAN
        Console.WriteLine( dizim5[2, 2] ); // 87
*/










/*
    ============================================================
        PART 2 SONU
    ============================================================
*/