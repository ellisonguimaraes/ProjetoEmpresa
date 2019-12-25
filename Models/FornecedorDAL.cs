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
    public class FornecedorDAL : IFornecedorDAL
    {
        string connectionString;

        public FornecedorDAL()
        {
            var myJsonString = File.ReadAllText("./appsettings.json");

            var myJObject = JObject.Parse(myJsonString);

            connectionString = myJObject.SelectToken("$.ConnectionStrings.EmpresaDB").Value<string>();
        }

        public void AddFornecedor(Fornecedor fornecedor)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "CreateFornecedor";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Empresa", fornecedor.Empresa);
                cmd.Parameters.AddWithValue("@Contato", fornecedor.Contato);
                cmd.Parameters.AddWithValue("@Cargo", fornecedor.Cargo);
                cmd.Parameters.AddWithValue("@Endereco", fornecedor.Endereco);
                cmd.Parameters.AddWithValue("@Cidade", fornecedor.Cidade);
                cmd.Parameters.AddWithValue("@Cep", fornecedor.Cep);
                cmd.Parameters.AddWithValue("@Pais", fornecedor.Pais);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteFornecedor(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "DeleteFornecedor";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodFor", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<Fornecedor> GetAllFornecedores()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllFornecedores", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Fornecedor fornecedor = new Fornecedor();

                    fornecedor.CodFor = Convert.ToInt32(rdr["CodFor"]);
                    fornecedor.Empresa = rdr["Empresa"].ToString();
                    fornecedor.Contato = rdr["Contato"].ToString();
                    fornecedor.Cargo = rdr["Cargo"].ToString();
                    fornecedor.Endereco = rdr["Endereco"].ToString();
                    fornecedor.Cidade = rdr["Cidade"].ToString();
                    fornecedor.Cep = rdr["Cep"].ToString();
                    fornecedor.Pais = rdr["Pais"].ToString();

                    fornecedores.Add(fornecedor);
                }

                con.Close();
            }

            return fornecedores;
        }

        public Fornecedor GetFornecedor(int? id)
        {
            Fornecedor fornecedor = new Fornecedor();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "GetFornecedor";
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodFor", id);

                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    fornecedor.CodFor = Convert.ToInt32(rdr["CodFor"]);
                    fornecedor.Empresa = rdr["Empresa"].ToString();
                    fornecedor.Contato = rdr["Contato"].ToString();
                    fornecedor.Cargo = rdr["Cargo"].ToString();
                    fornecedor.Endereco = rdr["Endereco"].ToString();
                    fornecedor.Cidade = rdr["Cidade"].ToString();
                    fornecedor.Cep = rdr["Cep"].ToString();
                    fornecedor.Pais = rdr["Pais"].ToString();
                }

                con.Close();
            }

            return fornecedor;
        }

        public void UpdateFornecedor(Fornecedor fornecedor)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "UpdateFornecedor";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodFor", fornecedor.CodFor);
                cmd.Parameters.AddWithValue("@Empresa", fornecedor.Empresa);
                cmd.Parameters.AddWithValue("@Contato", fornecedor.Contato);
                cmd.Parameters.AddWithValue("@Cargo", fornecedor.Cargo);
                cmd.Parameters.AddWithValue("@Endereco", fornecedor.Endereco);
                cmd.Parameters.AddWithValue("@Cidade", fornecedor.Cidade);
                cmd.Parameters.AddWithValue("@Cep", fornecedor.Cep);
                cmd.Parameters.AddWithValue("@Pais", fornecedor.Pais);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
    }
}
