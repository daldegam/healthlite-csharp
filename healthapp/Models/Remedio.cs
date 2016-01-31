using System;

namespace healthapp
{
	public class Remedio
	{
		public int RemedioId { get; set; }
		public int PessoaId { get; set; }
		public string Nome { get; set; }
		public byte IntervaloHoras { get; set; }
		public Nullable<System.DateTime> DataUltimaDoseAdministrada { get; set; }
	}
}

