using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrhaboruOOP
{
	internal class KutatoUrhajo : Urhajo
	{
		Random rnd = new Random();
		protected int szenzorTav;

		public KutatoUrhajo(int sebesseg, int tamadas, int pancel, string nev, string flotta, int szenzorTav) : base(sebesseg, tamadas, pancel, nev, flotta)
		{
			this.szenzorTav = szenzorTav;
		}

		public override void Tamad(Urhajo cel)
		{
			int loves = rnd.Next(50, 120) + this.szenzorTav / 10;

			if (cel.Sebesseg < loves)
			{
				if (cel.GetType() == typeof(KutatoUrhajo))
				{
					((KutatoUrhajo)cel).Sebzes(this.Tamadas);
				}
			}
		}
	}
}
