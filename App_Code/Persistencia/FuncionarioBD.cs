using WebSiteExemplo;
using SITE; //para acesso a classe Mapped
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSiteExemplo.Classes; //para acesso a classe Funcionario
using System.Data; //para uso de DataSet

namespace WebSiteExemplo.Persistencia
{
    /// <summary>
    /// Descrição resumida de FuncionarioBD
    /// </summary>
    public class FuncionarioBD
    {
        //MÉTODOS
        //INSERT
        public bool Insert(Funcionario funcionario)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_funcionario(fun_nome, fun_salario, fun_cracha) VALUES (?nome, ?salario, ?cracha)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", funcionario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?salario", funcionario.Salario));
            objCommand.Parameters.Add(Mapped.Parameter("?cracha", funcionario.Cracha));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        //SELECTALL
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT fun_codigo AS Código, fun_nome AS Nome, fun_salario AS Salário, fun_cracha AS Crachá FROM tbl_funcionario", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

        //SELECT
        public Funcionario Select(int id)
        {
            Funcionario obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_funcionario WHERE fun_codigo = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Funcionario();
                obj.Codigo = Convert.ToInt32(objDataReader["fun_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["fun_nome"]);
                obj.Salario = Convert.ToDouble(objDataReader["fun_salario"]);
                obj.Cracha = Convert.ToString(objDataReader["fun_cracha"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }

        //UPDATE
        public bool Update(Funcionario funcionario)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_funcionario SET fun_nome=?nome, fun_salario=?salario, fun_cracha=?cracha WHERE fun_codigo=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", funcionario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?salario", funcionario.Salario));
            objCommand.Parameters.Add(Mapped.Parameter("?cracha", funcionario.Cracha));
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", funcionario.Codigo));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        //DELETE
        public bool Delete(int id)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM tbl_funcionario WHERE fun_codigo=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        //CONSTRUTOR
        public FuncionarioBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}