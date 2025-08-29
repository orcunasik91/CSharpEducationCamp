namespace _01_MainSubjects;
internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        #region Yazdırma Komutları
        //Console.WriteLine("Merhaba .NET");
        //Console.Write("C# ile Programlama");

        Console.WriteLine("**** Yemek Kategorileri ****");
        Console.WriteLine();
        Console.WriteLine("1-Çorbalar");
        Console.WriteLine("2-Ana Yemekler");
        Console.WriteLine("3-Soğuk Başlangıçlar");
        Console.WriteLine("4-Salatalar");
        Console.WriteLine("5-Tatlılar");
        Console.WriteLine("6-İçecekler");
        Console.Read();
        #endregion
    }
}
