using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Siparis alindi. Islemler baslatiliyor...\n");

        // Siparisi hazırlama sürecini başlat
        await SiparisHazirla();

        Console.WriteLine("\nSiparis islemleri tamamlandi.");
    }

    // Siparis Hazırlama Süreci
    public static async Task SiparisHazirla()
    {
        // Siparisi hazırlama işlemi
        await SiparisHazirlamaIslemi();
        
        // Paketleme işlemi
        await PaketlemeIslemi();

        // Kargoya verme işlemi
        await KargoyaVermeIslemi();
    }

    // 1. Siparis Hazırlama Aşaması
    private static async Task SiparisHazirlamaIslemi()
    {
        Console.WriteLine("Siparis hazirlaniyor...");
        await Task.Delay(2000); // 2 saniye bekleme (hazırlama süresi)
        Console.WriteLine("Siparis hazirlandi.");
    }

    // 2. Paketleme Aşaması
    private static async Task PaketlemeIslemi()
    {
        Console.WriteLine("Siparis paketleniyor...");
        await Task.Delay(1500); // 1.5 saniye bekleme (paketleme süresi)
        Console.WriteLine("Siparis paketlendi.");
    }

    // 3. Kargoya Verme Aşaması
    private static async Task KargoyaVermeIslemi()
    {
        Console.WriteLine("Siparis kargoya veriliyor...");
        await Task.Delay(2500); // 2.5 saniye bekleme (kargoya verme süresi)
        Console.WriteLine("Siparis kargoya verildi.");
    }
}
