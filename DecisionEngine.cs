using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class DecisionEngine
	{
		private List<Suspect> suspects;

		public DecisionEngine()
		{
			this.suspects = new List<Suspect>();
		}

		internal List<Suspect> Suspects { get => suspects;}
	}
}
