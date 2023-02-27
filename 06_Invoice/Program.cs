internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Alışveriş tutarını girin: ");
        double tutar = Convert.ToDouble(Console.ReadLine());
        double indirimOrani = 0;

        if (tutar <= 200) // Alışveriş tutarı 200 e kadar olan için %10
        {
            indirimOrani = 0.1;
        }
        else if (tutar <= 400) //  Alışveriş tutarı 400 e kadar olan için %15
        {
            indirimOrani = 0.15;
        }
        else
        {
            indirimOrani = 0.2; //  Alışveriş tutarı 400 den fazla olan için %20
        }

        double indirimMiktari = tutar * indirimOrani;
        double odenecekTutar = tutar - indirimMiktari;

        Console.WriteLine("İndirim miktarı: " + indirimMiktari);
        Console.WriteLine("Ödenecek tutar: " + odenecekTutar);
        Console.ReadKey();
    }
}