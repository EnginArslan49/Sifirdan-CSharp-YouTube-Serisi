
/*
    1) Array.Sort(dizi): Diziyi sıralar.

    2) Array.Reverse(dizi): Diziyi ters çevirir.

    3) Array.Length: Dizinin eleman sayısını döndürür.

    4) Array.Clear: Dizinin belirtilen indeks aralığındaki elemanlarını temizler.

    5) Array.Copy: Bir dizinin belli bir kısmını veya tamamını başka bir diziye kopyalar.

    
    INT TİPLİ DİZİLER İÇİN:
    6) Min: Dizi içerisindeki en küçük değerli elemanı bulur.

    7) Max: Dizi içerisindeki en büyük değerli elemanı bulur.

    8) Sum: Dizi içerisindeki tüm sayısal elemanların toplamını verir.
*/



// Array.Sort(dizi) KULLANIMI
/*
int[] sayilar = { 5, 3, 8, 1, 4, 98, 54, 9 };

foreach (int sayi in sayilar)
{
    Console.Write(sayi + " ");
}

Console.WriteLine("\n");

Array.Sort(sayilar); // Diziyi küçükten büyüğe sıralar


foreach (int sayi in sayilar)
{
    Console.Write(sayi + " ");
}
*/









// Array.Reverse(dizi) KULLANIMI
/*
int[] sayilar = { 5, 3, 8, 1, 4, 98, 54, 9 };

foreach (int sayi in sayilar)
{
    Console.Write(sayi + " ");
}

Console.WriteLine("\n"); // Alt satıra geçmek için kullanılır

Array.Reverse(sayilar); // Diziyi ters çevirir


foreach (int sayi in sayilar)
{
    Console.Write(sayi + " ");
}
*/











//Array.Length KULLANIMI
/*
int[] sayilar = { 5, 3, 8, 1, 4, 98, 54, 9 };

Console.WriteLine("Sayılar dizisinin eleman sayısı: " + sayilar.Length); // 8
*/









// Array.Clear(dizi) KULLANIMI
/*
int[] sayilar = { 5, 3, 8, 1, 4, 98, 54, 9 };

foreach (int sayi in sayilar)
{
    Console.Write(sayi + " ");
}

Console.WriteLine("\n");

Array.Clear(sayilar, 2, 3); // Dizinin 2. indeksinden başlayarak 3 elemanı temizler


foreach (int sayi in sayilar)
{
    Console.Write(sayi + " ");
}
*/










// Array.Copy(dizi) KULLANIMI
/*
int[] sayilar = { 5, 3, 8, 1, 4, 98, 54, 9 };

int[] dizi2 = new int[8];

foreach (int sayi in dizi2)
{
    Console.Write(sayi + " ");
}

Console.WriteLine("\n");

Array.Copy(sayilar, dizi2, 7); // sayilar dizisinin tüm elemanlarını dizi2 dizisine kopyalar


foreach (int sayi in dizi2)
{
    Console.Write(sayi + " ");
}
*/











// min, max ve sum metotları kullanımı (LINQ olarak da duyarsınız)

int[] sayilar = { 5, 3, 8, 64, 4, 98, 504, 9000 };


// min: Verilmiş olan dizideki en küçük sayıyı bulur
int enKucukSayi = sayilar.Min(); // 3

// max: Verilmiş olan dizideki en büyük sayıyı bulur
int enBuyukSayi = sayilar.Max(); // 9000

// sum: Verilmiş olan dizideki tüm sayıları toplar
int toplam = sayilar.Sum(); // 5 + 3 + 8 + 64 + 4 + 98 + 504 + 9000 = 9686



Console.WriteLine("Dizinin en küçük sayısı: " + enKucukSayi);
Console.WriteLine("Dizinin en büyük sayısı: " + sayilar.Max());
Console.WriteLine("Dizideki Sayıların Toplamı: " + toplam);
