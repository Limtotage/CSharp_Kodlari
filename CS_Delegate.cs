using System;

public class CS_Delegate
{
    public delegate void MesajGoster(string mesaj);
    //Yukarıdaki MesajGoster delegate türü, void döndüren ve string parametre alan tüm metodları temsil eder.
    public static void EkranaYazdir(string mesaj)
    {
        Console.WriteLine("Mesaj: " + mesaj);
    }

    public static void Main()
    {
        // Delegate örneği oluşturma ve bir metot atama
        MesajGoster mesajGoster = EkranaYazdir;

        // Delegate'i çalıştırma
        mesajGoster("Merhaba, dunya!");
    }
}
