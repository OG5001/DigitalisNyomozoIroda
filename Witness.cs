using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class Witness
	{
		private Person person;
		private string vallomas;
		private string datum;

		public Witness(Person person, string vallomas, string datum)
		{
			this.person = person;
			this.vallomas = vallomas;
			this.datum = datum;
		}

		public string Vallomas { get => vallomas; set => vallomas = value; }
		public string Datum { get => datum; set => datum = value; }
		internal Person Person { get => person; set => person = value; }

		public override string ToString()
		{
			return $"Szemtanú adatai: {this.Person.ToString()}\n\tVallomás Szövege: {this.vallomas}\n\tVallomás Dátuma: {this.datum}";
		}
	}
}
