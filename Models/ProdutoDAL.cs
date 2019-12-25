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
    public class ProdutoDAL : IProdutoDAL
    {

        string connectionString;

        public ProdutoDAL()
        {
            var myJsonString = File.ReadAllText("./appsettings.json");

            var myJObject = JObject.Parse(myJsonString);

            connectionString = myJObject.SelectToken("$.ConnectionStrings.EmpresaDB").Value<string>();
        }

        public void AddProduto(Produto produto)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "CreateProduto";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Descr", produto.Descr);
                cmd.Parameters.AddWithValue("@CodFor", produto.CodFor);
                cmd.Parameters.AddWithValue("@CodCategoria", produto.CodCategoria);
                cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                cmd.Parameters.AddWithValue("@Unidades", produto.Unidades);
                cmd.Parameters.AddWithValue("@Descontinuado", produto.Descontinuado);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteProduto(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "DeleteProduto";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodProd", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<Produto> GetAllProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllProdutos", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Produto produto = new Produto();

                    produto.CodProd = Convert.ToInt32(rdr["CodProd"]);
                    produto.Descr = rdr["Descr"].ToString();
                    produto.CodFor = Convert.ToInt32(rdr["CodFor"]);
                    produto.CodCategoria = Convert.ToInt32(rdr["CodCategoria"]);
                    produto.Preco = Convert.ToDouble(rdr["Preco"]);
                    produto.Unidades = Convert.ToInt32(rdr["Unidades"]);
                    produto.Descontinuado = Convert.ToInt32(rdr["Descontinuado"]);

                    produtos.Add(produto);
                }

                con.Close();
            }

            return produtos;
        }

        public Produto GetProduto(int? id)
        {
            Produto produto = new Produto();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "GetProduto";
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodProd", id);

                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    produto.CodProd = Convert.ToInt32(rdr["CodProd"]);
                    produto.Descr = rdr["Descr"].ToString();
                    produto.CodFor = Convert.ToInt32(rdr["CodFor"]);
                    produto.CodCategoria = Convert.ToInt32(rdr["CodCategoria"]);
                    produto.Preco = Convert.ToDouble(rdr["Preco"]);
                    produto.Unidades = Convert.ToInt32(rdr["Unidades"]);
                    produto.Descontinuado = Convert.ToInt32(rdr["Descontinuado"]);
                }

                con.Close();
            }

            return produto;
        }

        public void UpdateProduto(Produto produto)
        {   /*
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "UPDATE Produtos SET Descr = @Descr, CodFor = @CodFor, CodCategoria = @CodCategoria, Preco = @Preco, Unidades = @Unidades, Descontinuado = @Descontinuado WHERE CodProd = @CodProd";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@CodProd", produto.CodProd);
                cmd.Parameters.AddWithValue("@Descr", produto.Descr);
                cmd.Parameters.AddWithValue("@CodFor", produto.CodFor);
                cmd.Parameters.AddWithValue("@CodCategoria", produto.CodCategoria);
                cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                cmd.Parameters.AddWithValue("@Unidades", produto.Unidades);
                cmd.Parameters.AddWithValue("@Descontinuado", produto.Descontinuado);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }*/

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "UpdateProduto";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodProd", produto.CodProd);
                cmd.Parameters.AddWithValue("@Descr", produto.Descr);
                cmd.Parameters.AddWithValue("@CodFor", produto.CodFor);
                cmd.Parameters.AddWithValue("@CodCategoria", produto.CodCategoria);
                cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                cmd.Parameters.AddWithValue("@Unidades", produto.Unidades);
                cmd.Parameters.AddWithValue("@Descontinuado", produto.Descontinuado);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

    }
}
