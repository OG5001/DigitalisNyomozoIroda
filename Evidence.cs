using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class Evidence
	{
		private string azonosito;
		private string tipus;
		private string leiras;
		private int megbizhatosagiErtek;

		public Evidence(string azonosito, string tipus, string leiras, int megbizhatosagiErtek)
		{
			this.azonosito = azonosito;
			this.tipus = tipus;
			this.leiras = leiras;
			this.megbizhatosagiErtek = megbizhatosagiErtek;
		}

		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Tipus { get => tipus; set => tipus = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public int MegbizhatosagiErtek { get => megbizhatosagiErtek; set => megbizhatosagiErtek = value; }

		public override string ToString()
		{
			return $"Azonosító: {this.azonosito}\n\tTípus: {this.tipus}\n\tLeírás: {this.leiras}\n\tMegbízhatósági Érték: {this.megbizhatosagiErtek}";

		}
	}
}
