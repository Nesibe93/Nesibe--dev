internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++) // 1. çarpan sayı 10 dan küçük olana kadar döndük
        {
            for (int j = 1; j <= 10; j++) //2. çarpan sayı 10 dan küçük olana kadar döndük
            {
                Console.Write("{0} x {1} = {2}\t", i, j, i * j); // {0} i 1. çarpanın değerini belirtiyor {1} j 2. çarpanın değerini belirtiyor {2} i*j nin sonuç değerini belirtiyor
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}