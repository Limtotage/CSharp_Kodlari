using System;

class CS_Fonksiyonlar
{
    // Iki parametre alan Topla metodu
    static int Topla(int a, int b)
    {
        return a + b;
    }

    // uc parametre alan Topla metodu (Asiri Yukleme)
    static int Topla(int a, int b, int c)
    {
        return a + b + c;
    }

    // Iki parametre ile dikdortgen alani hesaplayan metot
    static int DikdortgenAlani(int uzunluk, int genislik)
    {
        return uzunluk * genislik;
    }

    // Tek parametre ile kare alani hesaplayan metot (Asiri Yukleme)
    static int DikdortgenAlani(int kenar)
    {
        return kenar * kenar;
    }

    // Kullaniciya sonucu gosteren metot (void geri donus)
    static void Goster(string aciklama, int sonuc)
    {
        Console.WriteLine(aciklama + ": " + sonuc);
    }

    static void Main()
    {
        int sonuc1 = Topla(5, 10);             // Ilk Topla metodunu cagirir
        int sonuc2 = Topla(5, 10, 15);         // Ikinci Topla metodunu cagirir

        int dikdortgenAlani = DikdortgenAlani(6, 4);  // Dikdortgen alani
        int kareAlani = DikdortgenAlani(5);           // Kare alani

        // Sonuclari goster
        Goster("Iki sayinin toplami", sonuc1);
        Goster("Uc sayinin toplami", sonuc2);
        Goster("Dikdortgenin alani", dikdortgenAlani);
        Goster("Karenin alani", kareAlani);
    }
}
