namespace _02_Variables;
internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        #region Değişkenler
        #region String
        //string name;
        //name = "Orçun";
        //string customerName, customerSurname, phone, email, district, city;
        //customerName = "Orçun";
        //customerSurname = "Aşık";
        //phone = "05551234567";
        //email = "asikorcun@gmail.com";
        //district = "Kepsut";
        //city = "Balıkesir";
        //Console.WriteLine("**** Rezervasyon Kartı ****");
        //Console.WriteLine($"Müşteri      : {customerName} {customerSurname}");
        //Console.WriteLine($"Telefon      : {phone}");
        //Console.WriteLine($"E-Posta      : {email}");
        //Console.WriteLine($"İlçe/Şehir   : {district}/{city}");
        //Console.WriteLine("---------------------------------------------------");
        //customerName = "Hande";
        //customerSurname = "Baladın";
        //phone = "0500600700800";
        //email = "test@test.com";
        //district = "Karesi";
        //city = "Balıkesir";
        //Console.WriteLine($"Müşteri      : {customerName} {customerSurname}");
        //Console.WriteLine($"Telefon      : {phone}");
        //Console.WriteLine($"E-Posta      : {email}");
        //Console.WriteLine($"İlçe/Şehir   : {district}/{city}");
        //Console.Read();
        #endregion
        #region Int
        //int number = 34;
        //Console.WriteLine(number);
        //int hamburgerPrice = 300;
        //int cokePrice = 35;
        //int waterPrice = 10;
        //int frizePrice = 75;
        //int pizzaPrice = 300;
        //int lemonadePrice = 25;
        //Console.WriteLine("**** Restoran Menü Fiyatı ****");
        //Console.WriteLine();
        //Console.WriteLine($"Hamburger  : {hamburgerPrice} ₺");
        //Console.WriteLine($"Kola       : {cokePrice} ₺");
        //Console.WriteLine($"Su         : {waterPrice} ₺");
        //Console.WriteLine($"Kızartma   : {frizePrice} ₺");
        //Console.WriteLine($"Pizza      : {pizzaPrice} ₺");
        //Console.WriteLine($"Limonata   : {lemonadePrice} ₺");
        //Console.WriteLine("==================================");
        //int hamburgerCount = 2;
        //int cokeCount = 1;
        //int waterCount = 2;
        //int frizeCount = 4;
        //int pizzaCount = 2;
        //int lemonadeCount = 1;
        //int totalPrice = (hamburgerPrice * hamburgerCount) + (cokePrice * cokeCount) + (waterPrice * waterCount) + (frizePrice * frizeCount) + (pizzaPrice * pizzaCount) + (lemonadePrice * lemonadeCount);
        //Console.WriteLine($"Hamburger : {hamburgerCount}");
        //Console.WriteLine($"Kola      : {cokeCount}");
        //Console.WriteLine($"Su        : {waterCount}");
        //Console.WriteLine($"Kızartma  : {frizeCount}");
        //Console.WriteLine($"Pizza     : {pizzaCount}");
        //Console.WriteLine($"Limonata  : {lemonadeCount}");
        //Console.WriteLine($"Ödenecek Toplam Tutar   : {totalPrice} ₺");
        //Console.Read();
        #endregion
        #region Double
        //double number = 1.25;
        //Console.WriteLine(number);
        //Console.WriteLine("**** Fiyat Listesi ****");
        //Console.WriteLine();
        //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice, totalPrice;
        //applePrice = 25.56;
        //orangePrice = 15.75;
        //strawberryPrice = 30.75;
        //potatoPrice = 10.23;
        //tomatoPrice = 20.38;
        //Console.WriteLine($"-->Elma Birim Fiyatı       : {applePrice}₺");
        //Console.WriteLine($"-->Portakal Birim Fiyatı   : {orangePrice}₺");
        //Console.WriteLine($"-->Çilek Birim Fiyatı      : {strawberryPrice}₺");
        //Console.WriteLine($"-->Patates Birim Fiyatı    : {potatoPrice}₺");
        //Console.WriteLine($"-->Domates Birim Fiyatı    : {tomatoPrice}₺");
        //Console.WriteLine();
        //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
        //appleGram = 1.37;
        //orangeGram = 2.67;
        //strawberryGram = 0.75;
        //potatoGram = 1.50;
        //tomatoGram = 2.25;
        //totalPrice = (appleGram * applePrice) + (orangeGram * orangePrice) + (strawberryGram * strawberryPrice) + (potatoGram * potatoPrice) + (tomatoGram * tomatoPrice);
        //Console.WriteLine($"Elma    -     Gramaj    :{appleGram}     -- Toplam Fiyatı      : {appleGram * applePrice}₺");
        //Console.WriteLine($"Portakal    - Gramaj    :{orangeGram}     -- Toplam Fiyatı      : {orangeGram * orangePrice}₺");
        //Console.WriteLine($"Çilek   -     Gramaj    :{strawberryGram}     -- Toplam Fiyatı      : {strawberryGram * strawberryPrice}₺");
        //Console.WriteLine($"Patates -     Gramaj    :{potatoGram}      -- Toplam Fiyatı      : {potatoGram * potatoPrice}₺");
        //Console.WriteLine($"Domates -     Gramaj    :{tomatoGram}     -- Toplam Fiyatı      : {tomatoGram * tomatoPrice}₺");
        //Console.WriteLine($"Toplam Tutar            :{totalPrice}₺");
        //Console.Read();
        #endregion
        #region Char
        //char harf1 = 'O', harf2 = 'r', harf3 = 'ç', harf4 = 'u', harf5 = 'n';
        //Console.WriteLine($"Adınız  :{harf1}{harf2}{harf3}{harf4}{harf5}");
        //Console.Read();
        #endregion
        #region Klavyeden String Veri Girişleri
        Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
        Console.WriteLine();
        string passangerName, passangerSurname, age, district, city, identityNumber;
        Console.Write("Lütfen Adınızı Giriniz           : ");
        passangerName = Console.ReadLine();
        Console.Write("Lütfen Soyadınızı Giriniz           : ");
        passangerSurname = Console.ReadLine();
        Console.Write("Lütfen TC Kimlik Numaranızı Giriniz           : ");
        identityNumber = Console.ReadLine();
        Console.Write("Lütfen Yaşınızı Giriniz           : ");
        age = Console.ReadLine();
        Console.Write("Lütfen Şehrinizi Giriniz           : ");
        city = Console.ReadLine();
        Console.Write("Lütfen İlçenizi Giriniz           : ");
        district = Console.ReadLine();
        Console.WriteLine("=======================================");
        Console.WriteLine($"Yolcu Adı Soyadı       : {passangerName} {passangerSurname}");
        Console.WriteLine($"TC Kimlik Numarası     : {identityNumber}");
        Console.WriteLine($"Yaş                    : {age}");
        Console.WriteLine($"İl/İlçe                : {city}/{district}");
        Console.Read();

        #endregion
        #region Klavyeden Int Veri Girişleri ve Dönüşümleri
        //int shoePrice, computerPrice, chairPrice, tablePrice;
        //shoePrice = 750;
        //computerPrice = 45000;
        //chairPrice = 4800;
        //tablePrice = 6400;
        //int shoeCount, computerCount, chairCount, tableCount;
        //Console.Write("Lütfen Ayakkabı Adetini Giriniz           : ");
        //shoeCount = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Lütfen Bilgisayar Adetini Giriniz         : ");
        //computerCount = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Lütfen Sandalye Adetini Giriniz           : ");
        //chairCount = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Lütfen Masa Adetini Giriniz               : ");
        //tableCount = Convert.ToInt32(Console.ReadLine());
        //int totalPrice = (shoePrice * shoeCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tablePrice * tableCount);
        //Console.WriteLine("=======================================");
        //Console.WriteLine($"Ödenecek Toplam Tutar   : {totalPrice} ₺");
        //Console.Read();
        #endregion
        #region Klavyeden Double Veri Girişleri ve Dönüşümleri
        //double exam1, exam2, exam3, average;
        //Console.Write("Lütfen 1. Sınav Notunuzu Giriniz           : ");
        //exam1 = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Lütfen 2. Sınav Notunuzu Giriniz           : ");
        //exam2 = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Lütfen 3. Sınav Notunuzu Giriniz           : ");
        //exam3 = Convert.ToDouble(Console.ReadLine());
        //average = (exam1 + exam2 + exam3) / 3;
        //Console.WriteLine();
        //Console.WriteLine($"Ortalamanız   : {average}");
        //Console.Read();
        #endregion
        #region Klavyeden Char Girişleri ve Dönüşümleri
        //char gender;
        //Console.Write("Lütfen Cinsiyetinizi Giriniz (E/K)   :");
        //gender = Convert.ToChar(Console.ReadLine());
        //Console.WriteLine($"Cinsiyetiniz    :{gender}");
        //Console.Read();
        #endregion
        #endregion
    }
}
