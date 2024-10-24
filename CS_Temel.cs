using System;

class CS_Temel
{
    static void Main()
    {
        // Kullanicidan yas ve isim alalim
        Console.WriteLine("Adinizi girin: ");
        string ad = Console.ReadLine();

        Console.WriteLine("Yasinizi girin: ");
        int yas = int.Parse(Console.ReadLine());  // Giris değerini tam sayiya donusturme

        // Kontrol yapilari kullanarak yetiskin olup olmadiğini kontrol edelim
        if (yas >= 18)
        {
            Console.WriteLine("Merhaba " + ad + ", sen bir yetiskinsin.");
        }
        else
        {
            Console.WriteLine("Merhaba " + ad + ", sen bir cocuksun.");
        }

        // Bir for dongusu ile sayilari ekrana yazdiralim
        Console.WriteLine("0'dan 4'e kadar sayilar:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        // Değiskenler ve operatorleri kullanarak basit matematiksel islemler yapalim
        int sayi1 = 10;
        int sayi2 = 3;
        int toplam = sayi1 + sayi2;
        int fark = sayi1 - sayi2;
        int carpim = sayi1 * sayi2;
        float bolum = (float)sayi1 / sayi2;  // Bolum islemi ondalikli olmali
        int kalan = sayi1 % sayi2;

        Console.WriteLine("Toplam: " + toplam);
        Console.WriteLine("Fark: " + fark);
        Console.WriteLine("Carpim: " + carpim);
        Console.WriteLine("Bolum: " + bolum);
        Console.WriteLine("Kalan: " + kalan);
    }
}
