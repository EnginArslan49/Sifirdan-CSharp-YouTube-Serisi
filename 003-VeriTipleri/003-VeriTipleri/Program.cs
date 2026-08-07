
// DEĞİŞKEN TANIMLAMALARI
//veriTipi degiskenAdi = deger;     (değişken tanımlanır ve değer atanır)
//veriTipi degiskenAdi;     (değişken tanımlanır ve değer atanmaz, daha sonra değer atanabilir)


string ad = "Selvi"; // string veri tipi, metinsel veriler için kullanılır

int yas = 22; // int veri tipi, tam sayılar için kullanılır

double boy = 1.60; // double veri tipi, ondalıklı sayılar için kullanılır

char cinsiyet = 'K'; // char veri tipi, tek karakterler için kullanılır

bool evliMi = false; // bool veri tipi, true veya false değerlerini alır

decimal maas = 5000.50M; // decimal veri tipi, para birimi gibi hassas ondalıklı sayılar için kullanılır

var Sinif = "Matematik"; // var veri tipi, değişkenin veri tipini derleyiciye bırakır, derleyici atanan değere göre veri tipini belirler

Sinif = "Fizik"; // var ile tanımlanan değişkenin veri tipi değiştirilemez, ancak değeri değiştirilebilir

Sinif = 5.ToString();


Console.WriteLine("---------ÖĞRENCİ BİLGİLERİ---------");
Console.WriteLine("Öğrenci Adı: " + ad);
Console.WriteLine("Öğrenci Yaşı: " + yas);
Console.WriteLine("Öğrenci Boyu: " + boy);
Console.WriteLine("Öğrenci Cinsiyeti: " + cinsiyet);
Console.WriteLine("Evli mi?: " + evliMi);
Console.WriteLine("Öğrencinin Maaşı: " + maas);

Console.WriteLine(Sinif); // Fizik
Console.WriteLine(Sinif.GetType()); //System.String

