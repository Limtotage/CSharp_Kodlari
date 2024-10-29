using System;
abstract class Calisan
{
    public string AD { get; set; }
    public string Dep { get; set; }
    public abstract void Calis(); // Soyut metot Override Edilmeli
    public virtual void Tanimla()       // Virtual metot, isteğe bağlı override
    {
        Console.WriteLine(AD+" Adli Calisan "+ Dep+ " Kisminda Calisiyor.");
    }
}
interface ProjeYapabilir
{
    void ProjeYap();
}
class Muhendis : Calisan, ProjeYapabilir // Muhendis sınıfı, Calisan sınıfını devralıyor ve ProjeYapabilir Arayüzünü kullanıyor.
{
    public override void Tanimla()       // Virtual metot override edildi. Override edilmeseydi ilk tanım çalışacaktı.
    {
        Console.WriteLine(AD+" Adli Muhendis "+ Dep+ " Kisminda Calisiyor.");
    }
    public override void Calis()
    {
        Console.WriteLine(AD + " Calisiyor.");
    }
    public void ProjeYap()
    {
        Console.WriteLine(AD + " yeni bir proje yapiyor.");
    }
}

sealed class Mudur : Calisan // Mudur sınıfı miras alınamaz kapalı bir sınıftır.
{
    public static int CalisanSay = 0;
    public Mudur()
    {
        CalisanSay++;
    }
    public override void Calis()
    {
        Console.WriteLine(AD + " Mudur Olarak Calisiyor.");
    }
}


class CS_Gelismis_Sinif
{
    static void Main()
    {
        Muhendis muhendis1 = new Muhendis { AD = "Ali", Dep = "Ar-Ge" };
        Mudur mudur1 = new Mudur { AD = "Ayse", Dep = "Yonetim" };

        muhendis1.Calis();          // Çıktı: Ali çalışıyor.
        muhendis1.ProjeYap();      // Çıktı: Ali yeni bir proje üretiyor.
        muhendis1.Tanimla();       // Çıktı: Ali Adlı Çalışan Ar-Ge Kısmında Çalışıyor.
        mudur1.Calis();             // Çıktı: Ayşe müdür olarak çalışıyor.

        Console.WriteLine("Calisan Sayisi: " + Mudur.CalisanSay);  // Çıktı: Çalışan sayısı: 1
    }
}
