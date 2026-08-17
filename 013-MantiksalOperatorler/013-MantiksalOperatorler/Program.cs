/*
    ============================================================
         SIFIRDAN C# EĞİTİMİ (Engin ARSLAN)
        DERS 16 - MANTIKSAL OPERATÖRLER
    ============================================================

    MANTIKSAL OPERATÖRLER:
    Mantıksal operatörler, birden fazla koşulu bir arada
    değerlendirmek ve bu koşullar arasındaki mantıksal ilişkiyi
    belirlemek için kullanılır.

    Mantıksal operatörlerin sonucunda karşılaştırma operatörlerinde
    olduğu gibi true veya false değeri elde edilir.

    && (VE)     👉 TÜM koşulların doğru olması gerekir
    || (VEYA)   👉 Koşullardan yalnızca biri doğru olması sonucun true olması için yeterlidir
    ! (Değil)   👉 Elde edilen sonucun tersini alır (Sonuç true ise false, false ise true yapar)
*/















/*
    ------------------------------------------------------------
        VE OPERATÖRÜ (&&)
    ------------------------------------------------------------

    İki koşulun da aynı anda doğru olup olmadığını kontrol eder.

    Her iki koşul da true ise sonuç true olur.

    Koşullardan herhangi biri false ise sonuç false olur.

    TRUE - TRUE : true
    TRUE - FALSE : false
    FALSE - TRUE: false



Console.WriteLine( true && true ); // True

Console.WriteLine( true && false ); // False

Console.WriteLine(false && true); // False



Console.WriteLine( (5 == 5) && (5 != 8) ); // True + True : True


Console.Write( (7 > 5) && (8 < 7) ); // True + False : False

Console.Write("\n");

Console.WriteLine( (7 > 9) && (109 <= 109) ); // False + True : False


Console.Write("Kelime 1\tKelime 2"); // Kelime 1        Kelime 2
*/





/*
    ------------------------------------------------------------
        VEYA OPERATÖRÜ (||)
    ------------------------------------------------------------

    Koşullardan en az birinin doğru olup olmadığını kontrol eder.

     !!! Koşullardan en az biri true ise sonuç true olur.

    Tüm koşullar false ise sonuç false olur.



Console.WriteLine( true || true ); // True

Console.WriteLine(true || false); // True

Console.WriteLine(false || true); // True

Console.WriteLine(false || false); // False



Console.WriteLine( (5 > 4) || (6 != 3) || false ); // True + True + False : True

Console.WriteLine(false || (6 != 3) || false); // False + True + False : True

Console.WriteLine(false || false || false || false || false || false || false || false || false || false || false || false || false || false || false || false || false); // Tüm koşulların sonucunun false olmasından dolayı sonucumuz False değerini alacaktır


Console.WriteLine( (6 < 4) || (6 >= 9) ); // False + False : False
*/





/*
   ------------------------------------------------------------
        DEĞİL OPERATÖRÜ (!)
    ------------------------------------------------------------

    Bir koşulun veya mantıksal ifadenin sonucunu tersine çevirir.

    true olan bir ifadeyi false,

    false olan bir ifadeyi true yapar.


Console.WriteLine( !true );

Console.WriteLine( !false );




Console.WriteLine( !(5 < 6) );
*/
Console.WriteLine( !(5 < 6 && 5 > 6) ); // (True && False) : False değerini getirir ve değil operatörü olmuş olduğundan dolayı False değerini tersine çevirerek True değerini verir.











/*
    ------------------------------------------------------------
        MANTIKSAL OPERATÖRLERİN ÖZETİ
    ------------------------------------------------------------

    && (Kısayolu: Shift + 6)  → VE
          Tüm koşulların true olması gerekir.

    || (Kısayolu: Alt Gr + Shift tuşunun yanındaki büyüktür-küçüktür tuşu)  → VEYA
          En az bir koşulun true olması gerekir.

    ! (Kısayolu: Shift + 1)  → DEĞİL
          Sonucu tersine çevirir.
*/
