internal class Program
{
    private static void Main(string[] args)
    {
        int sayi;
        int toplam = 0;
        int adet = 0;

        // Klavyeden 0 değeri girilene kadar kullanıcıdan sayı alınır ve toplamı hesaplanır
        do
        {
            Console.Write("Sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi != 0) // girilen sayı 0 olana kadar kullanıcıdan sayı alıp toplama atarız
            {
                toplam += sayi;
                adet++; // Girilen sayı adeti artırılır 
            }
        } 
        while (sayi != 0);

        // Toplam ve adeti kullanarak ortalamayı hesaplarız ve ekrana yazdırırız
        double ortalama = (double)toplam / adet;
        Console.WriteLine("Girilen sayıların ortalaması: {0}", ortalama);
    }
}