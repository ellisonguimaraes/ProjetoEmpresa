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
    public class ClienteDAL : IClienteDAL
    {
        string connectionString;

        public ClienteDAL()
        {
            var myJsonString = File.ReadAllText("./appsettings.json");

            var myJObject = JObject.Parse(myJsonString);

            connectionString = myJObject.SelectToken("$.ConnectionStrings.EmpresaDB").Value<string>();
        }

        public void AddCliente(Cliente cliente)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "CreateCliente";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodCli", cliente.CodCli);
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Contato", cliente.Contato);
                cmd.Parameters.AddWithValue("@Cargo", cliente.Cargo);
                cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@Regiao", cliente.Regiao);
                cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
                cmd.Parameters.AddWithValue("@Pais", cliente.Pais);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Fax", cliente.Fax);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteCliente(string id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "DeleteCliente";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodCli", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllClientes", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.CodCli = rdr["CodCli"].ToString();
                    cliente.Nome = rdr["Nome"].ToString();
                    cliente.Contato = rdr["Contato"].ToString();
                    cliente.Cargo = rdr["Cargo"].ToString();
                    cliente.Endereco = rdr["Endereco"].ToString();
                    cliente.Cidade = rdr["Cidade"].ToString();
                    cliente.Regiao = rdr["Regiao"].ToString();
                    cliente.CEP = rdr["CEP"].ToString();
                    cliente.Pais = rdr["Pais"].ToString();
                    cliente.Telefone = rdr["Telefone"].ToString();
                    cliente.Fax = rdr["Fax"].ToString();

                    clientes.Add(cliente);
                }

                con.Close();
            }

            return clientes;
        }

        public Cliente GetCliente(string id)
        {
            Cliente cliente = new Cliente();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "GetCliente";
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodCli", id);

                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cliente.CodCli = rdr["CodCli"].ToString();
                    cliente.Nome = rdr["Nome"].ToString();
                    cliente.Contato = rdr["Contato"].ToString();
                    cliente.Cargo = rdr["Cargo"].ToString();
                    cliente.Endereco = rdr["Endereco"].ToString();
                    cliente.Cidade = rdr["Cidade"].ToString();
                    cliente.Regiao = rdr["Regiao"].ToString();
                    cliente.CEP = rdr["CEP"].ToString();
                    cliente.Pais = rdr["Pais"].ToString();
                    cliente.Telefone = rdr["Telefone"].ToString();
                    cliente.Fax = rdr["Fax"].ToString();
                }

                con.Close();
            }

            return cliente;
        }

        public void UpdateCliente(Cliente cliente)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "UpdateCliente";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodCli", cliente.CodCli);
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Contato", cliente.Contato);
                cmd.Parameters.AddWithValue("@Cargo", cliente.Cargo);
                cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@Regiao", cliente.Regiao);
                cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
                cmd.Parameters.AddWithValue("@Pais", cliente.Pais);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Fax", cliente.Fax);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
    }
}
