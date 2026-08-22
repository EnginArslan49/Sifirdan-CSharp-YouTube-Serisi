
Console.WriteLine("METOTLAR");

/*
    ============================================================
        21. DERS
        C# METOTLAR
    ============================================================

    Metotlar, belirli bir işlemi gerçekleştirmek amacıyla oluşturulan
    ve ihtiyaç duyulduğunda tekrar çağrılabilen kod bloklarıdır.

    Metot kullanımı sayesinde:
        - Kod tekrarının önüne geçilir.
        - Kodun okunabilirliği artırılır.
        - Kodun yeniden kullanılabilirliği sağlanır.
        - Uygulamanın bakımı ve test edilmesi kolaylaşır.
        - Büyük problemler daha küçük parçalara ayrılabilir.
*/















/*
    ============================================================
        METOT TANIMLAMA SÖZDİZİMİ
    ============================================================

    ErişimBelirteci GeriDönüşTipi MetotAdi(Parametreler)
    {
        // Metodun gerçekleştireceği işlemler
    }

    Erişim belirteci, metoda hangi kapsamdan erişilebileceğini belirler.

    Geri dönüş tipi, metodun çağıran koda hangi türde bir değer döndüreceğini belirtir.

    Metot adı, metodun gerçekleştirdiği işlemi açıkça ifade edecek şekilde anlamlı seçilmelidir.

    Parametreler, metoda dışarıdan veri aktarılmasını sağlar.
*/

























/*
    ============================================================
        METOT ÇAĞIRMA
    ============================================================

    Bir metodun tanımlanması, metodun otomatik olarak çalışacağı anlamına gelmez.

    Metodun içerisindeki kodların çalıştırılması için metodun çağrılması gerekir.

    Metot çağırılırken metot adı yazılır ve ardından parantez kullanılır.

    Örnek:

        Selamla();
*/

























/*
    ============================================================
        PARAMETRESİZ METOT
    ============================================================

    Parametresiz metotlar, dışarıdan herhangi bir veri almadan belirli bir işlemi gerçekleştiren metotlardır.

    !! Parantez içerisinde herhangi bir parametre bulunmaz!

    Örnek:

        void Selamla()
        {
            Console.WriteLine("Merhaba");
        }

    Bu metot çağrıldığında herhangi bir dış veriye (parametreye) ihtiyaç duymaz.


void Selamla()
{
    Console.WriteLine("Merhaba");
    Console.WriteLine("Engin");
    Console.WriteLine("ARSLAN");
}

void Selamla2()
{
    Console.WriteLine("ARSLAN YAZILIM");
}

Selamla2();
*/


















/*
    ============================================================
        PARAMETRELİ METOT
    ============================================================

    Parametreli metotlar, dışarıdan gönderilen verileri kullanarak belirli bir işlemi gerçekleştiren metotlardır.

    Parametreler, metodun parantezleri içerisinde tanımlanır.

    Örnek:

        void Selamla(string isim)
        {
            Console.WriteLine("Merhaba " + isim);
        }

    Bu sayede aynı metot farklı isimlerle tekrar kullanılabilir.


void Selamla(string isim)
{
    Console.WriteLine("Merhaba " + isim);
}


Selamla("Zümra"); // Merhaba Zümra

Selamla("Engin"); // Merhaba Engin

Selamla("Yusuf"); // Merhaba Yusuf


void Karsilama(int yas, string ad)
{
    // X kişisi yas yaşındadır
    Console.WriteLine( $"{ad} kişisi {yas} yaşındadır" );
}


Karsilama(23, "Engin"); // Engin kişisi 23 yaşındadır

Karsilama(3, "Hüma"); // Hüma kişisi 3 yaşındadır

Karsilama(12, "Yusuf"); // Yusuf kişisi 12 yaşındadır
*/














/*
    ============================================================
        PARAMETRE VE ARGÜMAN
    ============================================================

    Metot tanımlanırken parantez içerisinde belirtilen değişkenlere PARAMETRE denir.

    Metot çağrılırken parametreye gönderilen gerçek değerlere ARGÜMAN denir.

    Örnek:

        static void Topla(int sayi1, int sayi2)

    Buradaki "sayi1" ve "sayi2" parametredir.

        Topla(10, 20);

    Buradaki "10" ve "20" ise argümandır.
*/



















/*
    ============================================================
        GERİYE DEĞER DÖNDÜRMEYEN METOTLAR
    ============================================================

    Bir metot herhangi bir sonucu çağıran koda geri döndürmeyecekse geri dönüş tipi olarak "void" kullanılabilir.

    Bu tür metotlar bir işlemi gerçekleştirir ancak geriye bir değer göndermez.

    Örnek:

        void EkranaYaz()
        {
            Console.WriteLine("C#");
        }


void EkranaYaz()
{
    Console.WriteLine("C#");
}

EkranaYaz();
*/













/*
    ============================================================
        RETURN ANAHTAR KELİMESİ
    ============================================================

    "return" anahtar kelimesi, metodun sonucunu çağrıldığı noktaya geri göndermek için kullanılır.

    Return ile döndürülen değer, metodun tanımlanan geri dönüş tipiyle uyumlu olmalıdır.

    Örnek:
    
            !! DİKKAT DİKKAT !!
        int KareAl(int sayi)
        {
            ...
            return sayi * sayi;
        }

        string KareAl(int sayi)
        {
            ...
            return 12.ToString();
        }

    Metot çağrıldığında hesaplanan sonuç çağıran koda döndürülür.
*/

// TEK PARAMETRE İLE GERİYE DEĞER DÖNDÜREBİLEN
/*
int KareAl(int sayi)
{
    int kareSonuc = sayi * sayi;
    return kareSonuc;
}

Console.WriteLine( KareAl(5) ); // 5 * 5 => 25
*/








// ÇOK PARAMETRE İLE GERİYE DEĞER DÖNDÜREBİLEN
/*
int Topla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}

Console.WriteLine( Topla(5, 8) ); // 13

Console.WriteLine(Topla(554, 805)); // 1359
*/








/*
    ============================================================
        GERİYE DEĞER DÖNDÜREN METOTLAR
    ============================================================

    Bir metodun gerçekleştirdiği işlemin sonucunu çağıran koda göndermesi gerekiyorsa uygun bir geri dönüş tipi kullanılır.

    Metodun geri dönüş tipi "void" yerine döndürülecek veri türü olarak belirtilir.

    Örnek:

        int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

    Bu metot iki sayıyı toplar ve sonucu "int" türünde döndürür.




int fark(int sayi1, int sayi2)
{
    return sayi1 - sayi2; 
}


Console.WriteLine( fark(10, 5) ); // 5

Console.WriteLine(fark(5, 10)); // -5
*/











/*
    ============================================================
        METOTLARDA İSİMLENDİRME
    ============================================================

    Metot isimleri, gerçekleştirilen işlemi açıkça ifade etmelidir.

    C# kodlama standartlarında metot isimleri genellikle PascalCase biçiminde yazılır.

    Örnek:
        Topla()
        Hesapla()
        KullaniciGetir()
        SiparisOlustur()

    "Metot1(), x()" gibi anlam ifade etmeyen isimlerden kaçınılmalıdır.
*/
















/*
    ============================================================
        METOTLARDA TEK SORUMLULUK
    ============================================================

    Bir metodun mümkün olduğunca tek bir sorumluluğa sahip olması, kodun okunabilirliğini ve test edilebilirliğini artırır.

    !!
    Bir metot çok fazla farklı işlem gerçekleştiriyorsa, bu işlemler daha küçük ve anlamlı metotlara ayrılabilir.

    Amaç, her metodun ne yaptığının kolayca anlaşılabilmesidir.
*/













/*
    ============================================================
        METOTLARIN AVANTAJLARI
    ============================================================

    Metot kullanımı:
        - Kod tekrarını azaltır.
        - Kodun okunabilirliğini artırır.
        - Kodun yeniden kullanılmasını sağlar.
        - Kodun bakımını kolaylaştırır.
        - Hataların tespit edilmesini kolaylaştırır.
        - Kodun test edilebilirliğini artırır.
        - Büyük uygulamaların daha düzenli olmasını sağlar.
*/







/*
    ============================================================
        METOTLAR - ÖZET
    ============================================================

    Metotlar, program içerisindeki belirli işlemleri
    bağımsız ve tekrar kullanılabilir kod bloklarına ayırır.

    Bir metot:
        - Parametre alabilir veya almayabilir.
        - Değer döndürebilir veya döndürmeyebilir.
        - Bir veya birden fazla işlem gerçekleştirebilir.

    Temel amaç; kodu daha düzenli, okunabilir, yeniden kullanılabilir ve test edilebilir hale getirmektir.
*/
