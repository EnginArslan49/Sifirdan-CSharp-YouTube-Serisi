/*

    VERİ TİPİ DÖNÜŞTÜRME ÇEŞİTLERİ 3 ADETTİR
1) PARANTEZ İLE HEDEF VERİ TİPİ BELİRTİLEN 
    >> (int)sayi; 
        sayi değişkeni int tipine dönüştürülür.

2) CONVERT İLE DÖNÜŞÜM	
    >> Convert.ToInt32(metin); 
        metin değişkeni int tipine dönüştürülür.


3) PARSE İLE DÖNÜŞÜM	
    >> int.Parse(icerik); 
        icerik değişkeni int tipine dönüştürülür.

*/





// TEK SATIRLI YORUM SATIRI

/*
 ÇOK SATIRLI YORUM SATIRI
*/






// int >> double dönüşümü
/*
int sayi = 10;

double sayi2 = (double)sayi; // Parantez ile dönüşüm

Console.WriteLine("Değişken: " + sayi2);
Console.WriteLine("Değişkenimizin Veri Tipi: " + sayi2.GetType());
*/






// double >> int dönüşümü
/*
double sayi3 = 10.5;

int sayi4 = Convert.ToInt32(sayi3); // Convert ile dönüşüm

Console.WriteLine("Ondalıklı Olmadan Önceki Hali: " + sayi3);
Console.WriteLine("Tam Sayı Hali: " + sayi4);
Console.WriteLine("Değişkenimizin Veri Tipi: " + sayi4.GetType());
*/






// string >> int dönüşümü
/*
string icerik = "10";
int donusturulmusSayi = int.Parse(icerik); // Parse ile dönüşüm

Console.WriteLine(donusturulmusSayi);
Console.WriteLine(donusturulmusSayi.GetType());
*/






// string >> double dönüşümü
/*
string icerik = "10.8";
double donusturulmusSayi = Convert.ToDouble(icerik); // Parse ile dönüşüm

Console.WriteLine(donusturulmusSayi);
Console.WriteLine(donusturulmusSayi.GetType());
*/






// string >> bool (True/False) dönüşümü
/*
string icerik1 = "true";
string icerik2 = "false";

bool donusturulmusBool1 = Convert.ToBoolean(icerik1); // Convert ile dönüşüm
bool donusturulmusBool2 = Convert.ToBoolean(icerik2); // Convert ile dönüşüm


Console.WriteLine(icerik1);
Console.WriteLine(icerik2);

Console.WriteLine("icerik1 değişkeninin İLK (dönüştürülmeden önceki hali) veri tipi karşılığı: " + icerik1.GetType());
Console.WriteLine("icerik1 değişkeninin İLK (dönüştürülmeden önceki hali) veri tipi karşılığı: " + icerik2.GetType());

Console.WriteLine("icerik1 değişkeninin bool veri tipi karşılığı: " + donusturulmusBool1.GetType());
Console.WriteLine("icerik2 değişkeninin bool veri tipi karşılığı: " + donusturulmusBool2.GetType());
*/







// UYGULAMA:
/*
string icerik1 = "10";
string icerik2 = "2";

int sonuc = int.Parse(icerik1) + int.Parse(icerik2); // Parse ile dönüşüm

Console.WriteLine(icerik1 + icerik2); // 102
Console.WriteLine(sonuc); // 12
*/

/*
int sonuc2 = Convert.ToInt32(icerik1) + Convert.ToInt32(icerik2); // Convert ile dönüşüm
*/






// int >> string dönüşümü
int a = 20;

string b = a.ToString(); // ToString() ile dönüşüm

Console.WriteLine(b);