internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Lütfen 1 ile 10 arasında bir sayı giriniz: ");

         int kenar = Convert.ToInt32(Console.ReadLine());

        if (kenar >= 1 && kenar <= 10) // Girilen sayı 1-10 aralığında mı onu kontrol ediyoruz
        {
            for (int i = 1; i <= kenar; i++)
            {
                for (int j = 1; j <= kenar; j++)
                {
                    if (i == 1 || i == kenar || j == 1 || j == kenar ) // Köşeler ve kenarlar "*" karakteri ile doldurulur
                    {
                        Console.Write("*" + " ");
                    }
                    else // karenin içini boşluk ile dolduruyoruz
                    {
                        Console.Write(" " + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        else // Girilen sayı 1-10 aralığında değilse hata mesajı yazdırıyoruz
        {
            Console.WriteLine("Hatalı giriş! Lütfen 1 ile 10 arasında bir sayı giriniz.");
        }

        Console.ReadKey();

    }
}