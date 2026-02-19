using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
    internal class PersonManager
    {
        List<Evidence> evidences = new List<Evidence>();
        DataStore dataStore = new DataStore();

        public PersonManager()
        {
            this.evidences = new List<Evidence>();
        }

        internal List<Evidence> Evidences { get => evidences; }
        public void UjPer()
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
            Person p = new Person(nev, kor, leiras);
            dataStore.Persons.Add(p);
        }
        public void PerTorles()
        {
            Console.WriteLine();
            int valasz = -1;
            while (valasz < 0 || valasz > dataStore.Persons.Count)
            {
                foreach (var p in dataStore.Persons)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
                Console.Write("Melyik személyt szeretnéd törölni (index szerint): ");
                valasz = Convert.ToInt32(Console.ReadLine());
                dataStore.Persons.RemoveAt(valasz);
            }
        }
        public void Lis()
        {
            dataStore.Ossz();
            Console.WriteLine();
            Console.WriteLine("Személyek listája:");
            Console.WriteLine();
            foreach (var p in dataStore.Persons)
            {
                Console.WriteLine(p);
            }
        }
        public void Menu4()
        {
            Program program = new Program();
            string valasz = "";
            while (valasz != "4")
            {
                Console.WriteLine(@"
SZEMÉLYKEZELŐ

1. Személy hozzáadása
2. Személy törlése
3. listázás
4. vissza");
                Console.WriteLine();
                Console.Write("Válassz egy opciót: ");
                valasz = Console.ReadLine();
                if (valasz == "1")
                {
                    Console.WriteLine();
                    UjPer();
                }
                else if (valasz == "2")
                {
                    Console.WriteLine();
                    PerTorles();
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
