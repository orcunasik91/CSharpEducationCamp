using System.Threading.Channels;

namespace _07_Methods;
internal class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        #region Void Metotlar
        //void CustomerList()
        //{
        //    Console.WriteLine("Ali Veli");
        //    Console.WriteLine("Orhun Orçun");
        //    Console.WriteLine("Eyşan Ezel");
        //}
        //CustomerList();

        //void Sum()
        //{
        //    int x = 10;
        //    int y = 20;
        //    int z = x + y;
        //    Console.WriteLine($"{x} + {y} = {z}");
        //}
        //Sum();
        #endregion
        #region Void Parametreli Metotlar
        //void WriteMethod(string firstName)
        //{
        //    Console.WriteLine($"Adı: {firstName}");
        //}
        //WriteMethod("Orçun");

        //void CustomerCard(string firstName, string lastName, int age)
        //{
        //    Console.WriteLine($"Adı: {firstName}");
        //    Console.WriteLine($"Soyadı: {lastName}");
        //    Console.WriteLine($"Yaşı: {age}");
        //    Console.WriteLine("**************************");
        //}
        //CustomerCard("Orçun", "Aşık", 35);
        //CustomerCard("Cansu", "Dere", 44);

        //void Sum(int x, int y)
        //{
        //    int z = x + y;
        //    Console.WriteLine($"{x} + {y} = {z}");
        //}
        //Sum(25, 87);
        #endregion
        #region Geriye Değer Döndüren Metotlar
        //string CustomerName()
        //{
        //    return "Orçun Aşık";
        //}
        //Console.WriteLine(CustomerName());
        #endregion
        #region Geriye Değer Döndüren Parametreli Metotlar
        //int Sum(int x, int y)
        //{
        //    return x + y;
        //}
        //Console.WriteLine(Sum(12,14));

        //string CountryCard(string countryName, string capital, string population)
        //{
        //    return $"Ülke: {countryName}\nBaşkent: {capital}\nNüfus: {population}\n---------------------";
        //}
        //string countryName, capital, population;
        //Console.Write("Ülke Adı: ");
        //countryName = Console.ReadLine();
        //Console.Write("Başkent: ");
        //capital = Console.ReadLine();
        //Console.Write("Nüfus: ");
        //population = Console.ReadLine();
        //Console.WriteLine();
        //Console.WriteLine(CountryCard(countryName, capital, population));
        //Console.WriteLine(CountryCard("Türkiye","Ankara","6M"));

        string ExamResult(string student, int midterm, int final)
        {
            int result = (midterm * 30 / 100) + (final * 70 / 100);
            if(result>=50)
            {
                return $"{student}, Dersi Geçti!";
            }
            else
            {
                return $"{student}, Dersten Kaldı!";
            }
        }
        Console.WriteLine(ExamResult("Ezel Ömer",25,54));
        #endregion
        Console.Read();
    }
}
