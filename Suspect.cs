using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class Suspect
	{
		List<Person> person = new List<Person>();
		private int szint;
		private string status;

		public Suspect(int szint, string status)
		{
			this.person = new List<Person>();
            this.szint = szint;
			this.status = status;
		}

		public int Szint { get => szint; set => szint = value; }
		public string Status { get => status; set => status = value; }
        internal List<Person> Person { get => person; }

        public override string ToString()
		{
            string szemelyek = person.Count > 0
		? string.Join(", ", person.Select(p => p.Nev))
		: "Nincs";
            return $"Gyanusított Adatok: {szemelyek}\n\tGyanusítottsági szint:{this.szint}\n\tStátusz: {this.status}";
		}
	}
}
