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
		DataStore dataStore = new DataStore();

		public CaseManager()
		{
			this.cases = new List<Case>();
		}

		internal List<Case> Cases { get => cases;}

		
		public void UjÜgy()
		{
			dataStore.Ossz();
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
			dataStore.Cases.Add(uj);
			Menu2();
		}
		public void UgyekListazasa()
		{
			
			dataStore.Ossz();
			foreach (var item in dataStore.Cases)
			{
				Console.WriteLine(item);
			}
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
				if (valasz != "személy" && valasz != "bizonyíték")
				{
					Console.WriteLine("Rosszul írtad be, próbáld meg újra!");
					Console.WriteLine();
				}
				else if (valasz == "személy")
				{
					string sz = "";
					while (sz != "új" && sz != "régi")
					{
						Console.Write("új vagy régi személyt szeretnél megadni: ");
						sz = Console.ReadLine();
						if (sz == "új")
						{
							int val = 100;
							Console.WriteLine();
							Console.Write("kérlek add meg a személy nevét: ");
							string nev = Console.ReadLine();
							Console.WriteLine();
							Console.Write("Kérlek add meg a korát: ");
							int kor = Convert.ToInt32(Console.ReadLine());
							Console.WriteLine();
							Console.Write("Kérlek add meg a leírását: ");
							string leiras = Console.ReadLine();
							Person p = new Person(nev,kor,leiras);
							dataStore.Persons.Add(p);
							Console.WriteLine();
							int val2 = 100;
							Console.WriteLine();
							while (val > dataStore.Cases.Count && val < 0)
							{
								foreach (var a in dataStore.Cases)
								{
									Console.WriteLine(a);
								}
								Console.WriteLine();
								Console.Write("Melyik ügyhöz szeretnéd hozzáadni: ");
								val2 = Convert.ToInt32(Console.ReadLine());
								if (val > dataStore.Cases.Count && val < 0)
								{
									Console.WriteLine();
									Console.WriteLine("Rosszat írtál be, kérlek próbáld újra!");
								}
								else
								{

								}
							}

						}
						else if (sz == "régi")
						{
							Console.WriteLine();
							int val = 100;
							while (val > dataStore.Persons.Count || val < 0)
							{
								dataStore.Ossz();
								Console.WriteLine();
								foreach (var p in dataStore.Persons)
								{
									Console.WriteLine(p);
								}
								Console.WriteLine();
								Console.Write("Kérlek válassz egyet az alábbiak közül: ");
								val = Convert.ToInt32(Console.ReadLine());
								if (val > dataStore.Persons.Count && val < 0)
								{
									Console.WriteLine();
									Console.WriteLine("Rosszat írtál be, kérlek próbáld újra!");
								}
								else
								{
									int val2 = 100;
									Console.WriteLine();
									while (val > dataStore.Cases.Count && val < 0)
									{
										foreach (var p in dataStore.Cases)
										{
											Console.WriteLine(p);
										}
										Console.WriteLine();
										Console.Write("Melyik ügyhöz szeretnéd hozzáadni: ");
										val2 = Convert.ToInt32(Console.ReadLine());
										if (val > dataStore.Cases.Count && val < 0)
										{
											Console.WriteLine();
											Console.WriteLine("Rosszat írtál be, kérlek próbáld újra!");
										}
										else
										{
											
										}
									}
								}
							}
						}
					}


				}
				else if (valasz == "bizonyíték")
				{
					string sz = "";
					while (sz != "új" && sz != "régi")
					{
						Console.Write("új vagy régi bizonyítékot szeretnél megadni: ");
						sz = Console.ReadLine();
						if (sz == "új")
						{
							Console.WriteLine();
							Console.Write("kérlek add meg az azonosítót: ");
							string azonosito = Console.ReadLine();
							Console.WriteLine();
							Console.Write("Kérlek add meg a típusát: ");
							string tipus = Console.ReadLine();
							Console.WriteLine();
							Console.Write("Kérlek add meg a leírását: ");
							string leiras = Console.ReadLine();
							Console.WriteLine();
							Console.WriteLine("Kérlek add meg a megbízhatósági értéket: ");
							int me = Convert.ToInt32(Console.ReadLine());
							Evidence e = new Evidence(azonosito, tipus, leiras, me);
							dataStore.Evidences.Add(e);

						}
						else if (sz == "régi")
						{
							Console.WriteLine();
							int val = 100;
							while (val > dataStore.Evidences.Count || val < 0)
							{
								dataStore.Ossz();
								Console.WriteLine();
								foreach (var p in dataStore.Evidences)
								{
									Console.WriteLine(p);
								}
								Console.WriteLine();
								Console.WriteLine("Kérlek válassz egyet az alábbiak közül: ");
								val = Convert.ToInt32(Console.ReadLine());
								if (val > dataStore.Evidences.Count && val < 0)
								{
									Console.WriteLine();
									Console.WriteLine("Rosszat írtál be, kérlek próbáld újra!");
								}
								else
								{
									int val2 = 100;
									Console.WriteLine();
									while (val > dataStore.Cases.Count && val < 0)
									{
										foreach (var p in dataStore.Cases)
										{
											Console.WriteLine(p);
										}
										Console.WriteLine();
										Console.WriteLine("Melyik ügyhöz szeretnéd hozzáadni: ");
										val2 = Convert.ToInt32(Console.ReadLine());
										if (val > dataStore.Cases.Count && val < 0)
										{
											Console.WriteLine();
											Console.WriteLine("Rosszat írtál be, kérlek próbáld újra!");
										}
										else
										{

										}
									}
								}
							}
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
			while (valasz != "1" && valasz != "2" && valasz != "3" && valasz != "4")
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
					Console.WriteLine();
					Hozzarendeles();
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
