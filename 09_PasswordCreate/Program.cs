internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Lütfen şifrenin uzunluğunu girin (1-10 arası): ");
        int uzunluk = Convert.ToInt32(Console.ReadLine());

        // Girilen değerin 1-10 aralığında olup olmadığını kontrol ediyoruz
        while (uzunluk < 1 || uzunluk > 10)
        {
            Console.Write("Lütfen 1-10 arası bir değer girin: ");
            uzunluk = Convert.ToInt32(Console.ReadLine());
        }

        // Rastgele karakterlerden oluşan şifre üretimi
        string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random rnd = new Random(); // random nesnesi oluşturduk
        char[] sifre = new char[uzunluk]; // karakter dizisi tanımladık. şifrenin tutulacağı yer
        for (int i = 0; i < uzunluk; i++)
        {
            sifre[i] = karakterler[rnd.Next(karakterler.Length)]; // karakterler dizisi uzunluğu kadar rastgele alınan karakterler şifre dizisine atanır
        }
        
        Console.WriteLine("Oluşturulan şifre: " + new string(sifre));
    }
}