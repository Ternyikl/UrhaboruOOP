using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrhaboruOOP
{
	internal class Urhajo
	{
		Random rnd = new Random();
		private int sebesseg;
		private int tamadas;
		private int pancel;
		private string nev;
		private string flotta;

		public Urhajo(int sebesseg, int tamadas, int pancel, string nev, string flotta)
		{
			this.sebesseg = sebesseg;
			this.tamadas = tamadas;
			this.pancel = pancel;
			this.nev = nev;
			this.flotta = flotta;
		}

		public int Sebesseg { get => sebesseg; set => sebesseg = value; }
		public int Tamadas { get => tamadas; set => tamadas = value; }
		public int Pancel { get => pancel; }
		public string Nev => nev;
		public string Flotta => flotta;

		protected void Sebzes(int s)
		{
			if (s < this.pancel)
			{
				this.pancel -= s;
			}
			else 
			{
				this.pancel = 0;
			}
		}

		public virtual void Tamad(Urhajo cel)
		{
			int loves = rnd.Next(50, 120);

			if(cel.sebesseg < loves)
			{
				cel.Sebzes(this.tamadas);
			}
		}
	}
}
