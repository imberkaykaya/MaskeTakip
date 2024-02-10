using Business.Concrete;
using Entities.Concrete;
using System.Runtime.InteropServices;

namespace Workaround
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Degiskenler();
			Vatandas vatandas1 = new Vatandas();
			SelamVer("Bıdık");
			SelamVer();

			int sonuc = Topla(3, 5);

			//Diziler - Arrays

			string[] ogrenciler = new string[3];
			ogrenciler[0] = "Engin";
			ogrenciler[1] = "Berkay";
			ogrenciler[2] = "Kerem";

			for (int i = 0; i < ogrenciler.Length; i++)
			{
				Console.WriteLine(ogrenciler[i]);
			}

			string[] sehirler1 = new[] { "Ankara", "Tokat", "Manisa" };
			string[] sehirler2 = new[] { "Yozgat", "Diyarbakır", "Edirne" };
			sehirler2 = sehirler1;
			sehirler1[0] = "Balıkesir";
			Console.WriteLine(sehirler2[0]);


			Person person1 = new Person();
			person1.FirstName = "Berkay";
			person1.LastName = "Kaya";
			person1.DateOfBirthYear = 2000;
			person1.NationalIdentity = 52945610226;


			Person person2 = new Person();
			person2.FirstName = "Engin";

			foreach (var sehir in sehirler1)
			{
				Console.WriteLine(sehir);
			}

			List<string> yeniSehirler = new List<string> { "Ankara", "Tokat", "Manisa" };
			yeniSehirler.Add("İzmir");

			foreach (var sehir in yeniSehirler)
			{
				Console.WriteLine(sehir);
			}

			PttManager pttManager = new PttManager(new PersonManager());
			pttManager.GiveMask(person1);

		}
		static void SelamVer(string isim = "BenSeninAnonim")
		{
			Console.WriteLine("Merhaba " + isim);
		}
		//default parametreler değişkenin sonuna verilir.
		static int Topla(int sayi1, int sayi2 = 3)
		{
			int sonuc = sayi1 + sayi2;
			Console.WriteLine("Toplam: " + sonuc.ToString());
			return sonuc;
		}

		private static void Degiskenler()
		{
			string mesaj = "Merhaba";
			double tutar = 100000; // db'den gelir
			int sayi = 100;
			bool girisYapmisMi = false;

			string ad = "Berkay";
			string soyad = "Kaya";
			int dogumYili = 2000;
			long TcNo = 1234567890;

			Console.WriteLine(tutar * 0.18);
			Console.WriteLine(tutar * 1.18);
		}
	}

	public class Vatandas()
	{
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public int DogumYili { get; set; }
		public long TcNo { get; set; }
	}
}
