using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
    internal class Timeline
    {
        List<Case> cases = new List<Case>();
        DataStore dataStore = new DataStore();

        public Timeline()
        {
            this.cases = new List<Case>();
        }

        internal List<Case> Cases { get => cases; }

        public void Ido()
        {
            foreach (var p in dataStore.Cases)
            {
                Console.WriteLine(p);
            }
        }

        public void Hozzaadas()
        {
            dataStore.Ossz();
            int val = 100;
            DateTime D = DateTime.Now;
            Console.WriteLine();
            Console.Write("Kérlek add meg az eseményt: ");
            string e = Console.ReadLine();
            TimelineEvent p = new TimelineEvent(D, e);
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
                    dataStore.Cases[val].TimelineEvents.Add(p);
                    Console.WriteLine();
                    Console.WriteLine("Sikeresen hozzáadás!");
                }
            }

        }
        public void Menu5()
        {
            Program program = new Program();
            Console.WriteLine();
            string valasz = "";
            while (valasz != "3")
            {
                Console.WriteLine(@"
IDŐVONAL KEZELŐ

1. Idővonal megtekintése
2. Hozzáadás
3. Vissza");
                Console.WriteLine();
                Console.Write("Válasszon egy opciót: ");
                valasz = Console.ReadLine();
                if (valasz == "1")
                {
                    Console.WriteLine();
                    Ido();
                }
                else if (valasz == "2")
                {
                    Console.WriteLine();
                    Hozzaadas();
                }
                else if (valasz == "3")
                {
                    program.Menu();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Rossz számot ütöttél be! Próbáld újra!");
                }
            }

        }
    }
}
