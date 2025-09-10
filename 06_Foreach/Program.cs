namespace _06_Foreach;
internal class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        #region Foreach
        //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
        //foreach (int numb in numbers)
        //{
        //    Console.WriteLine(numb);
        //}
        #endregion
        #region Sınav Sistemi Uygulaması
        Console.Write("**** Sınav Uygulaması ****");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("------------------------------------");
        Console.Write("Sınava giren öğrenci sayısını giriniz: ");
        int studentCount = int.Parse(Console.ReadLine());
        Console.WriteLine("------------------------------------");
        string[] studentNames = new string[studentCount];
        double[] studentScores = new double[studentCount];
        
        for (int i = 0; i < studentCount; i++)
        {
            Console.Write($"Lütfen {i + 1}. öğrencinin adını giriniz: ");
            studentNames[i] = Console.ReadLine();

            double totalScore = 0;
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Lütfen {studentNames[i]} adlı öğrencinin {j+1}. sınav notunu giriniz: ");
                int stuNote = int.Parse(Console.ReadLine());
                totalScore += stuNote;
            }
            Console.WriteLine();
            studentScores[i] = totalScore / 3;
            Console.WriteLine("------------------------------------");
        }
        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"{studentNames[i]} adlı öğreninin ortalaması: {studentScores[i]}");
            if(studentScores[i] >= 50)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrenci durumu: GEÇTİ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrenci durumu: KALDI");
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------");
        }
        #endregion
        Console.Read();
    }
}