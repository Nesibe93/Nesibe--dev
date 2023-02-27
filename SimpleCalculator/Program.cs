internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Lütfen bir işlem seçiniz (Toplama : t , Çıkarma : e , Çarpma : c , Bölme : b ):");

        string islem = Console.ReadLine();
       

        double sonuc = 0;
       
        switch (islem)
        {
            case "t":
                sonuc = sayi1 + sayi2;
                break;
            case "e":
                sonuc = sayi1 - sayi2;
                break;
            case "c":
                sonuc = sayi1 * sayi2;
                break;
            case "b":
                if (sayi2 == 0)
                {
                    Console.WriteLine("Hatalı işlem! İkinci sayı sıfır olamaz.");
                    return;
                }
                sonuc = sayi1 / sayi2;
                break;
            default:
                Console.WriteLine("Hatalı işlem! Geçerli bir işlem seçin.");
                return;
        }

        Console.WriteLine(sonuc);
        Console.ReadKey();
    }
}