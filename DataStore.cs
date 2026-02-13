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

		public DataStore()
		{
			this.users = new List<User>();
			this.cases = new List<Case>();
			this.persons = new List<Person>();
			this.evidences = new List<Evidence>();
		}

		internal List<User> Users { get => users;}
		internal List<Case> Cases { get => cases;}
		internal List<Person> Persons { get => persons;}
		internal List<Evidence> Evidences { get => evidences;}

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
		public void Ossz()
		{
			BeolvasC();
			BeolvasE();
			BeolvasP();
			BeolvasU();
		}
	}
}
