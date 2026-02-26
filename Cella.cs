using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UveghazRendszer
{
	internal class Cella
	{
		Pozicio poz;
		NovenyFaj noveny;
		int egyedszam;
		List<Riasztas> riasztasok;
		List<Szenzor> szenzorok;

		internal Pozicio Poz { get => poz; set => poz = value; }
		internal NovenyFaj Noveny { get => noveny; set => noveny = value; }
		public int Egyedszam { get => egyedszam; set => egyedszam = value; }
		internal List<Riasztas> Riasztasok { get => riasztasok; set => riasztasok = value; }
		internal List<Szenzor> Szenzorok { get => szenzorok; set => szenzorok = value; }

		public Cella(Pozicio poz)
		{
			NovenyFaj noveny = null;
			this.Poz = poz;
			egyedszam = 0;
			Riasztasok = new List<Riasztas>();
			Szenzorok = new List<Szenzor>();
		}


		public bool UresCella
		{
			get {
				return this.noveny == null;
			}

		}
		public bool Beultet(NovenyFaj noveny, int egyedSzam)
		{

			if (this.UresCella)
			{
				this.noveny = noveny;
				this.egyedszam = egyedszam;
				return true;
			}
			else if (noveny == this.noveny)
			{
				this.egyedszam += egyedszam;
				if (this.egyedszam > noveny.OptimalisSuruseg)
				{
					this.noveny.EgeszsegiAllapot -= 2;
				}
				return true;
			}
			else
			{
				return false;
			}

		}

		public void Noveles(int egyedzam)
		{
			this.Beultet(this.noveny, egyedzam);
		}
		public void Csokkentes(int egyedSzam)
		{
			this.egyedszam -= egyedSzam;
			if (this.egyedszam <= 0)
			{
				this.Urit();
			}
		}

		public void Urit()
		{
			this.egyedszam = 0;
			this.noveny = null;
		}

		public override string ToString()
		{
			
			return $"{this.noveny.Nev} {this.egyedszam} db, Állapot: {this.Noveny.EgeszsegiAllapot}";
		}

	}
}
