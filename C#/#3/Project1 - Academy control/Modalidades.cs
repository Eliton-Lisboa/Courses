using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Academia
{
	public class Modalidades
	{

		SqlCommand comandoSql = new SqlCommand();
		StringBuider sql = new StringBuider();
		DataTable dadosTabela = new DataTable();

		public void Salvar(string nome, decimal mensalidade, int idProfessor)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("INSERT INTO Modalidade (NOME_MODALIDADE, MENSALIDADE, ID_PROFESSOR)");
					sql.Append("VALUES (@nome, @mensalidade, @idProfessor)");

					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
					comandoSql.Parameters.Add(new SqlParameter("@mensalidade", mensalidade));
					comandoSql.Parameters.Add(new SqlParameter("@idProfessor", idProfessor));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Ocorreu um erro no método Salvar. Caso o problema persista, entre em contato com o Administrador do sistema.");
			}
		}

		public void Alterar(int idModalidade, string nome, decimal mensalidade, int idProfessor)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("UPDATE Modalidade");
					sql.Append(" SET NOME_MODALIDADE = @nome, MENSALIDADE = @mensalidade, ID_PROFESSOR = @idprofessor");
					sql.Append(" WHERE (ID_MODALIDADE = @idModalidade)");

					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
					comandoSql.Parameters.Add(new SqlParameter("@mensalidade", mensalidade));
					comandoSql.Parameters.Add(new SqlParameter("@idProfessor", idProfessor));
					comandoSql.Parameters.Add(new SqlParameter("@idModalidade", idModalidade));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Ocorreu um erro no método Alterar. Caso o problema persista, entre em contato com o Administrador do sistema.");
			}
		}

		//Método responsável por listar todas as modalidades em order decrecente.
		public DataTable Listar()
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT Modalidade.ID_MODALIDADE, Modalidade.NOME_MODALIDADE, Modalidade.MENSALIDADE,");
					sql.Append(" Modalidade.ID_PROFESSOR, Professor.NOME_PROFESSOR");
					sql.Append(" FROM (Modalidade INNER JOIN Professor ON Modalidade.ID_PROFESSOR = Professor.ID_PROFESSOR)");
					sql.Append(" ORDER BY Modalidade.ID_MODALIDADE DESC");
					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{
				throw new Exception ("Ocorreu um erro no método Listar. Caso o problema persista, entre em contatdo com o Administrador do sistema.");
			}
		}
	
		//Método para excluir os registros do formulário medalidade.
		public void Excluir(int idModalidade)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("DELETE FROM Modalidade");
					sql.Append(" WHERE (ID_MODALIDADE = @idModalidade)");

					comandoSql.Parameters.Add(new SqlParameter("@idModalidade", idModalidade));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método Excluir. Caso o problema persista, entre em contato com o Administrador do sistema.");
			}
		}

		public DataTable PesquisarModalidadeNome(string nome)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT Modalidade.*, Professor.NOME_PROFESSOR");
					sql.Append(" FROM(Modalidade INNER JOIN Professor ON Modalidade.ID_PROFESSOR = Professor.ID_PROFESSOR)");
					sql.Append(" WHERE Modalidade.NOME_MODALIDADE LIKE'%'+@nome+'%'");
					sql.Append(" ORDER BY Modalidade.ID_MODALIDADE DESC");

					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método PesquisarModalidadeNome. Caso o problema persista, entre em contato com o Administrador do sistema.");
			}
		}

		public DataTable PesquisarModalidadeProfessor(string nome)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT Modalidade.*, Professor.NOME_PROFESSOR");
					sql.Append(" FROM(Modalidade INNER JOIN Professor ON Modalidade.ID_PROFESSOR = Professor.ID_PROFESSOR)");
					sql.Append(" WHERE Professor.NOME_PROFESSOR LIKE'%'+@nome+'%'");
					sql.Append(" ORDER BY Modalidade.ID_MODALIDADE DESC");

					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método PesquisarModalidadeProfessor. Caso o problema persista, entre em contato com o Administrador do sistema.");
			}
		}
	}
}