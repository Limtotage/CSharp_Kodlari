using System;
public delegate void BilgiVerici(string bilgi);
public class Islem
{
    // Event tanımlama
    public event BilgiVerici IslemTamamlandi;

    public void IslemYap()
    {
        Console.WriteLine("Islem yapiliyor...");
        // Islem tamamlandığında event tetikleniyor
        OnIslemTamamlandi("Islem basariyla tamamlandi!");
    }

    // Event'i tetiklemek için bir metot
    protected virtual void OnIslemTamamlandi(string mesaj)
    {
        if (IslemTamamlandi != null)
        {
            IslemTamamlandi(mesaj);  // Event tetikleniyor
        }
    }
    public static void BilgiYazdir(string bilgi)// Event'i yakalayan metot
    {
        Console.WriteLine("Bildirim: " + bilgi);
    }

    public static void Main()
    {
        // Islem sınıfının bir örneğini oluştur
        Islem islem = new Islem();

        // Event'e bir metot bağla
        islem.IslemTamamlandi += BilgiYazdir;

        // Işlemi başlat
        islem.IslemYap();
    }
}
