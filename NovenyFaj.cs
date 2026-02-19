using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UveghazRendszer
{
	internal class NovenyFaj
	{

		string nev;
		int vizigeny; //max 100, azon tul romlo allapot
		int egeszsegiAllapot; //0-10 (0: alpusztult)
		int optimalisSuruseg;

		public NovenyFaj(string nev, int vizigeny, int egeszsegiAllapot, int optimalisSuruseg)
		{

			this.Nev = nev;
			this.Vizigeny = vizigeny;
			this.EgeszsegiAllapot = egeszsegiAllapot;
			this.OptimalisSuruseg = optimalisSuruseg;
		}

		public string Azonosito { get => this.nev.Substring(0, 3);}
		public string Nev { get => nev; set => nev = value; }
		public int Vizigeny { get => vizigeny; set => vizigeny = value; }
		public int EgeszsegiAllapot { get => egeszsegiAllapot; set => egeszsegiAllapot = value; }
		public int OptimalisSuruseg { get => optimalisSuruseg; set => optimalisSuruseg = value; }

		public override string ToString()
		{
			return $"{this.nev} ({this.Azonosito}) {this.vizigeny} {this.egeszsegiAllapot}";
		}
	
	}
}
