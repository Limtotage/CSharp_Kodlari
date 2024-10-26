using System;

class Araba
{
    // private alanlar
    private string renk;
    private string model;
    private int yil;

    // Yapici metot
    public Araba(string renk, string model, int yil)
    {
        this.renk = renk;
        this.model = model;
        this.yil = yil;
    }

    // Özellikler (Properties)
    public string Renk
    {
        get { return renk; }
        set { renk = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Yil
    {
        get { return yil; }
        set 
        { 
            if (value > 1885)  // Otomobilin icat yilina göre mantiksal kontrol
                yil = value;
            else
                Console.WriteLine("Gecerli bir yil girin!");
        }
    }

    // Metot: Bilgi yazdirma
    public void BilgiYazdir()
    {
        Console.WriteLine("Araba Bilgileri: Renk - " + Renk + ", Model - " + Model + ", Yil - " + Yil);
    }
}

class CS_Basit_Sinif
{
    static void Main()
    {
        // Yeni bir Araba nesnesi olusturma
        Araba araba1 = new Araba("Mavi", "SUV", 2020);
        
        // Özellikler ile erisim ve güncelleme
        araba1.Renk = "Kirmizi";
        araba1.Model = "Sedan";
        araba1.Yil = 2022;

        araba1.BilgiYazdir();  // Cikti: Araba Bilgileri: Renk - Kirmizi, Model - Sedan, Yil - 2022
    }
}
