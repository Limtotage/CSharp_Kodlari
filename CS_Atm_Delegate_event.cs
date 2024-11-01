using System;

// Delegate ve event için tanımlanan yapı
public delegate void IslemEventHandler(string mesaj);

// ATM sınıfı
public class ATM
{
    public event IslemEventHandler IslemTamamlandi;
    public event IslemEventHandler HataOlustu;

    private decimal bakiye;

    public ATM(decimal baslangicBakiyesi)
    {
        bakiye = baslangicBakiyesi;
    }

    public void ParaCek(decimal miktar)
    {
        if (miktar <= 0)
        {
            OnHataOlustu("Cekilecek miktar sifirdan buyuk olmalidir.");
        }
        else if (miktar > bakiye)
        {
            OnHataOlustu("Yetersiz bakiye.");
        }
        else
        {
            bakiye -= miktar;
            OnIslemTamamlandi($"Basarili: {miktar} TL cekildi. Guncel bakiye: {bakiye} TL.");
        }
    }

    public void BakiyeGoster()
    {
        OnIslemTamamlandi($"Guncel bakiye: {bakiye} TL.");
    }

    protected virtual void OnIslemTamamlandi(string mesaj)
    {
        IslemTamamlandi?.Invoke(mesaj);
    }

    protected virtual void OnHataOlustu(string mesaj)
    {
        HataOlustu?.Invoke(mesaj);
    }
}

// Program sınıfı
class CS_Atm_Delegate_event
{
    public static void IslemMesaji(string mesaj)
    {
        Console.WriteLine(mesaj);
    }

    public static void Main()
    {
        ATM atm = new ATM(500);  // Başlangıç bakiyesi 500 TL

        // Event'lere metotları bağlama
        atm.IslemTamamlandi += IslemMesaji;
        atm.HataOlustu += IslemMesaji;

        // İşlemler
        atm.BakiyeGoster();
        atm.ParaCek(200);
        atm.ParaCek(100);
        atm.ParaCek(300);  // Bu işlemde hata oluşur
    }
}
