namespace _05_Arrays;
internal class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        #region Temel Dizi Örnekleri
        //string[] colors = new string[5];
        //colors[0] = "Kırmızı";
        //colors[1] = "Mavi";
        //colors[2] = "Yeşil";
        //colors[3] = "Sarı";
        //colors[4] = "Pembe";
        //foreach (string renk in colors)
        //{
        //    Console.WriteLine(renk);
        //}

        //int[] numbers = new int[10];
        //numbers[0] = 1;
        //numbers[1] = 2;
        //numbers[5] = 3;
        //Console.WriteLine(numbers[5]);

        //string[] cities = { "Ankara","İstanbul","İzmir","Adana","Antalya" };
        //Console.WriteLine(cities[2]);
        #endregion
        #region Dizideki Tüm Elemanları Listeleme
        //string[] colors = { "Sarı", "Kırmızı", "Pembe", "Mavi", "Beyaz" };
        //foreach (string renk in colors)
        //{
        //    Console.WriteLine(renk);
        //}

        //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 2365 };
        //foreach (int number in numbers)
        //{
        //    if(number %4 == 0)
        //        Console.WriteLine(number);
        //}
        #endregion
        #region Max-Min Sayısı Bulma
        //int[] myArray = { 47, 85, 15, 41, 25, 635, 78, -86, 100 };
        //int maxNumb = myArray[0];
        //int minNumb = myArray[0];
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    if (myArray[i] > maxNumb)
        //    {
        //        maxNumb = myArray[i];
        //    }
        //    if (myArray[i] < minNumb)
        //    {
        //        minNumb = myArray[i];
        //    }
        //}
        //Console.WriteLine($"MAX NUMB: {maxNumb}\nMIN NUMB: {minNumb}");
        #endregion
        #region Personel Adeti(Length)
        //string[] persons = { "ali", "zeynep", "elif", "çağatay", "halil", "tuğba" };
        //Console.WriteLine($"Personel Adeti: {persons.Length}");
        #endregion
        #region Sıralama(Sort)
        //int[] numbers = { 45, 40, 84, 76, 33, 21, 12, 19 };
        //Array.Sort(numbers);
        //Console.WriteLine("Artan Sıralama");
        //foreach (int number in numbers)
        //{
        //    Console.WriteLine(number);
        //}
        //Console.WriteLine("-------------------------------");
        //Array.Reverse(numbers);
        //Console.WriteLine("Azalan Sıralama");
        //foreach (int number in numbers)
        //{
        //    Console.WriteLine(number);
        //}
        #endregion
        #region IndexOf Method
        //string[] customers = { "buse", "kenan", "veli", "selma", "eyşan" };
        //int index = Array.IndexOf(customers, "selma");
        //Console.WriteLine(index);
        #endregion
        #region Max-Min Methods
        //int[] numbers = { 23, 52, 49, 88, 93, 105, 420, 396, 19 };
        //Console.WriteLine($"Dizinin En Büyük Elemanı: {numbers.Max()}\nDizinin En Küçük Elemanı: {numbers.Min()}");
        #endregion
        #region Kullanıcıdan Değer Alma
        //string[] cities = new string[5];
        //for (int i = 0; i < cities.Length; i++)
        //{
        //    Console.Write($"Lütfen {i+1}. şehri giriniz: ");
        //    cities[i] = Console.ReadLine();
        //}
        //Console.WriteLine("---------------------");
        //Array.Sort(cities);
        //foreach (string city in cities)
        //{
        //    Console.WriteLine(city);
        //}
        #endregion
        #region Tek-Çift Sayıları Listeleme
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("--------------");
        Console.WriteLine("Tek Sayılar");
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
                Console.WriteLine(number);
        }
        Console.WriteLine("--------------");
        Console.WriteLine("Çift Sayılar");
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
                Console.WriteLine(number);
        }
        #endregion
        Console.Read();
    }
}
