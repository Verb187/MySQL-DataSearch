using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_DataSearch.DataAccess
{
   public class Employee
    {

		public int Id { get; set; }
		public string Nom { get; set; }

		public string Prenom { get; set; }
		public string Adresse { get; set; }
		public string Email { get; set; }
		public string Message { get; set; }

		public string Signalement { get; set; }

		public string Fichier { get; set; }
	}
}
