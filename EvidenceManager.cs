using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class EvidenceManager
	{
        List<Evidence> evidences = new List<Evidence>();
        DataStore dataStore = new DataStore();

        public EvidenceManager()
        {
            this.evidences = new List<Evidence>();
        }

        internal List<Evidence> Evidences { get => evidences; }
        public void UjBiz()
        {
            Console.WriteLine();
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
        }
        public void BizTorles()
        {
            Console.WriteLine();
            int valasz = -1;
            while (valasz < 0 || valasz > dataStore.Evidences.Count)
            {
                foreach (var p in dataStore.Evidences)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
                Console.Write("Melyik bizonyítékot szeretnéd törölni (index szerint): ");
                valasz = Convert.ToInt32(Console.ReadLine());
                dataStore.Evidences.RemoveAt(valasz);
            }
        }
        public void Lis()
        {
            dataStore.Ossz();
            Console.WriteLine();
            Console.WriteLine("Bizonyítékok listája:");
            Console.WriteLine();
            foreach (var p in dataStore.Evidences)
            {
                Console.WriteLine(p);
            }
        }
        public void Menu3()
        {
            Program program = new Program();
            string valasz = "";
            while (valasz != "4")
            {
                Console.WriteLine(@"
BIZONYÍTÉKKEZELŐ

1. bizonyíték hozzáadása
2. bionyíték törlése
3. listázás
4. vissza");
                Console.WriteLine();
                Console.Write("Válassz egy opciót: ");
                valasz = Console.ReadLine();
                if (valasz == "1")
                {
                    Console.WriteLine();
                    UjBiz();
                }
                else if (valasz == "2")
                {
                    Console.WriteLine();
                    BizTorles();
                }
                else if (valasz == "3")
                {
                    Console.WriteLine();
                    Lis();
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
