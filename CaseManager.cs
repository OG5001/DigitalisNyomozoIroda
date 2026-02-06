using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class CaseManager
	{
		List<Case> cases = new List<Case>();

		public CaseManager()
		{
			this.cases = new List<Case>();
		}

		internal List<Case> Cases { get => cases;}

		
		public void UjÜgy()
		{
			Console.WriteLine();
			Console.Write("Kérem az új ügy azonosítóját: ");
			string c = Console.ReadLine();
			Console.WriteLine();
			Console.Write("Kérem a címet: ");
			string c2 = Console.ReadLine();
			Console.WriteLine();
			Console.Write("Kérem a leírást: ");
			string c3 = Console.ReadLine();
			Console.WriteLine();
			Console.Write("Kérem az állapotát: ");
			string c4 = Console.ReadLine();
			Case uj = new Case($"{c}", $"{c2}", $"{c3}", $"{c4}");
			cases.Add(uj);
		}
		public void Menu2()
		{
			Console.WriteLine(@"
Ügykezelő

Válasszon egy opciót
Ügyek listázása - 1
Új ügy létrehozása - 2
Személyek és bizonyítékok hozzárendelése - 3");

		}
	}
}
