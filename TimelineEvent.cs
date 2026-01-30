using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class TimelineEvent
	{
		private DateTime datum;
		private string esemeny;

		public TimelineEvent(DateTime datum, string esemeny)
		{
			this.datum = datum;
			this.esemeny = esemeny;
		}

		public DateTime Datum { get => datum; set => datum = value; }
		public string Esemeny { get => esemeny; set => esemeny = value; }

		public override string ToString()
		{
			return $"Dátum: {this.datum}\n\tEsemény Leírása: {this.esemeny}";
		}
	}
}
