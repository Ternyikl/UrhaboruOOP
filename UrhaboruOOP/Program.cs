using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrhaboruOOP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Urhajo u1 = new Urhajo(90, 50, 50, "Requiem", "Transport LLC.");
			HarciUrhajo hu1 = new HarciUrhajo(90, 120, 100, "Orion", "Birodalom", 250);
			SzallitoUrhajo szu1 = new SzallitoUrhajo(90, 120, 100, "Atlas", "Birodalom", 3000);
			KutatoUrhajo ku1 = new KutatoUrhajo(90, 120, 100, "Nova", "Birodalom", 150);
		}
	}
}
