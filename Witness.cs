using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class Witness
	{
		List <Person> person = new List <Person>();
		private string vallomas;
		private DateTime datum;

		public Witness(string vallomas, DateTime datum)
		{
            this.person = new List<Person>();
            this.vallomas = vallomas;
			this.datum = datum;
		}

		public string Vallomas { get => vallomas; set => vallomas = value; }
		public DateTime Datum { get => datum; set => datum = value; }
        internal List<Person> Person { get => person; }

        public override string ToString()
		{
            string szemelyek = person.Count > 0
? string.Join(", ", person.Select(p => p.Nev))
: "Nincs";
            return $"Szemtanú adatai: {szemelyek}\n\tVallomás Szövege: {this.vallomas}\n\tVallomás Dátuma: {this.datum}";
		}
	}
}
