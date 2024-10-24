using System;
using System.Collections.Generic;

class CS_Diziler_Koleksiyonlar
{
    static void Main()
    {
        // Tek boyutlu dizi
        int[] tekBoyutluDizi = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Tek boyutlu dizi elemanlari:");
        foreach (int sayi in tekBoyutluDizi)
        {
            Console.WriteLine(sayi);
        }

        // Cok boyutlu dizi
        int[,] cokBoyutluDizi = new int[2, 2] { { 1, 2 }, { 3, 4 } };
        Console.WriteLine("Cok boyutlu dizi elemanlari:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine(cokBoyutluDizi[i, j]);
            }
        }

        // List kullanimi
        List<string> isimler = new List<string> { "Ahmet", "Mehmet", "Ayse" };
        Console.WriteLine("List elemanlari:");
        foreach (string isim in isimler)
        {
            Console.WriteLine(isim);
        }

        // Dictionary kullanimi
        Dictionary<string, int> yaslar = new Dictionary<string, int>
        {
            { "Ahmet", 30 },
            { "Mehmet", 25 }
        };
        Console.WriteLine("Dictionary elemanlari:");
        foreach (var item in yaslar)
        {
            Console.WriteLine("Isim: " + item.Key + ", Yas: " + item.Value);
        }

        // Queue kullanimi
        Queue<string> isimKuyrugu = new Queue<string>();
        isimKuyrugu.Enqueue("Ali");
        isimKuyrugu.Enqueue("Veli");
        Console.WriteLine("Queue'den cikan: " + isimKuyrugu.Dequeue());
        Console.WriteLine("Queue'deki ilk kisi: " + isimKuyrugu.Peek());

        // Stack kullanimi
        Stack<int> sayiYigini = new Stack<int>();
        sayiYigini.Push(100);
        sayiYigini.Push(200);
        Console.WriteLine("Stack'ten cikan: " + sayiYigini.Pop());
        Console.WriteLine("Stack'teki en ustteki sayi: " + sayiYigini.Peek());
    }
}
