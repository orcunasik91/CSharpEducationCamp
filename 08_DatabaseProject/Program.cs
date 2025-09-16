using System.Data;
using System.Data.SqlClient;

namespace _08_DatabaseProject;
internal class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        #region ADONET
            
        Console.WriteLine("**** Ürün-Kategori Bilgi Sistemi ****");
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("1-Kategoriler");
        Console.WriteLine("2-Ürünler");
        Console.WriteLine("3-Siparişler");
        Console.WriteLine("4-Çıkış Yap");
        Console.Write("Lütfen getirmek istediğiniz katalog numarasını giriniz: ");
        string catalogNu = Console.ReadLine();
        Console.WriteLine("----------------------------------------------------");
            #region SQL Connection
            SqlConnection connection = new SqlConnection("Server=localhost,1434;Database=EducationCsharp;User Id=sa;Password=Password1;");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Categories", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["CategoryID"]} - {row["CategoryName"]}");
            }
            connection.Close();
            #endregion
        #endregion
        Console.Read();
    }
}