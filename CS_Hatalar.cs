using System;
public class YetersizBakiyeHatasi : Exception // Özel hata sınıfları Exception miras alındı.
{
    public YetersizBakiyeHatasi(string message) : base(message) { }
}

public class NegatifDegerHatasi : Exception
{
    public NegatifDegerHatasi(string message) : base(message) { }
}

public class BankaHesabi
{
    public int Bakiye { get; private set; }

    // Yapıcı metot, pozitif olmayan bir başlangıç bakiyesini kontrol eder.
    public BankaHesabi(int bakiye)
    {
        if (bakiye < 0)
        {
            throw new NegatifDegerHatasi("Hesap bakiyesi negatif olamaz!");
        }
        Bakiye = bakiye;
    }

    // Para çekme işlemi metodu
    public void ParaCek(int miktar)
    {
        if (miktar < 0)
        {
            throw new NegatifDegerHatasi("Cekilecek miktar negatif olamaz!");
        }
        else if (miktar > Bakiye)
        {
            throw new YetersizBakiyeHatasi("Hesapta yeterli bakiye yok!");
        }
        Bakiye -= miktar;
        Console.WriteLine($"Basarili: {miktar} TL cekildi. Kalan bakiye: {Bakiye} TL.");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Kullanıcıdan başlangıç bakiyesini al
            Console.Write("Baslangic bakiyesini giriniz: ");
            int bakiye = int.Parse(Console.ReadLine());

            // Yeni banka hesabı oluştur
            BankaHesabi hesap = new BankaHesabi(bakiye);

            // Para çekme işlemi
            Console.Write("Cekmek istediginiz miktari giriniz: ");
            int miktar = int.Parse(Console.ReadLine());
            hesap.ParaCek(miktar);
        }
        catch (NegatifDegerHatasi ex)
        {
            Console.WriteLine("Negatif Deger Hatasi: " + ex.Message);
        }
        catch (YetersizBakiyeHatasi ex)
        {
            Console.WriteLine("Yetersiz Bakiye Hatasi: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Hata: Lutfen gecerli bir sayi giriniz.");
        }
        finally
        {
            Console.WriteLine("Banka islemi sonlandi.");
        }
    }
}
