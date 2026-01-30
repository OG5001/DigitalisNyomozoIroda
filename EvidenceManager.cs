using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class EvidenceManager
	{
		private List<Evidence> evidences;

		public EvidenceManager()
		{
			this.evidences = new List<Evidence>();
		}

		internal List<Evidence> Evidences { get => evidences;}
	}
}
