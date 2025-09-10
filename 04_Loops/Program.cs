namespace _04_Loops;
internal class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        #region For Loop
        //int i;
        //for (i = 1; i <= 5; i++)
        //{
        //    Console.WriteLine("C# Education Camp");
        //}

        //for (int i = 1; i <= 20; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //for (int i = 3; i <= 50; i +=3)
        //{
        //    Console.WriteLine(i);
        //}

        //Console.Write("Lütfen adet değeri giriniz: ");
        //int finishValue = int.Parse(Console.ReadLine());
        //for (int i = 1; i<= finishValue; i++)
        //{
        //    Console.WriteLine("30 AĞUSTOS ZAFER BAYRAMI");
        //}
        //Console.Read();
        #endregion
        #region For Loop With If-Else
        //for (int i = 0; i <= 100; i++)
        //{
        //    if(i % 5 == 0)
        //        Console.WriteLine(i);
        //}

        //int totalValue = 0;
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.Write(i);
        //    if(i < 10)
        //        Console.Write(" + ");
        //    if (i == 10)
        //        Console.Write(" = ");
        //    totalValue += i;
        //}
        //Console.Write(totalValue);

        //int sum = 0;
        //for (int i = 1; i < 21; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        Console.WriteLine(i);
        //        sum += i;
        //    }
        //}
        //Console.WriteLine($"1 ile 20 arasında 2'ye tam bölünebilen sayıların toplamı: {sum}");

        //int count = 0;
        //for(int i = 1; i <= 60; i++)
        //{
        //    if(i % 7 == 0)
        //    {
        //        count++;
        //        Console.WriteLine(i);
        //    }
        //}
        //Console.WriteLine($"1 ile 60 arasında 7'ye tam bölünebilen sayı adedi: {count}");

        //int bacterium = 1;
        //for(int i = 1; i <= 24; i++)
        //{
        //    bacterium *= 2;
        //    Console.WriteLine($"{i}. Saat: {bacterium}");
        //}
        //Console.Read();
        #endregion
        #region While Loop
        //int i = 1;
        //while (i <= 10)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}

        //int i = 1;
        //while (i <= 10)
        //{
        //    if(i % 3 == 0)
        //        Console.WriteLine(i);
        //    i++;
        //}

        //int i = 1;
        //int total = 0;
        //while (i <= 10)
        //{
        //    if(i < 10)
        //        Console.Write(i + " + ");
        //    if(i == 10)
        //        Console.Write(i + " = ");
        //    total += i;
        //    i++;
        //}
        //Console.Write(total);
        //Console.Read();
        #endregion
        #region Example Quaestion
        //Klavyeden 3 basamaklı sayının basamaklarının toplamını yazan kod bloğu
        //Console.Write("Lütfen 3 basamaklı bir sayı giriniz: ");
        //int number = int.Parse(Console.ReadLine());
        //int total = 0;
        //while (number != 0)
        //{
        //    total += number % 10;
        //    number /= 10;
        //}
        //Console.Write(total);
        //Console.Read();
        #endregion
        #region Alt alta 10 Adet Yıldız Oluşturma
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine("*");
        //}
        //Console.Read();
        #endregion
        #region Yanyana 10 Adet Yıldız Oluşturma
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.Write("*");
        //}
        //Console.Read();
        #endregion
        #region Alt alta ve Her Satırda 10 Adet Yıldız Oluşturma
        //for (int i = 1; i <= 10; i++)
        //{
        //    for (int j = 1; j < 10; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine("*");
        //}
        //Console.Read();
        #endregion
        #region Diküçgen Oluşturma
        //for (int i = 1; i <= 5; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}
        //Console.Read();
        #endregion
        #region Ters Diküçgen Oluşturma
        //for (int i = 5; i >= 1; i--)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}
        //Console.Read();
        #endregion
        #region Dik Üçgen Simetresi Oluşturma
        //for (int i = 1; i <= 5; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}
        //for (int i = 4; i >= 1; i--)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}
        //Console.Read();
        #endregion
        #region Baklava Dilimi Oluşturma
        int n = 5;
        for (int i = 1; i <= n; i++)
        {
            for (int j = n - i; j > 0; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2*i-1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (int i = n-1; i > 0; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.Read();
        #endregion

    }
}
