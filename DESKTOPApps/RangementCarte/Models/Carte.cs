using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangementCarte.Models
{
	public class Carte
	{
		public int Id { get; set; }
		public string MatriculeNational { get; set; }
		public string Boxe { get; set; }
		public string Nom { get; set; }
		public string Prenom { get; set; }
		public string Phone { get; set; }
		public string EtatLivraison { get; set; }    //0-->EM , //1--->Chez le Planteur
		public string Usinier { get; set; }
		public string User { get; set; }
	}
}
