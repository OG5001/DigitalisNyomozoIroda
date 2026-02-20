using System.Security.Cryptography.X509Certificates;

namespace DigitalisNyomozoIroda
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DataStore dataStore = new DataStore();
            Program program = new Program();

            dataStore.Ossz();
            program.Menu();
            
        }
		public void Menu()
		{
			CaseManager caseManager = new CaseManager();
            EvidenceManager evidenceManager = new EvidenceManager();
            PersonManager personManager = new PersonManager();
            Timeline timeline = new Timeline();
            string menu = "";
			Console.WriteLine(@"
DIGITÁLIS NYOMOZÓIRODA

1. Ügyek kezelése
2. Személyek kezelése
3. Bizonyítékok kezelése
4. Idővonal megtekintése
5. Kilépés");
          

                do
                {
                    menu = "";
				    Console.WriteLine();
				    Console.Write("Válassz egy menüpontot: ");
				    menu = Console.ReadLine();
				    if (menu == "1")
                    {
                        caseManager.Menu2();
                    }
                    else if (menu == "2")
                    {
                        personManager.Menu4();
                    }
                    else if (menu == "3")
                    {
                        evidenceManager.Menu3();
                    }
                    else if (menu == "4")
                    {
                        timeline.Menu5();
                    }
                    else if (menu == "5")
                    {
                        return;
                    }
                    else
                {
                    Console.WriteLine("Hibás számot adott meg! Kérem próbálja újra");
                    Console.WriteLine();
                }
                }
                while (menu != "5");
		}
	}
}
