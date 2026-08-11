
/*
    ATAMA OPERATÖRLERİ

    =   → Atama operatörü
          Bir değeri değişkene atamak için kullanılır.

    +=  → Toplayarak atama operatörü
          Değişkenin mevcut değerine bir değer ekleyerek sonucu
          tekrar aynı değişkene atar.

    -=  → Çıkararak atama operatörü
          Değişkenin mevcut değerinden bir değer çıkararak sonucu
          tekrar aynı değişkene atar.

    *=  → Çarparak atama operatörü
          Değişkenin mevcut değerini bir değerle çarparak sonucu
          tekrar aynı değişkene atar.

    /=  → Bölerek atama operatörü
          Değişkenin mevcut değerini bir değere bölerek sonucu
          tekrar aynı değişkene atar.

    %=  → Mod alarak atama operatörü
          Değişkenin mevcut değerinin BÖLÜMÜNDEN KALAN SONUCU
          tekrar aynı değişkene atar.
*/









/*
int sayi1 = 5;

sayi1 += 7; // 5 + 7 = 12

Console.WriteLine(sayi1);


sayi1 = sayi1 + 7; // 12 + 7 = 19

Console.WriteLine(sayi1);
*/









/*
int sayi1 = 10;

// KISA YOL
sayi1 -= 7; // 10 - 7 = 3
Console.WriteLine(sayi1);


// UZUN YOL
sayi1 = sayi1 - 7;
Console.WriteLine(sayi1); // 3 - 7 = -4
*/









/*
double sayi1 = 30;
double sayi2 = 3;


Console.WriteLine($"2 sayının bölümü: {sayi1 /= sayi2}"); // 10

// sayi1 değişkenimizin yeni değeri 10 olur ve 10 değeri ile devam eder
Console.WriteLine($"2 sayının bölümü: {sayi1 = sayi1 / sayi2}"); // 10 / 3 = 3.333
*/









/*
double sayi1 = 30;
double sayi2 = 3;

Console.WriteLine(sayi1); // 30

sayi1 *= sayi2; // 30 * 3 = 90
// UZUN YOL:    sayi1 = sayi1 * sayi2;

Console.WriteLine(sayi1); // 90
*/









int deger1 = 123;
int deger2 = 25;

Console.WriteLine(deger1); // 123

deger1 %= deger2; // 123 % 25 = 23

// mod = (%=) işleminin UZUN HALİ: deger1 = deger1 % deger2;

// Bu satırda artık deger2 değişkenimin değeri 23 olacaktır

Console.WriteLine(deger1); // 23
