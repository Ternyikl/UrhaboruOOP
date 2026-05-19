using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrhaboruOOP
{
	internal class HarciUrhajo : Urhajo
	{
		protected int fegyverEro;

		public HarciUrhajo(int sebesseg, int tamadas, int pancel, string nev, string flotta, int fegyverEro) : base(sebesseg, tamadas, pancel, nev, flotta)
		{
			this.fegyverEro = fegyverEro;
		}

		public int FegyverEro { get => fegyverEro; set => fegyverEro = value; }

		public override void Tamad(Urhajo cel)
		{
			for (int i = 0; i < 2; i++)
			{
				base.Tamad(cel);
			}
		}
	}
}
