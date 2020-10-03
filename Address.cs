using System;
using System.Collections.Generic;
using System.Text;

namespace Personal_register
{
	class Address
	{
		private string kodpocztowy;
		private string miasto;
		private string ulica;
		private uint numerdomu;
		private uint numerapartamentu;

		public Address(string kodpocztowy, string miasto, string ulica, uint numerdomu, uint numerapartamentu =0)
		{
			this.kodpocztowy = kodpocztowy;
			this.miasto = miasto;
			this.ulica = ulica;
			this.numerdomu = numerdomu;
			this.numerapartamentu = numerapartamentu;
				
		}
		public string KodPocztowy
		{
			get => kodpocztowy;
			set
			{
				if (kodpocztowy.Length <= 6)
				{
					kodpocztowy = value;
				}
			}
		}

		public string Miasto
		{
			get => miasto;
			
			set
			{
				if( String.IsNullOrEmpty(miasto) == false)
				miasto = value;
			}
		}

		public string Ulica { get => ulica; set
			{
				if (String.IsNullOrEmpty(ulica) == false)
					ulica = value;
			}
		}

		public uint NumerDomu
		{ 
			get => numerdomu;
			set => numerdomu = value;
		}

		public uint NumerApartamentu
		{
			get => numerapartamentu;
			set => numerapartamentu = value;
		}
	}
}
