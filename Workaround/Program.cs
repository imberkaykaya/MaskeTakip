﻿using System.Runtime.InteropServices;

namespace Workaround
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Degiskenler();
			Vatandas vatandas1 = new Vatandas();


			Console.ReadLine();


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
        public long TcNo  { get; set; }
    }
}
