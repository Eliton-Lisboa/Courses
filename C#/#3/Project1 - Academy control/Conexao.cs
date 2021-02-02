using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
	public class Conexao
	{
		//Atributo que é a String de Conexão.
		private static string conexao = "Conection string";

		//Método acessor de leitura da String Conexão.
		public static string stringConexao
		{
			get { return conexao; }
		}

		public string Connection
		{
			get { return Connection; }
			set { Connection = value; }
		}
	}
}