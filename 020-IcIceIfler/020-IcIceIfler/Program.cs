Console.WriteLine("İÇ İÇE IF - ELSE");

/*
    ============================================================
        İÇ İÇE IF - ELSE
    ============================================================

    Bir if veya else bloğunun içerisinde başka bir if - else
    yapısının kullanılmasına "iç içe if - else" denir.

    İç içe koşullar, bir koşulun sağlanmasından sonra başka
    bir koşulun da kontrol edilmesi gerektiğinde kullanılabilir.

    Temel yapı:

    if (koşul1)
    {
        if (koşul2)
        {
            // koşul1 ve koşul2 doğruysa çalışır
        }
    }
*/

























/*
    ============================================================
        BASİT İÇ İÇE IF ÖRNEĞİ
    ============================================================

    Öncelikle birinci koşul kontrol edilir.

    Birinci koşul doğruysa ikinci koşul kontrol edilir.

    Örnek:

    int yas = 19;

    if (yas >= 18)
    {
        Console.WriteLine("Yaşınız 18 veya üzerindedir.");

        if (yas >= 20) // False
        {
            Console.WriteLine("Yaşınız 20 veya üzerindedir.");
        }
        else
        {
            Console.WriteLine("2. Güvenlik noktasından geçemediniz!");
        }
    }
*/

























/*
    ============================================================
        İÇ İÇE IF - ELSE
    ============================================================

    İçte bulunan if yapısında else de kullanılabilir.

    Örnek:

    int yas = 17;

    if (yas >= 18)
    {
        Console.WriteLine("Yaşınız yeterli.");

        if (yas >= 25)
        {
            Console.WriteLine("25 yaş veya üzerindesiniz.");
        }
        else
        {
            Console.WriteLine("25 yaşından küçüksünüz.");
        }

    }
    else
    {
        Console.WriteLine("Yaşınız yeterli değil.");
    }
*/

























/*
    ============================================================
        BİRDEN FAZLA İÇ İÇE IF
    ============================================================

    Gerektiğinde bir koşulun içerisinde birden fazla koşul
    kontrol edilebilir.

    Örnek:

    int yas = 25;
    bool ehliyet = false;

    if (yas >= 18)
    {
        Console.WriteLine("Yaş koşulu sağlandı.");

        if (ehliyet)
        {
            Console.WriteLine("Ehliyetiniz var.");
        }
        else
        {
            Console.WriteLine("Ehliyetiniz yok.");
        }
    }
    else
    {
        Console.WriteLine("Yaş koşulu sağlanmadı.");
    }
*/

























/*
    ============================================================
        İÇ İÇE IF - ELSE'DE ÇALIŞMA MANTIĞI
    ============================================================

    Koşullar dışarıdan içeriye doğru değerlendirilir.

    Örneğin:

    if (koşul1)
    {
        if (koşul2)
        {
            // Kod
        }
    }

    Önce koşul1 kontrol edilir.

    koşul1 false ise içteki if kontrol edilmez.

    koşul1 true ise koşul2 kontrol edilir.
*/

























/*
    ============================================================
        GERÇEK HAYAT ÖRNEĞİ
    ============================================================

    Bir kullanıcının sisteme giriş yapabilmesi için:

        1. Kullanıcı adı doğru olmalı.
        2. Kullanıcı adı doğruysa şifre kontrol edilmeli.

    Örnek:

    string kullaniciAdi = "admin";
    string sifre = "12345";

    if (kullaniciAdi == "admin")
    {
        Console.WriteLine("Kullanıcı adı doğru.");

        if (sifre == "1234")
        {
            Console.WriteLine("Giriş başarılı.");
        }
        else
        {
            Console.WriteLine("Şifre yanlış.");
        }
    }
    else
    {
        Console.WriteLine("Kullanıcı adı yanlış.");
    }
*/

























/*
    ============================================================
        İÇ İÇE IF KULLANIRKEN DİKKAT
    ============================================================

    - İçteki koşul, dıştaki koşula bağlıdır.
    - Dış koşul false olduğunda iç koşul kontrol edilmez.
    - Gereğinden fazla iç içe if kullanımı kodun okunabilirliğini
      azaltır.
    - Çok karmaşık koşullar daha anlaşılır bir yapıya ayrılabilir.
    - Koşullar mümkün olduğunca açık ve anlaşılır yazılmalıdır.
*/

























/*
    ============================================================
        İÇ İÇE IF - ELSE ÖZET
    ============================================================

    İç içe if - else yapısı, bir koşul sağlandıktan sonra
    başka bir koşulun kontrol edilmesini sağlar.

    Temel mantık:

        Dış koşul (1. Güvenlik Görevlisi)
            ↓
        Koşul doğru mu? (Sonuç evet yanı true ise)
            ↓
        İç koşul (2. Güvenlik Görevlisi)
            ↓
        İkinci koşula göre işlem

    İç içe koşullar doğru kullanıldığında belirli durumların
    adım adım kontrol edilmesini sağlar.

    Ancak gereğinden fazla iç içe yapı kullanmak kodun
    okunabilirliğini ve bakımını zorlaştırabilir.
*/
