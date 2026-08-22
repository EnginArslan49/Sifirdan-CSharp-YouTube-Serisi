// Console.WriteLine("IF - ELSE BLOKLARI");

/*
    ============================================================
        C# IF - ELSE KOŞUL BLOKLARI
    ============================================================

    if - else yapısı, belirli bir koşulun doğru veya yanlış
    olmasına göre farklı kodların çalıştırılmasını sağlar.

    Koşul doğruysa "if" bloğu çalışır.

    Koşul yanlışsa "else" bloğu çalışır.
*/










/*
    ============================================================
        IF SÖZDİZİMİ
    ============================================================

    if (koşul)
    {
        // Koşul doğruysa çalışacak kodlar
    }

    Örnek:

    int yas = 20;

    if (yas >= 18)
    {
        Console.WriteLine("Reşitsiniz.");
    }
*/
























/*
    ============================================================
        IF - ELSE SÖZDİZİMİ
    ============================================================

    if (koşul)
    {
        // Koşul doğruysa çalışır
    }
    else
    {
        // Koşul yanlışsa çalışır
    }

    Örnek:

    int yas = 17;

    if (yas >= 18)
    {
        Console.WriteLine("Reşitsiniz.");
    }
    else
    {
        Console.WriteLine("Reşit değilsiniz.");
    }
*/

























/*
    ============================================================
        KARŞILAŞTIRMA OPERATÖRLERİ
    ============================================================

    Koşul oluştururken karşılaştırma operatörleri kullanılabilir.

    ==    Eşittir
    !=    Eşit değildir
    >     Büyüktür
    <     Küçüktür
    >=    Büyük veya eşittir
    <=    Küçük veya eşittir

    Örnek:

    int sayi = 15;

    if (sayi > 5)
    {
        Console.WriteLine("Sayı 5'ten büyüktür.");
    }
*/


























/*
    ============================================================
        ELSE IF
    ============================================================

    Birden fazla koşulu kontrol etmek istediğimizde
    "else if" yapısını kullanabiliriz.

    if (koşul1)
    {
        // koşul1 doğruysa
    }
    else if (koşul2)
    {
        // koşul2 doğruysa
    }
    else
    {
        // Hiçbir koşul doğru değilse
    }

    Örnek:

    int not = 49;

    if (not >= 85)
    {
        Console.WriteLine("TEBRİKLER!");
        Console.WriteLine("Çok iyi");
    }
    else if (not >= 70)
    {
        Console.WriteLine("İyi");
    }
    else if (not >= 50)
    {
        Console.WriteLine("Geçti");
    }
    else
    {
        Console.WriteLine("MALESEFF");
        Console.WriteLine("Kaldı");
    }
*/

























/*
    ============================================================
        BİRDEN FAZLA KOŞUL
    ============================================================

    Bir if içerisinde birden fazla koşul oluşturulabilir.

    &&    VE
    ||    VEYA
    !     DEĞİL

    Örnek:
*/


    int yas = 25;

    if (yas >= 18 && yas < 24)  // True && False : False
    {
        Console.WriteLine("Çalışma yaş aralığındasınız.");
    }
    else if (yas == 25)
    {
        Console.WriteLine("XXXXXX");
    }



























/*
    ============================================================
        IF - ELSE KULLANIRKEN DİKKAT EDİLMESİ GEREKENLER
    ============================================================

    - if parantezi içerisinde bir koşul bulunmalıdır.
    - Koşul sonucu true veya false olmalıdır.
    - else if birden fazla kez kullanılabilir.
    - else yalnızca bir kez kullanılabilir.
    - else if ve else kullanmak zorunlu değildir.
    - Koşullar yukarıdan aşağıya doğru değerlendirilir.
    - İlk doğru koşul bulunduğunda ilgili kod bloğu çalışır.
*/






/*
    ============================================================
        IF - ELSE ÖZET
    ============================================================

    if
        Bir koşulu kontrol eder.

    else if
        Önceki koşul yanlış olduğunda başka bir koşulu kontrol eder.

    else
        Yukarıdaki koşulların hiçbiri doğru değilse çalışır.

    Temel amaç:
        Koşula bağlı olarak programın farklı kod bloklarını
        çalıştırmasını sağlamaktır.
*/
