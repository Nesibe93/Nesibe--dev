internal class Program
{
    private static void Main(string[] args)
    {
        Random rastgele = new Random(); // Rastgele sayı üreten sınıfı kullanıyoruz
        int rastgeleSayi = rastgele.Next(1, 201);
        int tahmin = 0;
        int tahminSayisi = 0;

        Console.WriteLine("1 ile 200 arasında bir sayı tahmin ediniz..");

        while (tahmin != rastgeleSayi && tahminSayisi < 10)
        {
            Console.Write("Tahmininizi girin: ");
            tahmin = Convert.ToInt32(Console.ReadLine());
            tahminSayisi++;

            if (tahmin < rastgeleSayi)
            {
                Console.WriteLine("Tahmininiz tutulan sayıdan küçük, daha büyük bir sayı deneyin!");
            }
            else if (tahmin > rastgeleSayi)
            {
                Console.WriteLine("Tahmininiz tutulan sayıdan büyük, daha küçük bir sayı deneyin!");
            }
        }

        if (tahmin == rastgeleSayi)
        {
            Console.WriteLine("Tebrikler, {0} sayısını {1} denemede buldunuz!", rastgeleSayi, tahminSayisi);
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red; // arda plan rengi kırmızı olacak
            Console.Clear(); // ekran temizlenecek
            Console.WriteLine("Üzgünüm, {0} sayısını bulamadınız. Doğru sayı {1} idi.", tahminSayisi, rastgeleSayi);
        }
        Console.WriteLine("Oyundan çıkılıyor...");
        //System.Threading.Thread.Sleep(2000);
        Environment.Exit(0); // konsoldan çıkış yapmak için 
    }
}
