using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class DataStore
	{
		private List<User> users;
		private List<Case> cases;
		private List<Person> persons;
		private List<Evidence> evidences;
		private List<Suspect> suspects;
		private List<TimelineEvent> timelines;
		private List<Witness> witnesss;

		public DataStore()
		{
			this.users = new List<User>();
			this.cases = new List<Case>();
			this.persons = new List<Person>();
			this.evidences = new List<Evidence>();
			this.suspects = new List<Suspect>();
			this.timelines = new List<TimelineEvent>();
            this.witnesss = new List<Witness>();
        }

		internal List<User> Users { get => users;}
		internal List<Case> Cases { get => cases;}
		internal List<Person> Persons { get => persons;}
		internal List<Evidence> Evidences { get => evidences;}
        internal List<Suspect> Suspects { get => suspects;}
        internal List<TimelineEvent> Timelines { get => timelines; }
        internal List<Witness> Witnesss { get => witnesss; }


        public void BeolvasP()
		{

		
			Person p = new Person("Hurkás Béla", 23, "Eléggé túlsúlyos");
			Person p2 = new Person("Lakatos Bence", 52, "Neve ellenére nem lakatos a foglalkozása");
			persons.Add(p);
			persons.Add(p2);
		}
		public void BeolvasE()
		{
	
			Evidence e = new Evidence("241356", "fotó", "A kép egy összetört autót ábrázol", 3);
			evidences.Add(e);
			Evidence e2 = new Evidence("42451", "dokumentum", "Fontos dokumentumok egy DEA ügyben", 5);
			evidences.Add(e2);
		}

		public void BeolvasU()
		{
		
			User u = new User("Erős Robi", "327385", "Elemző");
			users.Add(u);
			User u2 = new User("Kovács Péter", "132452", "Nyomozó");
			users.Add(u2);
		}

		public void BeolvasC()
		{
			Case c = new Case("235765", "Karambolás", "Ittas sofőr ütközött egy másik ittas sofőrrel.", "nyitott");
			cases.Add(c);
			Case c2 = new Case("345987", "Betörés", "Egy haloweeni jelmezbe öltözött férfi tört be a 09.Kerület Bors utca 2-be.", "lezárt");
			cases.Add(c2);
		}
		public void BeolvasS()
		{
			Suspect s = new Suspect(80, "megfigyelt");
			suspects.Add(s);
            Suspect s2 = new Suspect(10, "szabad");
            suspects.Add(s2);
			Person abc = persons[0];
			Person abc2 = persons[1];
			suspects[1].Person.Add(abc);
			suspects[0].Person.Add(abc2);
        }
		public void BeolvasT()
		{
			DateTime date = new DateTime(2025, 2, 23, 14, 30, 0);
			TimelineEvent t = new TimelineEvent(date, "Haladás a nyomozásban!!!");
			timelines.Add(t);
			DateTime date2 = DateTime.Now;
			TimelineEvent t2 = new TimelineEvent(date2, "Nem sok minden történt ma");
			timelines.Add(t2);
		}
		public void BeolvasW()
		{
            DateTime date = new DateTime(2025, 2, 23, 14, 30, 0);
            Witness w = new Witness("Láttam egy gyanús alakot", date);
			witnesss.Add(w);
            DateTime date2 = DateTime.Now;
			Witness w2 = new Witness("Nem láttam semmit", date2);

        }
        public void Ossz()
        {
            if (cases.Count == 0) BeolvasC();
            if (evidences.Count == 0) BeolvasE();
            if (persons.Count == 0) BeolvasP();
            if (users.Count == 0) BeolvasU();
            if (users.Count == 0) BeolvasT();
            if (users.Count == 0) BeolvasS();
            if (users.Count == 0) BeolvasW();
        }

    }
}
