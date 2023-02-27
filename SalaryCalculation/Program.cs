internal class Program
{
    private static void Main(string[] args)
    {
        double maas = 8500;  // double türünde zamOrani değişkeni tanımladığım için tür dönüşümünde hata almamak için maas değişkenini de double türünde tanımladım
        double zamOrani = 0.15; // double türünde zam oranı değişkeni tanımladım
        int yil = 5;

        for (int i = 0; i < yil; i++) // maaş her yıl artacağı için for döngüsü kullandım
        {
            maas += maas * zamOrani; // maaş ile zam oranını çarpıp maaşa atadım
        }
        Console.WriteLine("5 yıl sonra alacağı maaş : " + maas.ToString("N0") + " " + "TL"); // Maaşı binlik ayırarak ve virgülden sonraki kısmı atması için ToString() metodunun "N0" parametresini kullandım
    }
}