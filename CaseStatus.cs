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

		public CaseStatus(string aktualisStatusz)
		{
			aktualisStatusz = aktualisStatusz;
		}

		public string Status { get => aktualisStatusz; set => aktualisStatusz = value; }

		public string allapot(string s)
		{;
			aktualisStatusz = s;
			return aktualisStatusz;
		}
	}
}
