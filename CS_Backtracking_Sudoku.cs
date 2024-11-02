/*  Backtracking (Geri İzleme), çözüm uzayını bir arama ağacı olarak düşünen
ve çözüm bulmaya çalışırken bazı olasılıkları deneyip, bir adım geriye giderek 
başka bir olasılığı denemeye dayalı bir arama algoritmasıdır. Problemin her 
adımında bir seçim yapılır, eğer bu seçim problemin çözümüne uygun değilse geri 
dönülerek başka seçenekler denenir. Yani "ileri git, olmadıysa geri dön ve başka 
bir yol dene" prensibiyle çalışır.*/
using System;

public class CS_Backtracking_Sudoku
{
    private const int BOYUT = 9;

    // Sudoku tahtasını çözer
    public bool SudokuCoz(int[,] tahta)
    {
        for (int satir = 0; satir < BOYUT; satir++)
        {
            for (int sutun = 0; sutun < BOYUT; sutun++)
            {
                // Eğer hücre boşsa (0 değerindeyse)
                if (tahta[satir, sutun] == 0)
                {
                    // 1'den 9'a kadar sayıları dene
                    for (int sayi = 1; sayi <= BOYUT; sayi++)
                    {
                        if (Guvenlimi(tahta, satir, sutun, sayi))
                        {
                            tahta[satir, sutun] = sayi;

                            // Bu sayı ile devam edip çözüm bulduysak true döneriz
                            if (SudokuCoz(tahta))
                            {
                                return true;
                            }

                            // Eğer çözüm bulamadıysak, geri al ve başka bir sayıyı dene
                            tahta[satir, sutun] = 0;
                        }
                    }
                    return false; // Eğer hiçbir sayı geçerli değilse geriye dön
                }
            }
        }
        return true; // Sudoku çözülmüşse true döneriz
    }

    // Sayının hücreye koyulup koyulamayacağını kontrol eder
    private bool Guvenlimi(int[,] tahta, int satir, int sutun, int sayi)
    {
        // Aynı satırda sayı var mı kontrolü
        for (int i = 0; i < BOYUT; i++)
        {
            if (tahta[satir, i] == sayi) return false;
        }

        // Aynı sütunda sayı var mı kontrolü
        for (int i = 0; i < BOYUT; i++)
        {
            if (tahta[i, sutun] == sayi) return false;
        }

        // 3x3 kutucukta sayı var mı kontrolü
        int baslangicSatir = satir - satir % 3;
        int baslangicSutun = sutun - sutun % 3;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (tahta[i + baslangicSatir, j + baslangicSutun] == sayi) return false;
            }
        }
        return true;
    }

    // Sudoku tahtasını ekrana yazdırır
    public void TahtayiYazdir(int[,] tahta)
    {
        for (int i = 0; i < BOYUT; i++)
        {
            for (int j = 0; j < BOYUT; j++)
            {
                Console.Write(tahta[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        int[,] tahta = {
            { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
            { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
            { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
            { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
            { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
            { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
            { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
            { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
            { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
        };

        CS_Backtracking_Sudoku solver = new CS_Backtracking_Sudoku();

        if (solver.SudokuCoz(tahta))
        {
            solver.TahtayiYazdir(tahta);
        }
        else
        {
            Console.WriteLine("Cozum bulunamadi.");
        }
    }
}
