using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrhaboruOOP
{
	internal class SzallitoUrhajo : Urhajo
	{
		protected int rakterKapacitas;

		public SzallitoUrhajo(int sebesseg, int tamadas, int pancel, string nev, string flotta, int rakterKapacitas) : base(sebesseg, tamadas, pancel, nev, flotta)
		{
			this.rakterKapacitas = rakterKapacitas;
		}

		public int RakterKapacitas { get => rakterKapacitas; set => rakterKapacitas = value; }

		public void Javitas(Urhajo cel)
		{
			int javit = this.Tamadas / 2;
			if (cel.GetType() == typeof(SzallitoUrhajo))
			{
				((SzallitoUrhajo)cel).Sebzes(-javit);
			}
		}
	}
}
