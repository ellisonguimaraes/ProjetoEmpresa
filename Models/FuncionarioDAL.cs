using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.Models
{
    public class FuncionarioDAL : IFuncionarioDAL
    {

        string connectionString;

        public FuncionarioDAL()
        {
            var myJsonString = File.ReadAllText("./appsettings.json");

            var myJObject = JObject.Parse(myJsonString);

            connectionString = myJObject.SelectToken("$.ConnectionStrings.EmpresaDB").Value<string>();
        }


        public void AddFuncionario(Funcionario funcionario)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "CreateFuncionario";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Sobrenome", funcionario.Sobrenome);
                cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                cmd.Parameters.AddWithValue("@DataNasc", funcionario.DataNasc);
                cmd.Parameters.AddWithValue("@Endereco", funcionario.Endereco);
                cmd.Parameters.AddWithValue("@Cidade", funcionario.Cidade);
                cmd.Parameters.AddWithValue("@CEP", funcionario.CEP);
                cmd.Parameters.AddWithValue("@Pais", funcionario.Pais);
                cmd.Parameters.AddWithValue("@Fone", funcionario.Fone);
                cmd.Parameters.AddWithValue("@Salario", funcionario.Salario);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteFuncionario(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "DeleteFuncionario";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodFun", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<Funcionario> GetAllFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllFuncionarios", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Funcionario funcionario = new Funcionario();

                    funcionario.CodFun = Convert.ToInt32(rdr["CodFun"]);
                    funcionario.Sobrenome = rdr["Sobrenome"].ToString();
                    funcionario.Nome = rdr["Nome"].ToString();
                    funcionario.Cargo = rdr["Cargo"].ToString();
                    funcionario.DataNasc = Convert.ToDateTime(rdr["DataNasc"].ToString());
                    funcionario.Endereco = rdr["Endereco"].ToString();
                    funcionario.Cidade = rdr["Cidade"].ToString();
                    funcionario.CEP = rdr["CEP"].ToString();
                    funcionario.Pais = rdr["Pais"].ToString();
                    funcionario.Fone = rdr["Fone"].ToString();
                    funcionario.Salario = Convert.ToDecimal(rdr["Salario"].ToString());

                    funcionarios.Add(funcionario);
                }

                con.Close();
            }

            return funcionarios;
        }

        public Funcionario GetFuncionario(int? id)
        {
            Funcionario funcionario = new Funcionario();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "GetFuncionario";
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodFun", id);

                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    funcionario.CodFun = Convert.ToInt32(rdr["CodFun"]);
                    funcionario.Sobrenome = rdr["Sobrenome"].ToString();
                    funcionario.Nome = rdr["Nome"].ToString();
                    funcionario.Cargo = rdr["Cargo"].ToString();
                    funcionario.DataNasc = Convert.ToDateTime(rdr["DataNasc"].ToString());
                    funcionario.Endereco = rdr["Endereco"].ToString();
                    funcionario.Cidade = rdr["Cidade"].ToString();
                    funcionario.CEP = rdr["CEP"].ToString();
                    funcionario.Pais = rdr["Pais"].ToString();
                    funcionario.Fone = rdr["Fone"].ToString();
                    funcionario.Salario = Convert.ToDecimal(rdr["Salario"].ToString());
                }

                con.Close();
            }

            return funcionario;
        }

        public void UpdateFuncionario(Funcionario funcionario)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "UpdateFuncionario";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodFun", funcionario.CodFun);
                cmd.Parameters.AddWithValue("@Sobrenome", funcionario.Sobrenome);
                cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                cmd.Parameters.AddWithValue("@DataNasc", funcionario.DataNasc);
                cmd.Parameters.AddWithValue("@Endereco", funcionario.Endereco);
                cmd.Parameters.AddWithValue("@Cidade", funcionario.Cidade);
                cmd.Parameters.AddWithValue("@CEP", funcionario.CEP);
                cmd.Parameters.AddWithValue("@Pais", funcionario.Pais);
                cmd.Parameters.AddWithValue("@Fone", funcionario.Fone);
                cmd.Parameters.AddWithValue("@Salario", funcionario.Salario);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
    }
}
