using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nextsoft.Models;

namespace Nextsoft.Data
{
	public class NextsoftContext : DbContext
	{

		public NextsoftContext(DbContextOptions<NextsoftContext> options)
				: base(options)
		{
		}
		public DbSet<Nextsoft.Models.Cliente> Cliente { get; set; }

		public DbSet<Nextsoft.Models.Endereco> Endereco { get; set; }

		
	}
}
