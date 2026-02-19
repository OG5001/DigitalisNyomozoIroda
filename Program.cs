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
			string menu = "";
			Console.WriteLine(@"
1. Ügyek kezelése
2. Idővonal megtekintése
3. Elemzés / döntések
4. Kilépés");
          

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
                        
                    }
                    else if (menu == "3")
                    {

                    }
                    else if (menu == "4")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Hibás számot adott meg! Kérem próbálja újra");
                        Console.WriteLine();
                    }
                }
                while (menu != "4");
		}
	}
}
