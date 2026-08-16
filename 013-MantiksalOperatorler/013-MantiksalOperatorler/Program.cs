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
*/

/*
Console.WriteLine( true && true ); // true

Console.WriteLine( true && false && true ); // false

Console.WriteLine( false && true && true ); // false


Console.WriteLine( (5 == 5) && (7 != 5) ); // true && true : true

Console.WriteLine( (5 == 5) && (7 != 7) ); // true && false : false

Console.WriteLine( (7 != 7) && true ); // false && true: false
*/





/*
    ------------------------------------------------------------
        VEYA OPERATÖRÜ (||)
    ------------------------------------------------------------

    Koşullardan en az birinin doğru olup olmadığını kontrol eder.

    Koşullardan en az biri true ise sonuç true olur.

    Tüm koşullar false ise sonuç false olur.



Console.WriteLine( true || true ); // true

Console.WriteLine(true || false); // true

Console.WriteLine(false || false); // false


Console.WriteLine( (5 == 5) || true ); // true || true : true

Console.WriteLine( (5 != 5) || (5 == 5) );  // false || true : true

Console.WriteLine( (5 == 5) || (5 != 5) );  // true || false : true


Console.WriteLine(false || false); // : false
Console.WriteLine( (7 != 7) || (5 != 5) ); // false || false : false
*/



/*
   ------------------------------------------------------------
        DEĞİL OPERATÖRÜ (!)
    ------------------------------------------------------------

    Bir koşulun veya mantıksal ifadenin sonucunu tersine çevirir.

    true olan bir ifadeyi false,

    false olan bir ifadeyi true

    yapar.



Console.WriteLine( !(true) ); // False
Console.WriteLine( !true ); // False

Console.WriteLine( !(false) ); // True
Console.WriteLine( !false );   // True
*/


Console.WriteLine( !(5 == 5) );

Console.WriteLine( !(5 != 5) );





/*
   ------------------------------------------------------------
        MANTIKSAL OPERATÖRLERİN ÖZETİ
    ------------------------------------------------------------

    &&  → VE
          Tüm koşulların true olması gerekir.

    ||  → VEYA
          En az bir koşulun true olması gerekir.

    !   → DEĞİL
          Sonucu tersine çevirir.
*/
