using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class CaseStatus
	{
		private string aktualisStatusz;

		public CaseStatus(string aktualisStatuszstatus)
		{
			aktualisStatusz = aktualisStatuszstatus;
		}

		public string Status { get => aktualisStatusz; set => aktualisStatusz = value; }

		public string allapot(string s)
		{
			Console.WriteLine("");
			string abc = Console.ReadLine();
			aktualisStatusz = s;
			return aktualisStatusz;
		}
	}
}
