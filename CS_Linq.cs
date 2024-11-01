using System;
using System.Collections.Generic;
using System.Linq;

public class Ogrenci
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public int Yas { get; set; }
    public double Ortalama { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Öğrenci listesini oluşturalım
        List<Ogrenci> ogrenciler = new List<Ogrenci>()
        {
            new Ogrenci { Id = 1, Ad = "Ali", Yas = 20, Ortalama = 82.5 },
            new Ogrenci { Id = 2, Ad = "Ayse", Yas = 22, Ortalama = 95.0 },
            new Ogrenci { Id = 3, Ad = "Mehmet", Yas = 21, Ortalama = 60.0 },
            new Ogrenci { Id = 4, Ad = "Elif", Yas = 23, Ortalama = 75.5 },
            new Ogrenci { Id = 5, Ad = "Ahmet", Yas = 19, Ortalama = 88.0 },
            new Ogrenci { Id = 6, Ad = "Merve", Yas = 20, Ortalama = 92.0 }
        };
        Console.WriteLine("Query Syntax Sorgulari:\n");
        // 1. Ortalaması 80’den büyük olan öğrenciler(Query Syntax)
        var basariliOgrenciler = from o in ogrenciler
                                  where o.Ortalama > 80
                                  select o;

        Console.WriteLine("Ortalamasi 80'den yuksek olan ogrenciler:");
        foreach (var ogrenci in basariliOgrenciler)
        {
            Console.WriteLine($"Ad: {ogrenci.Ad}, Ortalama: {ogrenci.Ortalama}");
        }

        

        // 2. Öğrenci adlarını listeleme (Query Syntax)
        var ogrenciAdlari = from o in ogrenciler
                            select o.Ad;

        Console.WriteLine("\nTum Ogrenci Isimleri:");
        foreach (var ad in ogrenciAdlari)
        {
            Console.WriteLine(ad);
        }
        

        // 3. Yaşa göre sıralama ve isim listeleme (Query Syntax)
        var yasSiraliOgrenciler = from o in ogrenciler
                                  orderby o.Yas
                                  select o.Ad;

        Console.WriteLine("\nYas sirasina gore ogrenciler:");
        foreach (var ad in yasSiraliOgrenciler)
        {
            Console.WriteLine(ad);
        }
        
        // 4. Query Syntax kullanarak tüm öğrencilerin ortalamasının ortalamasını bulalım
        var ortalamaListesi = from o in ogrenciler
                              select o.Ortalama;
        double genelOrtalama = ortalamaListesi.Average();
        Console.WriteLine($"\nTum ogrencilerin genel ortalamasi: {genelOrtalama}");

        // 5. Query Syntax ile en yüksek notu alan öğrenciyi bulma
        var enBasariliOgrenci = (from o in ogrenciler
                                 orderby o.Ortalama descending
                                 select o).FirstOrDefault();

        Console.WriteLine($"\nEn yuksek notu alan ogrenci: {enBasariliOgrenci.Ad}, Ortalama: {enBasariliOgrenci.Ortalama}\n");
        Console.WriteLine("Method Syntax Sorgulari:\n");
        
        // 1. Method Syntax ile Where kullanarak 80 üstü ortalamaya sahip öğrencileri filtreleyelim
        var basariliOgrenciler_L = ogrenciler.Where(o => o.Ortalama > 80).ToList();
        Console.WriteLine("Ortalamasi 80'den yuksek olan ogrenciler:");
        foreach (var ogrenci in basariliOgrenciler_L)
        {
            Console.WriteLine($"Ad: {ogrenci.Ad}, Ortalama: {ogrenci.Ortalama}");
        }

        // 2. Method Syntax ile Select kullanarak öğrenci adlarını seçelim
        var ogrenciAdlari_L = ogrenciler.Select(o => o.Ad).ToList();
        Console.WriteLine("\nTum Ogrenci Isimleri:");
        foreach (var ad in ogrenciAdlari_L)
        {
            Console.WriteLine(ad);
        }
        // 3. Method Syntax ile Öğrencileri yaşlarına göre sıralayıp adlarını listeleyelim
        var yasSiraliOgrenciler_L = ogrenciler.OrderBy(o => o.Yas).Select(o => o.Ad).ToList();
        Console.WriteLine("\nYas sirasina gore ogrenciler:");
        foreach (var ad in yasSiraliOgrenciler_L)
        {
            Console.WriteLine(ad);
        }
        // 4. Method Syntax ile tüm öğrencilerin ortalamasının ortalamasını bulalım
        double genelOrtalama_L = ogrenciler.Select(o => o.Ortalama).Average();
        Console.WriteLine($"\nTum ogrencilerin genel ortalamasi: {genelOrtalama_L}");

        // 5. Method Syntax ile En yüksek notu alan öğrenciyi bulalım
        var enBasariliOgrenci_L = ogrenciler.OrderByDescending(o => o.Ortalama).FirstOrDefault();
        Console.WriteLine($"\nEn yuksek notu alan ogrenci: {enBasariliOgrenci_L.Ad}, Ortalama: {enBasariliOgrenci_L.Ortalama}");
    }
}
