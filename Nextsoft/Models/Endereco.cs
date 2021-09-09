using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nextsoft.Models
{
	public class Endereco
	{
		public int Id { get; set; }
		[Display(Name = "Logradouro")]
		public string Logradouro { get; set; }
		[Display(Name = "Número")]
		public int Numero { get; set; }
		[Display(Name = "Complemento")]
		public string Complemento { get; set; }
		[Display(Name = "Bairro")]
		public string Bairro { get; set; }
		[Display(Name = "Cidade")]
		public string Cidade { get; set; }
		[Display(Name = "Tipo")]
		public string Tipo { get; set; }
		[Display(Name = "Estado")]
		public string Estado { get; set; }

		//public int ClienteId { get; set; }
	}
}
