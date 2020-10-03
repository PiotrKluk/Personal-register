using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Personal_register
{
	class Osoba
	{
		private string imie;
		private string nazwisko;
		private uint wiek;
		private char plec;
		private Address adres;

		public Osoba (string imie, string nazwisko, uint wiek, char plec, Address adres)
        {
			this.imie = imie;
			this.nazwisko = nazwisko;
			this.wiek = wiek;
			this.plec = plec;
			this.adres = adres;
        }

		public string Imie
		{
			get => imie;
			set
			{
				if (String.IsNullOrEmpty(imie) == false)
					imie = value;
			}
		}

		public string Nazwisko
		{
			get => nazwisko;
			set
			{
				if (String.IsNullOrEmpty(nazwisko) == false)
					nazwisko = value;
			}
		}
		public uint Wiek 
		{ 
			get => wiek;
			set => wiek = value;
		}

		public char Plec
		{
			get => plec; set
			{
				if (plec == 'k' || plec == 'l')
					plec = value;
			}
		}

		internal Adress adres
		{
			get => adres; set
			{
				if (adres != null)
				{
					adres = value;
				}
			}
		}
	}
}
