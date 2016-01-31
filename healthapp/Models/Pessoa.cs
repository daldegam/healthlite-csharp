using System;
using System.Collections.Generic;

namespace healthapp
{
	public class Pessoa
	{
		public int PessoaId { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public string Nome { get; set; }
		public System.DateTime Nascimento { get; set; }
		public string Telefone { get; set; }
		public short Peso { get; set; }
		public short Altura { get; set; }
		public bool Sexo { get; set; }
		public string ApiToken { get; set; }
		public byte[] Imagem { get; set; }
		public string Alergia { get; set; }
		public string Intolerancia { get; set; }
		public string Doencas { get; set; }

		public virtual ICollection<Remedio> Remedios { get; set; }
	}
}

