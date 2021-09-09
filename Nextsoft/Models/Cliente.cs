using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nextsoft.Models
{
	public class Cliente
	{
        public int Id { get; set; }
        [Display(Name = "nº CPF")]
        public string CPF { get; set; }
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        //public virtual List<Endereco> Enderecos { get; set; }
    }
}
