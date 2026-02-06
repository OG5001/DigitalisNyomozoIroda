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
		DataStore dataStore = new DataStore();
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
			Menu2();
		}
		public void UgyekListazasa()
		{
			
			dataStore.Ossz();
			Console.WriteLine(dataStore);
			Menu2();
		}
		public void Hozzarendeles()
		{
			Console.WriteLine();

			string valasz = "";
			while (valasz != "személy" || valasz != "bizonyíték")
			{
				Console.Write("Személyt vagy bizonyítékot szeretnél hozzárendelni: ");
				valasz = Console.ReadLine();
				if (valasz != "személy" || valasz != "bizonyíték")
				{
					Console.WriteLine("Rosszul írtad be, próbáld meg újra!");
					Console.WriteLine();
				}
				else if (valasz == "személy")
				{
					string sz = "";
					while (sz != "új" || sz != "régi")
					{
						Console.WriteLine("új vagy régi személyt szeretnél megadni: ");
						sz = Console.ReadLine();
						if (sz == "új")
						{
							Console.WriteLine();
							Console.Write("kérlek add meg a személy nevét: ");
							string nev = Console.ReadLine();
							Console.WriteLine();
							Console.Write("Kérlek add meg a korát: ");
							string kor = Console.ReadLine();
							Console.WriteLine();
							Console.Write("Kérlek add meg a leírását: ");
							string leiras = Console.ReadLine();
							
						}
					}


				}
			}


		}
		public void Menu2()
		{
			Program program = new Program();
			string valasz = "";
			Console.Write(@"
Ügykezelő

Ügyek listázása - 1
Új ügy létrehozása - 2
Személyek és bizonyítékok hozzárendelése - 3
Vissza - 4

Válasszon egy opciót: ");
			while (valasz != "1" || valasz != "2" || valasz != "3" || valasz != "4")
			{
				valasz = Console.ReadLine();
				if (valasz == "1")
				{
					Console.WriteLine();
					UgyekListazasa();
				}
				else if (valasz == "2")
				{
					Console.WriteLine();
					UjÜgy();
				}
				else if (valasz == "3")
				{

				}
				else if (valasz == "4")
				{
					program.Menu();
				}
				else
				{
					Console.WriteLine();
					Console.WriteLine("Rossz számot ütöttél be! Kérlek próbáld újra.");
				}
			}
		}
	}
}
