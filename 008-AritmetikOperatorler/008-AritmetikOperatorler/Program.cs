/*
    ARİTMETİK OPERATÖRLERİN TANIMI
	C# dilinde operatörler, değişkenler ve değerler üzerinde matematiksel işlemler yapmak için kullanılır. Operatörler, aritmetik, karşılaştırma, mantıksal ve atama işlemleri gibi çeşitli kategorilere ayrılır.
	Bu dersimizde yalnızca değişkenler üzerinde matematiksel işlem yapacağımız aritmetik operatörleri işleyeceğiz.
*/



/*
     1. ARİTMETİK OPERATÖRLER
    Aritmetik operatörler, sayısal değerler üzerinde matematiksel işlemler yapmak için kullanılır. C# dilinde kullanılan temel aritmetik operatörler şunlardır:

        + (Toplama): İki değeri toplar.

        - (Çıkarma): Bir değeri diğerinden çıkarır.

        * (Çarpma): İki değeri çarpar.

        / (Bölme): Bir değeri diğerine böler. (2. sayı ASLA 0 olamaz! => 0'a bölme hatası)

        % (Modül - MOD): Bir değerin diğerine bölümünden kalanı verir.
*/


int sayi1 = 10;
int sayi2 = 3;

int toplam = sayi1 + sayi2; // Toplama : 13

Console.WriteLine("2 sayının Toplam işlem sonucu: " + toplam);

Console.WriteLine($"2 sayının Toplam işlem sonucu: {sayi1 + sayi2}");

// Sonuç: 10 ile 3 sayısının toplamı: 13
Console.WriteLine($"{sayi1} ile {sayi2} sayısının toplamı: {sayi1 + sayi2}");

/*
    f String interpolation ile yazdırma KULLANIMI:
        Console.Write($"{dinamik1}, {dinamik2}...");
*/


int fark = sayi1 - sayi2; // 10 - 3 = 7
Console.WriteLine("2 sayının Farkı (Çıkarma): " + fark);


int carpim = sayi1 * sayi2;
Console.WriteLine(carpim);




int deger1 = 10;
int deger2 = 3;


double bolumSonucu1 = (double)deger1 / (double)deger2; // 10.333
double bolumSonucu2 = Convert.ToDouble(deger1) / Convert.ToDouble(deger2);
double bolumSonucu3 = double.Parse(deger1.ToString()) / double.Parse(deger2.ToString());


Console.WriteLine("Bölüm 1 Sonucu: " + bolumSonucu1);
Console.WriteLine("Bölüm 2 Sonucu: " + bolumSonucu2);
Console.WriteLine("Bölüm 3 Sonucu: " + bolumSonucu3);



/*
    BÖLME İLE MOD ALMA ARASINDAKİ FARK:

    BÖLME:
        10 / 3 = 3.333

        
    MOD ALMA:
        10 % 3 = 1
        24 % 5 = 4
*/

int s1 = 10;
int s2 = 3;

// 10 mod 3 sonucu: modSonucu
Console.WriteLine($"{s1} mod {s2} sonucu: {10 % 3}"); // 1




Console.WriteLine($"24 mod 5 sonucu: {24 % 5}"); // 4










/*
	MATEMATİKSEL İŞLEMLERDE İŞLEM ÖNCELİĞİ
		1) Varsa PARANTEZ!!
		2) Çarpma - Bölme
		3) Toplama - Çıkarma

*/

double islemOnceligi = 2 + 3 * (5 - 2);

Console.WriteLine(islemOnceligi); // 1


// 4 yanlış 1 doğruyu götürüyorsa:
int yanlis = 4;
int dogru = 25;

int net = dogru - (yanlis / 4);

Console.WriteLine(net); // 25 - 1 = 24
