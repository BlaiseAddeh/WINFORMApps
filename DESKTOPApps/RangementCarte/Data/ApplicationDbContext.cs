using RangementCarte.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangementCarte.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(): base("name=CardRangement")
		{
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Carte> Cartes { get; set; }

	}
}
