using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class CaseManager
	{
		private List<Case> cases;

		public CaseManager(List<Case> cases)
		{
			this.cases = cases;
		}

		internal List<Case> Cases { get => cases;}
	}
}
