using System;
using System.Collections.Generic;

public class Ogrenci
{
    public string Ad { get; set; }
    public double Ortalama { get; set; }
}

public class Lambda_Expressions
{
    public static void Main()
    {
        List<Ogrenci> ogrenciler = new List<Ogrenci>()
        {
            new Ogrenci { Ad = "Ali", Ortalama = 82.5 },
            new Ogrenci { Ad = "Ayse", Ortalama = 78.0 },
            new Ogrenci { Ad = "Mehmet", Ortalama = 90.0 },
            new Ogrenci { Ad = "Elif", Ortalama = 67.0 }
        };

        // 1. Func ile 80'in üstünde ortalamaya sahip olan öğrencileri seçen bir lambda ifadesi tanımlayalım.
        Func<Ogrenci, bool> yuksekBasari = o => o.Ortalama > 80;

        // 2. Action ile bu öğrencilerin bilgilerini ekrana yazdıran bir lambda ifadesi tanımlayalım.
        Action<Ogrenci> ogrenciBilgiYazdir = o => 
            Console.WriteLine($"Ad: {o.Ad}, Ortalama: {o.Ortalama}");

        // 3. Öğrencileri filtreleyelim ve bilgilerini yazdıralım.
        List<Ogrenci> basariliOgrenciler = new List<Ogrenci>();

        foreach (var ogrenci in ogrenciler)
        {
            // Func ile koşulu kontrol et
            if (yuksekBasari(ogrenci))
            {
                basariliOgrenciler.Add(ogrenci); // Başarılı öğrenciyi listeye ekle
            }
        }

        Console.WriteLine("Yuksek not alan ogrenciler:");
        foreach (var ogrenci in basariliOgrenciler)
        {
            ogrenciBilgiYazdir(ogrenci); // Başarılı öğrencinin bilgilerini yazdır
        }
        
        List<int> sayilar = new List<int> { 1, 2, 3, 4, 5 };

        // Lambda ifadesi ile sayıları döngüde karelerine çevirip yazdırıyoruz.
        sayilar.ForEach(sayi => Console.WriteLine($"Sayinin karesi: {sayi * sayi}"));
    }
}
