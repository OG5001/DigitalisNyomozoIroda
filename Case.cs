using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class Case
	{
		private string ugyAzonosito;
		private string cim;
		private string leiras;
		private string allapot;
		private List<Person> person;
		private List<Evidence> evidence;


		public Case(string ugyAzonosito, string cim, string leiras, string allapot)
		{
			this.ugyAzonosito = ugyAzonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.person = new List<Person>();
			this.evidence = new List<Evidence>();
		}

		public string UgyAzonosito { get => ugyAzonosito; set => ugyAzonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		internal List<Person> Person { get => person;}
		internal List<Evidence> Evidence { get => evidence;}

		public override string ToString()
		{
			return $"Ügy Azonosító: {this.ugyAzonosito}\n\tCím: {this.cim}\n\tLeírás: {this.leiras}\n\t Állapot: {this.allapot}";
		}
	}
}
