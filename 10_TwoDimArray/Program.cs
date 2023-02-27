internal class Program
{
    private static void Main(string[] args)
    {
        int[,] dizi = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

        // Dizinin boyutlarını alıyoruz
        int satirSayisi = dizi.GetLength(0);
        int sutunSayisi = dizi.GetLength(1);

        // Dizinin tüm elemanlarını iki katına çıkartıyoruz
        for (int i = 0; i < satirSayisi; i++)
        {
            for (int j = 0; j < sutunSayisi; j++)
            {
                dizi[i, j] *= 2;
            }
        }

        // Diziyi ekrana yazdırıyoruz
        for (int i = 0; i < satirSayisi; i++)
        {
            for (int j = 0; j < sutunSayisi; j++)
            {
                Console.Write("{0} ", dizi[i, j]);
            }
            Console.WriteLine();
        }
    }
}