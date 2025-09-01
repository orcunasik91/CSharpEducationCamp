namespace _03_MakingDecision;
internal class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        #region If Else
        //Console.Write("Lütfen Şifreyi Giriniz: ");
        //string password = Console.ReadLine();
        //if (password == "12345")
        //{
        //    Console.WriteLine("Hoşgeldiniz");
        //}
        //else
        //{
        //    Console.WriteLine("Hatalı Şifre Girdiniz!");
        //}

        //string capital, country;
        //Console.Write("Lütfen Bir Başkent Giriniz: ");
        //capital = Console.ReadLine();
        //Console.Write("Lütfen Bir Ülke Giriniz: ");
        //country = Console.ReadLine();
        //if(capital == "ANKARA" && country == "TURKIYE")
        //{
        //    Console.WriteLine("Doğru Cevap");
        //}
        //else
        //{
        //    Console.WriteLine("Yanlış Cevap");
        //}

        //Console.Write("Lütfen Bir Sayı Giriniz: ");
        //int number = int.Parse(Console.ReadLine());
        //if(number == 5)
        //{
        //    Console.WriteLine("Sayı doğru");
        //}
        //else
        //{
        //    Console.WriteLine("Sayı yanlış");
        //}

        //int exam1, exam2, exam3, average;
        //string result = "Hata!";
        //Console.Write("Sınav 1 Notunuzu Giriniz: ");
        //exam1 = int.Parse(Console.ReadLine());
        //Console.Write("Sınav 2 Notunuzu Giriniz: ");
        //exam2 = int.Parse(Console.ReadLine());
        //Console.Write("Sınav 3 Notunuzu Giriniz: ");
        //exam3 = int.Parse(Console.ReadLine());
        //average = (exam1 + exam2 + exam3) / 3;
        //Console.WriteLine($"Ortalama:    {average}");
        //if(average> 0 && average <= 50)
        //{
        //    result = "Sonuç vasat";
        //}
        //if(average > 50 && average <= 70)
        //{
        //    result = "Tebrikler dersten geçtiniz";
        //}
        //if(average > 70 && average <= 100)
        //{
        //    result = "Muazzam Bir Başarı";
        //}
        //Console.WriteLine(result);

        //string city;
        //Console.Write("Lütfen Şehrinizi Giriniz: ");
        //city = Console.ReadLine();
        //if(city == "Balıkesir" || city == "Ankara")
        //{
        //    Console.WriteLine("Şehir mevcut");
        //}
        //else
        //{
        //    Console.WriteLine("Şehir mevcut değil");
        //}

        //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
        //string username = Console.ReadLine();
        //if(username != "admin")
        //{
        //    Console.WriteLine("Kullanıcı adı hatalı");
        //}
        //else
        //{
        //    Console.Write("Lütfen şifrenizi giriniz: ");
        //    string password = Console.ReadLine();
        //    if(password != "12345")
        //    {
        //        Console.WriteLine("Şifre hatalı");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hoşgeldiniz");
        //    }
        //}
        //Console.Read();
        #endregion
        #region If-Else ile Aritmetik İşlemler
        //int number = 26;
        //int result = number % 3;
        //Console.WriteLine(result);

        //Console.Write("Lütfen 1.Sayıyı Giriniz: ");
        //int number1 = int.Parse(Console.ReadLine());
        //Console.Write("Lütfen 2.Sayıyı Giriniz: ");
        //int number2 = int.Parse(Console.ReadLine());
        //int result = number1 % number2;
        //Console.Write($"{number1} % {number2} =  {result}");

        //Console.Write("Lütfen Bir Sayı Giriniz: ");
        //int number = int.Parse(Console.ReadLine());
        //if(number % 2 == 0)
        //{
        //    Console.WriteLine("Sayı Çifttir");
        //}
        //else
        //{
        //    Console.WriteLine("Sayı Tektir");
        //}
        //Console.Read();
        #endregion
        #region Char ile If Else
        //Console.Write("Lütfen 1 harf giriniz: ");
        //char letter = char.Parse(Console.ReadLine());
        //if(letter == 'g' || letter == 'G' )
        //    Console.WriteLine($"Tuttuğunuz Takım: GALATASARAY");
        //if(letter == 'f' || letter == 'F')
        //    Console.WriteLine($"Tuttuğunuz Takım: FENERBAHÇE");
        //Console.Read();
        #endregion
        #region Mini Uygulama
        //Console.WriteLine("**** C# Eğitim Kampı ****");
        //Console.WriteLine();
        //Console.WriteLine("---------------------------");
        //Console.WriteLine("1-> Ana Yemekler");
        //Console.WriteLine("2-> Çorbalar");
        //Console.WriteLine("3-> Pizzalar");
        //Console.WriteLine("4-> Tatlılar");
        //Console.WriteLine("5-> İçecekler");
        //Console.WriteLine("---------------------------");
        //Console.WriteLine();
        //string menuItem;
        //Console.Write("Detayını görmek istediğiniz menü öğesini seçiniz: ");
        //menuItem = Console.ReadLine();
        //if ((menuItem == "1"))
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("----> Ana Yemekler <----");
        //    Console.WriteLine();
        //    Console.Write("1-> Adana | 2-> Urfa | 3-> Karışık");
        //}
        //else if ((menuItem == "2"))
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("----> Çorbalar <----");
        //    Console.WriteLine();
        //    Console.Write("1-> Mercimek | 2-> Tarhana | 3-> Ezogelin");
        //}
        //else if ((menuItem == "3"))
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("----> Pizzalar <----");
        //    Console.WriteLine();
        //    Console.Write("1-> Sade | 2-> Karışık | 3-> Sebzeli");
        //}
        //else if ((menuItem == "4"))
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("----> Tatlılar <----");
        //    Console.WriteLine();
        //    Console.Write("1-> Kadayıf | 2-> Baklava | 3-> Sütlaç");
        //}
        //else if ((menuItem == "5"))
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("----> İçecekler <----");
        //    Console.WriteLine();
        //    Console.Write("1-> Kola | 2-> Fanta | 3-> Ayran");
        //}
        //else
        //{
        //    Console.WriteLine("Hatalı Seçim Yaptınız!");
        //}
        //Console.Read();
        #endregion
        #region Switch Case
        //Console.Write("Lütfen ay numarasını giriniz: ");
        //int monthNumber = int.Parse(Console.ReadLine());
        //switch (monthNumber)
        //{
        //    case 1:
        //        Console.WriteLine("Ocak");
        //        break;
        //    case 2:
        //        Console.WriteLine("Şubat");
        //        break;
        //    case 3:
        //        Console.WriteLine("Mart");
        //        break;
        //    case 4:
        //        Console.WriteLine("Nisan");
        //        break;
        //    case 5:
        //        Console.WriteLine("Mayıs");
        //        break;
        //    case 6:
        //        Console.WriteLine("Haziran");
        //        break;
        //    case 7:
        //        Console.WriteLine("Temmuz");
        //        break;
        //    case 8:
        //        Console.WriteLine("Ağustos");
        //        break;
        //    case 9:
        //        Console.WriteLine("Eylül");
        //        break;
        //    case 10:
        //        Console.WriteLine("Ekim");
        //        break;
        //    case 11:
        //        Console.WriteLine("Kasım");
        //        break;
        //    case 12:
        //        Console.WriteLine("Aralık");
        //        break;
        //    default:
        //        Console.WriteLine("Hatalı Ay Numarası Girdiniz!");
        //        break;
        //}
        //Console.Read();
        #endregion
        #region Hesap Makinesi
        int number1, number2, result;
        char operation;
        Console.Write("Lütfen 1.Sayıyı Giriniz: ");
        number1 = int.Parse(Console.ReadLine());
        Console.Write("Lütfen 2.Sayıyı Giriniz: ");
        number2 = int.Parse(Console.ReadLine());
        Console.Write("Lütfen İşlem Seçiniz (+, -, *, /): ");
        operation = char.Parse(Console.ReadLine());
        switch (operation)
        {
            case '+':
                result = number1 + number2;
                Console.WriteLine($"{number1} + {number2} = {result}");
                break;
            case '-':
                result = number1 - number2;
                Console.WriteLine($"{number1} - {number2} = {result}");
                break;
            case '*':
                result = number1 * number2;
                Console.WriteLine($"{number1} * {number2} = {result}");
                break;
            case '/':
                if (number2 != 0)
                {
                    result = number1 / number2;
                    Console.WriteLine($"{number1} / {number2} = {result}");
                }
                else
                {
                    Console.WriteLine("Bir sayı sıfıra bölünemez!");
                }
                break;
            default:
                Console.WriteLine("Hatalı İşlem seçimi!");
                break;
        }
        Console.Read();
        #endregion
    }
}