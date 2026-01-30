using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class Suspect
	{
		private Person person;
		private int szint;
		private string status;

		public Suspect(Person person, int szint, string status)
		{
			this.person = person;
			this.szint = szint;
			this.status = status;
		}

		public int Szint { get => szint; set => szint = value; }
		public string Status { get => status; set => status = value; }
		internal Person Person { get => person; set => person = value; }

		public override string ToString()
		{
			return $"Gyanusított Adatok: {this.Person.ToString}\nGyanusítottsági szint:{this.szint}\nStátusz: {this.status}";
		}
	}
}
