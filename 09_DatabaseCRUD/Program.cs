using System.Data;
using System.Data.SqlClient;

namespace _09_DatabaseCRUD;
internal class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        #region Create for Category
        //Console.WriteLine("**** Menü Kategori İşlem Paneli ****");
        //Console.WriteLine();
        //Console.WriteLine("-------------------------------------------");
        //Console.Write("Eklemek istediğiniz kategori: ");
        //string categoryName = Console.ReadLine();
        #region SQL Connection
        //SqlConnection connection = new SqlConnection("Server=localhost,1434;Database=EducationCsharp;User Id=sa;Password=Password1;");
        //connection.Open();
        //SqlCommand command = new SqlCommand("Insert Into Categories (CategoryName) Values (@categoryName)", connection);
        //command.Parameters.AddWithValue("@categoryName", categoryName);
        //command.ExecuteNonQuery();
        //connection.Close();
        //Console.Write("Kategori Başarı ile eklendi!");
        #endregion
        #endregion

        #region Create for Product
        //Console.WriteLine("**** Menü Ürün İşlem Paneli ****");
        //Console.WriteLine();
        //Console.WriteLine("-------------------------------------------");
        //Console.Write("Eklemek istediğiniz ürünün adı: ");
        //string productName = Console.ReadLine();
        //Console.Write("Eklemek istediğiniz ürünün fiyatı: ");
        //decimal productPrice = decimal.Parse(Console.ReadLine());
        #region SQL Connection
        //SqlConnection connection = new SqlConnection("Server=localhost,1434;Database=EducationCsharp;User Id=sa;Password=Password1;");
        //connection.Open();
        //SqlCommand command = new SqlCommand("Insert Into Products (ProductName,Price,IsStatus) Values (@productName,@price,@isStatus)", connection);
        //command.Parameters.AddWithValue("@productName", productName);
        //command.Parameters.AddWithValue("@price", productPrice);
        //command.Parameters.AddWithValue("@isStatus", true);
        //command.ExecuteNonQuery();
        //connection.Close();
        //Console.WriteLine("-------------------------------------------");
        //Console.Write("Ürün Başarı ile eklendi!");
        #endregion
        #endregion
        #region Read for Product
        //Console.WriteLine("**** Menü Ürün İşlem Paneli ****");
        //Console.WriteLine();
        //Console.WriteLine("-------------------------------------------");
        #region SQL Connection
        //SqlConnection connection = new SqlConnection("Server=localhost,1434;Database=EducationCsharp;User Id=sa;Password=Password1;");
        //connection.Open();
        //SqlCommand command = new SqlCommand("Select * from Products", connection);
        //SqlDataAdapter adapter = new SqlDataAdapter(command);
        //DataTable dataTable = new DataTable();
        //adapter.Fill(dataTable);
        //foreach (DataRow row in dataTable.Rows)
        //{
        //    Console.WriteLine($"{row["ProductName"]} - {row["Price"]}₺ - {row["IsStatus"]}\n");
        //}
        //connection.Close();
        #endregion
        #endregion
        #region Update for Product
        Console.WriteLine("**** Menü Ürün İşlem Paneli ****");
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------");
        Console.Write("Güncellemek istediğiniz ürün numarası: ");
        int productId = int.Parse(Console.ReadLine());
        Console.Write("Güncellemek istediğiniz ürün adı: ");
        string productName = Console.ReadLine();
        Console.Write("Güncellemek istediğiniz ürün fiyatı: ");
        decimal productPrice = decimal.Parse(Console.ReadLine());
        #region SQL Connection
        SqlConnection connection = new SqlConnection("Server=localhost,1434;Database=EducationCsharp;User Id=sa;Password=Password1;");
        connection.Open();
        SqlCommand command = new SqlCommand("Update Products Set ProductName = @productName, Price = @price where ProductId = @productId", connection);
        command.Parameters.AddWithValue("@productId", productId);
        command.Parameters.AddWithValue("@productName", productName);
        command.Parameters.AddWithValue("@price", productPrice);
        command.ExecuteNonQuery();
        Console.WriteLine("Ürün başarı ile güncellendi!");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Son Ürün Listesi");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();
        SqlCommand command2 = new SqlCommand("Select * from Products", connection);
        SqlDataAdapter adapter = new SqlDataAdapter(command2);
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);
        foreach (DataRow row in dataTable.Rows)
        {
            Console.WriteLine($"{row["ProductName"]} - {row["Price"]}₺ - {row["IsStatus"]}\n");
        }
        connection.Close();
        #endregion
        #endregion
        #region Delete for Product
        //Console.WriteLine("**** Menü Ürün İşlem Paneli ****");
        //Console.WriteLine();
        //Console.WriteLine("-------------------------------------------");
        //Console.Write("Silmek istediğiniz ürün numarası: ");
        //int productId = int.Parse(Console.ReadLine());
        #region SQL Connection
        //SqlConnection connection = new SqlConnection("Server=localhost,1434;Database=EducationCsharp;User Id=sa;Password=Password1;");
        //connection.Open();
        //SqlCommand command = new SqlCommand("Delete from Products where ProductId = @productId", connection);
        //command.Parameters.AddWithValue("@productId",productId);
        //command.ExecuteNonQuery();
        //Console.WriteLine("Ürün başarı ile silindi!");
        //Console.WriteLine("--------------------------------------------");
        //Console.WriteLine("Son Ürün Listesi");
        //Console.WriteLine();
        //SqlCommand command2 = new SqlCommand("Select * from Products", connection);
        //SqlDataAdapter adapter = new SqlDataAdapter(command2);
        //DataTable dataTable = new DataTable();
        //adapter.Fill(dataTable);
        //foreach (DataRow row in dataTable.Rows)
        //{
        //    Console.WriteLine($"{row["ProductName"]} - {row["Price"]}₺ - {row["IsStatus"]}\n");
        //}
        //connection.Close();
        #endregion
        #endregion
        Console.Read();
    }
}
