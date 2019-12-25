using Microsoft.IdentityModel.Protocols;
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
    public class CategoriaDAL : ICategoriaDAL
    {

        string connectionString;

        public CategoriaDAL()
        {
            var myJsonString = File.ReadAllText("./appsettings.json");

            var myJObject = JObject.Parse(myJsonString);

            connectionString = myJObject.SelectToken("$.ConnectionStrings.EmpresaDB").Value<string>();
        }

        public void AddCategoria(Categoria categoria)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "CreateCategoria";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Descr", categoria.Descr);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteCategoria(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "DeleteCategoria";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodCategoria", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<Categoria> GetAllCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllCategorias", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Categoria categoria = new Categoria();

                    categoria.CodCategoria = Convert.ToInt32(rdr["CodCategoria"]);
                    categoria.Descr = rdr["Descr"].ToString();

                    categorias.Add(categoria);
                }

                con.Close();
            }

            return categorias;
        }

        public Categoria GetCategoria(int? id)
        {
            Categoria categoria = new Categoria();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "GetCategoria";
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodCategoria", id);

                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    categoria.CodCategoria = Convert.ToInt32(rdr["CodCategoria"]);
                    categoria.Descr = rdr["Descr"].ToString();
                }

                con.Close();
            }

            return categoria;
        }

        public void UpdateCategoria(Categoria categoria)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "UpdateCategoria";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodCategoria", categoria.CodCategoria);
                cmd.Parameters.AddWithValue("@Descr", categoria.Descr);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

    }
}
