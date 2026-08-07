

/* TEK BOYUTLU DİZİ TANIMLAMA
      ⚠️ Dizi tanımlarken veri tipini ve boyutunu belirtmek zorunludur.
      ⚠️ Dizi hangi veri tipinde tanımlanırsa, o veri tipinde değerler alabilir. Başka veri tipinde değerler atayamazsınız. (int tanımlandı ise tamamen tüm elemanları int olmak zorundadır!)
*/

// 1. Yöntem (Diziyi tanımlayıp daha sonra değer atamak)
/*
    veriTipi[] dizininAdi = new veriTipi[diziKacElemanliOlacak];

    dizininAdi[kacinciElemaninaDegerAtiyorsun] = "Değişkenin Değeri";

        ÖRNEK:
            int[] sayilar = new int[2];
            sayilar[0] = 10;
            sayilar[1] = 20;
*/


// 2. Yöntem (Diziyi tanımlayıp değerleri ile birlikte atamak)
/*
    veriTipi[] dizininAdi = new veriTipi[] { "Değer1", "Değer2", "Değer3" };

        ÖRNEK:
            int[] sayilar = new int[] { 1, 2, 3, 4, 5 };
*/


/*
    string[] isimler = new string[3];
    isimler[0] = "Selvi";
    isimler[1] = "Engin";
    isimler[2] = "Yusuf";

    Console.WriteLine(isimler[1]);
*/

/*
string[] isimler = new string[3];
isimler[0] = "Selvi";
isimler[1] = "Engin";
isimler[2] = 5.ToString();

Console.WriteLine(isimler[1]);
*/




// TEK SATIRDA DİZİ TANIMLAMA VE DEĞER ATAMA
string[] cicekler = new string[] { "Gül", "Orkide", "Lale" };

int[] sayilar = new int[] { 1, 2, 3, 4, 5};


// sayilar dizisinin 3. elemanını ekrana yazdır
Console.WriteLine(sayilar[2]); // 3


// cicekler dizisinin 1. (İLK) elemanını ekrana yazdır
Console.WriteLine(cicekler[0]); // Gül

