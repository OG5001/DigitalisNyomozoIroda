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
		}
		public void UgyekListazasa()
		{
			
			dataStore.Ossz();
			foreach (var item in dataStore.Cases)
			{
				Console.WriteLine(item);
			}

		}
		public void Hozzarendeles()
		{
			Console.WriteLine();

			string valasz = "";
			while (valasz != "személy" && valasz != "bizonyíték")
			{
				Console.Write("Személyt vagy bizonyítékot szeretnél hozzárendelni: ");
				valasz = Console.ReadLine().ToLower();
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
							dataStore.Ossz();
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
                            while (val > dataStore.Cases.Count || val < 0)
                            {
                                foreach (var a in dataStore.Cases)
                                {
                                    Console.WriteLine(a);
                                }
                                Console.WriteLine();
                                Console.WriteLine("Melyik ügyhöz szeretnéd hozzáadni (index szerint): ");
                                val = Convert.ToInt32(Console.ReadLine());
                                if (val > dataStore.Cases.Count || val < 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Rosszat írtál be, kérlek próbáld újra!");
                                }
                                else
                                {
                                    dataStore.Cases[val].Person.Add(p);
                                    Console.WriteLine();
                                    Console.WriteLine("Sikeresen hozzáadás!");
                                }
                            }

                        }
						else if (sz == "régi")
						{
							Console.WriteLine();
							int val = 100;
							int val2 = 100;
							while (val > dataStore.Persons.Count || val < 0)
							{
								dataStore.Ossz();
								Console.WriteLine();
								foreach (var p in dataStore.Persons)
								{
									Console.WriteLine(p);
								}
								Console.WriteLine();
								Console.Write("Kérlek válassz egyet az alábbiak közül (index szerint): ");
								val2 = Convert.ToInt32(Console.ReadLine());
								if (val2 > dataStore.Persons.Count || val2 < 0)
								{
									Console.WriteLine();
									Console.WriteLine("Rosszat írtál be, kérlek próbáld újra!");
								}
								else
								{
                                    Person asd = dataStore.Persons[val2];
                                    val = 100;
									Console.WriteLine();
									while (val > dataStore.Cases.Count || val < 0)
									{
										foreach (var p in dataStore.Cases)
										{
											Console.WriteLine(p);
										}
										Console.WriteLine();
										Console.Write("Melyik ügyhöz szeretnéd hozzáadni (index szerint): ");
										val = Convert.ToInt32(Console.ReadLine());
										if (val > dataStore.Cases.Count || val < 0)
										{
											Console.WriteLine();
											Console.WriteLine("Rosszat írtál be, kérlek próbáld újra!");
										}
										else
										{
											dataStore.Cases[val].Person.Add(asd);
                                            Console.WriteLine();
                                            Console.WriteLine("Sikeresen hozzáadás!");
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
							dataStore.Ossz();
							int val = 100;
							Console.WriteLine();
							Console.Write("kérlek add meg az azonosítót: ");
							string azonosito = Console.ReadLine();
							Console.WriteLine();
							Console.Write("Kérlek add meg a típusát (fotó, dokumentum, digitális adat): ");
							string tipus = Console.ReadLine();
							Console.WriteLine();
							Console.Write("Kérlek add meg a leírását: ");
							string leiras = Console.ReadLine();
							Console.WriteLine();
							Console.Write("Kérlek add meg a megbízhatósági értéket (1-5): ");
							int me = Convert.ToInt32(Console.ReadLine());
							Evidence e = new Evidence(azonosito, tipus, leiras, me);
							dataStore.Evidences.Add(e);
							Evidence abc = e;
                            Console.WriteLine();
                            while (val > dataStore.Cases.Count || val < 0)
                            {
                                foreach (var p in dataStore.Cases)
                                {
                                    Console.WriteLine(p);
                                }
                                Console.WriteLine();
                                Console.WriteLine("Melyik ügyhöz szeretnéd hozzáadni (index szerint): ");
                                val = Convert.ToInt32(Console.ReadLine());
                                if (val > dataStore.Cases.Count || val < 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Rosszat írtál be, kérlek próbáld újra!");
                                }
                                else
                                {
                                    dataStore.Cases[val].Evidence.Add(abc);
                                    Console.WriteLine();
                                    Console.WriteLine("Sikeresen hozzáadás!");
                                }
                            }

                        }
						else if (sz == "régi")
						{
                            Console.WriteLine();
                            int val = 100;
                            int val2 = 100;
                            while (val > dataStore.Evidences.Count || val < 0)
                            {
                                dataStore.Ossz();
                                Console.WriteLine();
                                foreach (var p in dataStore.Evidences)
                                {
                                    Console.WriteLine(p);
                                }
                                Console.WriteLine();
                                Console.Write("Kérlek válassz egyet az alábbiak közül (index szerint): ");
                                val2 = Convert.ToInt32(Console.ReadLine());
                                if (val2 > dataStore.Evidences.Count || val2 < 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Rosszat írtál be, kérlek próbáld újra!");
                                }
                                else
                                {
                                    Evidence asd = dataStore.Evidences[val2];
                                    val = 100;
                                    Console.WriteLine();
                                    while (val > dataStore.Cases.Count || val < 0)
                                    {
                                        foreach (var p in dataStore.Cases)
                                        {
                                            Console.WriteLine(p);
                                        }
                                        Console.WriteLine();
                                        Console.Write("Melyik ügyhöz szeretnéd hozzáadni (index szerint): ");
                                        val = Convert.ToInt32(Console.ReadLine());
                                        if (val > dataStore.Cases.Count || val < 0)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Rosszat írtál be, kérlek próbáld újra!");
                                        }
                                        else
                                        {
                                            dataStore.Cases[val].Evidence.Add(asd);
                                            Console.WriteLine();
                                            Console.WriteLine("Sikeresen hozzáadás!");
                                        }
                                    }
                                }
                            }
                        }
					}
				}
			}


		}
		public void CaseStatus()
		{
			dataStore.Ossz();
			int valasz = -1;
			string valasz2 = "";
			while (valasz < 0 || valasz > dataStore.Cases.Count)
			{
                Console.WriteLine();
				foreach (var p in dataStore.Cases)
				{
					Console.WriteLine(p);
				}
                Console.Write("Melyik ügyet státuszát szeretnéd megváltoztatni (index szerint): ");
				valasz = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();
				if (valasz < 0 || valasz > dataStore.Cases.Count)
				{
					Console.WriteLine("Hibás indexet ütöttél be. Próbáld újra!");
				}
			}
            Console.Write("Mire szeretnéd megváltoztatni a státuszt: ");
            string ujAllapot = Console.ReadLine();
            dataStore.Cases[valasz].Allapot = ujAllapot;


        }
        public void Menu2()
		{
			Program program = new Program();
			string valasz = "";
			while (valasz != "5")
			{
                Console.Write(@"
ÜGYKEZELŐ

Ügyek listázása - 1
Új ügy létrehozása - 2
Személyek és bizonyítékok hozzárendelése - 3
Ügy állapotának módosítása - 4
Vissza - 5

Válasszon egy opciót: ");
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
					CaseStatus();
				}
				else if (valasz == "5")
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
