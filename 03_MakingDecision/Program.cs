using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Sifre Dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sifre Yanlis");
            //}

            //string Capital, Country;
            //Console.WriteLine("Baskenti Giriniz:" );
            //Capital = Console.ReadLine();

            //Console.WriteLine("Ulke Giriniz:" );
            //Country = Console.ReadLine();

            //if (Capital == "ankara" & Country == "turkiye")
            //{
            //    Console.Write("Veriler Dogrulandi");
            //}
            //else 
            //{
            //    Console.Write("Veriler Hatali");
            //}

            //int number;
            //Console.Write("Sayiyi Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayi Dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi Hatali");
            //}

            //int exam1, exam2, exam3, average;
            //string result ="hatali";

            //Console.Write("Sinav1; ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sinav2; ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sinav3; ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sinavlarin Ortalamasi: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuc Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuc Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuc iyi";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuc Cok iyi";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lutfen Sehir girisi yapiniz: ");
            //city = Console.ReadLine();

            //if(city == "adana" | city =="ankara" | city== "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("sehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("sehir mevcut degil");
            //}


            //Console.Write("Lutfen Kullanici adini giriniz: ");
            //string username = Console.ReadLine();
            //if(username != "admin")
            //{
            //    Console.Write("bu kullanici adi kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("hos geldiniz");
            //}

            #endregion\

            #region Mod Islemleri

            //int number;
            //number = 26;
            //int result = number % 5;

            //Console.WriteLine(result);

            //Console.Write("Lutfen 1.sayiyi giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen 2.sayiyi giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.Sayinin 2.Sayiya Bolumunden kalan: " + result );

            //Console.Write("Lutfen sayiyi giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayi Cifttir");
            //}
            //else
            //{
            //    Console.Write("Sayi Tektir");
            //}

            #endregion

            #region Char Degiskenler Ile Karar Yapilari
            //char team;
            //Console.Write("Takim sembolunu giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fener");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Besiktas");
            //}
            //if (team == 't' | team == 'T')
            //{
            //    Console.Write("Trabzonspor");
            //}
            #endregion

            #region Ornek Proje Uygulamasi

            //Console.WriteLine("****** C# Egitim Kampi Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Corbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-Icecekler");
            //Console.WriteLine("5-Tatlilar");
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Menu Seciniz");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kori Soslu Tavuk");
            //    Console.WriteLine("2-Firinda Somon");
            //    Console.WriteLine("3-Kebap");
            //    Console.WriteLine("4-Iskender");
            //    Console.WriteLine("5-Firinda Tavuk");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Corbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Corbasi");
            //    Console.WriteLine("2-Ezogelin Corbasi");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Icecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlilar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trilice");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sutlac");
            //}
            #endregion

            #region Switch Case

            //Console.Write("Ay Girisi Yapiniz");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Subat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayis"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Agustos"); break;
            //    case 9: Console.Write("Eylul"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasim"); break;
            //    case 12: Console.Write("Aralik"); break;
            //    default: Console.WriteLine("Hatali Vei Girisi"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1 , number2, result;
            //char symbol;

            //Console.Write("1.Sayiyi Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayiyi Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Islemi Giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+': 
            //        result = number1 + number2; 
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Carpim: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bolum: " + result);
            //        break;
            //}


            #endregion

            Console.Read();
        }
    }
}
