internal class Program
{
    private static void Main(string[] args)
    {
            Console.Write("Lütfen bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        while (sayi >= 1) // while ile klavyeden girilen sayı 1 den büyük olana kadar 5 er 5 er azalana kadar döndük
            {
                Console.Write(sayi + " ");
                sayi -= 5;
            }

            Console.ReadKey();
        
    }

}
