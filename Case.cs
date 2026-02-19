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
		List<Person> person = new List<Person>();	
		List<Evidence> evidence = new List<Evidence>();
		


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
            string szemelyek = person.Count > 0
		? string.Join(", ", person.Select(p => p.Nev))
		: "Nincs";

            string bizonyitekok = evidence.Count > 0
		? string.Join(", ", evidence.Select(e => e.Leiras))
		: "Nincs";


            return $"Ügy Azonosító: {this.ugyAzonosito}\n\tCím: {this.cim}\n\tLeírás: {this.leiras}\n\tÁllapot: {this.allapot}\n\tHozzáadott személy: {szemelyek}\n\tHozzáadott bizonyítékok: {bizonyitekok}";
		}		
	}
}
