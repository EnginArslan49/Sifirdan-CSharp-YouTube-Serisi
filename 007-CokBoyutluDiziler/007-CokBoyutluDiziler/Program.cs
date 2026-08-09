
/*
    ÇOK BOYUTLU DİZİ TANIMLAMA VE KULLANIMI

    veriTipi[,] diziAdi = new veriTipi[satirSayisi, sutunSayisi];    

    // 3 satır ve 2 sütunlu bir dizi tanımlanır
    string[,] dizi = new string[3, 2]; 


    GÖRSELLEŞTİRMESİ:
        0,0  0,1
        1,0  1,1
        2,0  2,1

    ☝️' da oluşturulan dizinin indexleri şu şekildedir:
        dizi[0, 0] = 1
        dizi[0, 1] = 2

        dizi[1, 0] = 3
        dizi[1, 1] = 4

        dizi[2, 0] = 5
        dizi[2, 1] = 6
    

    ÇOK BOYUTLU DİZİLERDE KULLANILAN ÖZELLİKLER
        GetLength(0): Satır sayısını verir.
        GetLength(1): Sütun sayısını verir.

*/






/*
    TEK SATIRDA TANIMLAMA ve DEĞER ATAMA

            // 3 satır ve 2 sütunlu bir dizi tanımlanır
        int[,] dizi = new int[,] { 
            { 1, 2 }, 
            { 3, 4 }, 
            { 5, 6 } 
        };
*/
/*
 SORU:
    Yukarıda tanımlanan dizinin:
        Satır Sayısı: 3
        Sütun Sayısı: 2
*/







// veriTipi[,] diziAdi = new veriTipi[satirSayisi, sutunSayisi]; 

// veriTipi[,] dizim2 = new veriTipi[,] { { deger1, deger2 }, { deger3, deger4 } };


/*
    veriTipi[,] dizim2 = new veriTipi[,] 
    { 
        { SATIR 1 },
        { SATIR 2 }
    };
*/





// 3 satırlı 2 sütunlu bir dizi tanımlayalım
int[,] ilkDizim = new int[,]
{
    { 1, 65 },
    { 989, 6 },
    { 832, 9595 }
};

// Yukarıdaki dizinin 1,1 indexindeki değeri nedir?
Console.WriteLine( ilkDizim[1,1] );  // 1

// Tanımlanmış olduğumuz ilkDizim adlı çok boyutlu dizideki 832 sayısını ekrana yazdıralım
Console.WriteLine( ilkDizim[2, 0] );
Console.WriteLine(ilkDizim[2, 1]); // 9595












Console.WriteLine("\n\n\n\n"); // 4 adet \n ile 4 satır boşluk bırakırız












string[,] isimler = new string[1, 2];

/*
    Yukarıdaki dizinin görselleştirmesi:
        0,0  0,1
*/

// isimler adlı çok boyutlu diziye değer ataması yapalım
isimler[0, 0] = "Hüma";
isimler[0, 1] = "Selvi";


// Dizideki Selvi değerini ekrana yazdıralım
Console.WriteLine(isimler[0, 1]); // Selvi


Console.WriteLine(isimler[0, 0]); // Hüma









// Eşittir operatörünün önündeki ve arkasındaki verilmiş olan veri tiplerimiz aynı olmak zorundadır. Aksi takdirde derleme hatası alırız.

string[,] isimler2 = new string[3, 2];  // DOĞRU KULLANIM

/*
string[,] isimler3 = new int[3, 2];  // HATALI KULLANIM

int[,] isimler4 = new string[3, 2];  // HATALI KULLANIM 2
*/
