using System.Security.Cryptography.X509Certificates;

namespace DigitalisNyomozoIroda
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DataStore dataStore = new DataStore();



            dataStore.BeolvasU();
            dataStore.BeolvasP();
            dataStore.BeolvasE();
            dataStore.BeolvasC();
            Menu();
            
        }
		static void Menu()
		{
			CaseManager caseManager = new CaseManager();
			string menu = "";
			Console.WriteLine(@"
1. Ügyek kezelése
2. Személyek kezelése
3. Bizonyítékok kezelése
4. Idővonal megtekintése
5. Elemzés / döntések
6. Kilépés");
            while (menu != "1" || menu != "2" || menu != "3" || menu != "4" || menu != "5" || menu != "6")
            {
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
                else if(menu == "4")
                {

                }
                else if(menu == "5")
                {

                }
                else if(menu == "6")
                {
                    
                }
                else
                {
					Console.WriteLine("Hibás számot adott meg! Kérem próbálja újra");
					Console.WriteLine();
                }
            }
		}
	}
}
