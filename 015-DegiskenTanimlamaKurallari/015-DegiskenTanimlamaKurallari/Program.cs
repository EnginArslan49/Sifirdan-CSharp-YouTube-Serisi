Console.WriteLine("DEĞİŞKEN TANIMLAMA KURALLARI");


/*
    ============================================================
        C# SIFIRDAN EĞİTİM
        DERS 18 - DEĞİŞKEN TANIMLAMA KURALLARI
    ============================================================


    ------------------------------------------------------------
        DEĞİŞKEN İSMİ BELİRLERKEN TEMEL AMAÇ
    ------------------------------------------------------------

    Değişken isimleri sadece kodun çalışması için değil,
    kodun okunabilir ve anlaşılabilir olması için de önemlidir.

    İyi bir değişken ismi, değişkenin hangi veriyi tuttuğunu
    mümkün olduğunca açık şekilde ifade etmelidir.





    1. Değişken isimleri bir harf veya alt çizgi (_) ile
       başlayabilir.

       Örnek başlangıçlar:
       isim
       _isim






    2. Değişken isimleri sayı ile başlayamaz.

       Geçersiz !!:
       1sayi

       Geçerli:
       sayi1

       Geçerli:
       say20i






    3. Değişken isimlerinde boşluk kullanılamaz.

       Geçersiz !!:
       ogrenci adi

       Doğru yaklaşım:
       ogrenciAdi

       Doğru yaklaşım:
       ogrenci_adi






    4. Değişken isimlerinde özel karakterler kullanılmamalıdır.

       Değişken isimlerinde genel olarak harf, rakam ve
       alt çizgi (_) kullanılmalıdır.

        Doğru yaklaşımlar:
        sayi1
        sayi3sayi
        _EnginYasi
        Engin_Yasi
        EnginYasi_

        Yanlış KULLANIM:
        1sayi
        #sayi
        say#i
        sayi!






        CAN ALICI NOKTA
    5. C# büyük/küçük harfe duyarlıdır.

       Örneğin:

       sayi
       Sayi
       SAYI

       birbirinden farklı değişken isimleridir.





        DİKKAT DİKKAT DİKKAT !!
    6. Değişken isimleri C# diline ait anahtar kelimelerle
       aynı olmamalıdır.

       Örneğin:

       int
       string
       class
       public  
       private..

       gibi C# anahtar kelimeleri doğrudan değişken adı
       olarak kullanılamaz.







    7. Değişken isimleri anlamlı olmalıdır.

       Anlamsız:
       x
       a
       veri1 : Kesin olarak neyin verisi olduğu belli değil!

       Anlamlı:
       ogrenciAdi
       urunFiyati
       toplamPuan






    8. Değişken isimlerinde camelCase kullanımı tercih edilir.

       İlk kelime küçük harfle başlar.
       Sonraki kelimelerin ilk harfi büyük yazılır.

       Örnek:

       ogrenciAdi
       urunFiyati
       toplamPuan
       dogumYili






    ------------------------------------------------------------
        ÖZET
    ------------------------------------------------------------
    DEĞİŞKEN TANIMLARKEN:

    ✓ Sayı ile başlamaz (Ortada veya sonda olabilir).

    ✓ Boşluk içermez.

    ✓ Büyük/küçük harfe duyarlıdır.(sayi ile Sayi birbirinden farklıdır)

    ✓ C# anahtar kelimeleri doğrudan kullanılmaz.

    ✓ Anlamlı isimler tercih edilir.

    ✓ camelCase isimlendirme standardı kullanınız.

    ✓ Gereksiz ve anlamsız kısaltmalardan kaçınılır (Ör: Bir değişkene Engin değeri vereceğimiz zaman o değişkene yalnızca E karakterini vermek anlamsız ve mantıksızdır).
*/
