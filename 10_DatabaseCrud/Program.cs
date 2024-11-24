﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud -> Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();


            Console.WriteLine("---------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.WriteLine("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AN1JPVB\\SQLEXPRESS; initial catalog= EgitimKampiDb; integrated security= true ");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into Category (CategoryName) values (@p1) ", connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AN1JPVB\\SQLEXPRESS; initial catalog= EgitimKampiDb; integrated security= true ");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into Product (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus) ", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün başarıyla eklendi");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AN1JPVB\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security = true ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From Product", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();  
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows) 
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close(); 


            #endregion

            #region Ürün Silme İşlemi

            //Console.WriteLine("Silinecek Urun Id :");   
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AN1JPVB\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security = true ");
            //connection.Open();


            //SqlCommand command = new SqlCommand("Delete From Product Where ProductID = @productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);   
            //command.ExecuteNonQuery();


            //connection.Close();
            //Console.WriteLine("Silme işlemi yapıldı.");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id:");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı:");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı:");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AN1JPVB\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security = true ");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update Product Set ProductName = @productName, ProductPrice = @productPrice where ProductID = @productId", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productID", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı");

            #endregion

            Console.Read();
        }
    }
}
