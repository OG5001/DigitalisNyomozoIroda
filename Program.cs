using System.Security.Cryptography.X509Certificates;

namespace DigitalisNyomozoIroda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Béla", 23, "jó gyerek");
            Suspect s = new Suspect(p, 100, "Mégse olyan jó gyerek");
            Menu();

        }
		static void Menu()
		{
            int menu = 0;
			Console.WriteLine(@"
1. Ügyek kezelése
2. Személyek kezelése
3. Bizonyítékok kezelése
4. Idővonal megtekintése
5. Elemzés / döntések
6. Kilépés");
            while (menu < 1 || menu > 6)
            {
                Console.WriteLine();
                Console.Write("Válassz egy menüpontot: ");
                menu =Convert.ToInt32( Console.ReadLine());
                if (menu == 1)
                {

                }
                else if (menu == 2)
                {

                }
                else if (menu == 3)
                {

                }
                else if(menu == 4)
                {

                }
                else if(menu == 5)
                {

                }
                else if(menu == 6)
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
