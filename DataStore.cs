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
	}
}
