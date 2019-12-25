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
    public class DetalhesPedDAL : IDetalhesPedDAL
    {
        string connectionString;

        public DetalhesPedDAL()
        {
            var myJsonString = File.ReadAllText("./appsettings.json");

            var myJObject = JObject.Parse(myJsonString);

            connectionString = myJObject.SelectToken("$.ConnectionStrings.EmpresaDB").Value<string>();
        }

        public void AddDetalhesPed(DetalhesPed detalhesped)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "CreateDetalhesPed";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NumPed", detalhesped.NumPed);
                cmd.Parameters.AddWithValue("@CodProd", detalhesped.CodProd);
                cmd.Parameters.AddWithValue("@Preco", detalhesped.Preco);
                cmd.Parameters.AddWithValue("@Qtde", detalhesped.Qtde);
                cmd.Parameters.AddWithValue("@Desconto", detalhesped.Desconto);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteDetalhesPed(int? NumPed, int? CodProd)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "DeleteDetalhesPed";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NumPed", NumPed);
                cmd.Parameters.AddWithValue("@CodProd", CodProd);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<DetalhesPed> GetAllDetalhesPed()
        {
            List<DetalhesPed> detalhesped = new List<DetalhesPed>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllDetalhesPed", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    DetalhesPed dp = new DetalhesPed();

                    dp.NumPed = Convert.ToInt32(rdr["NumPed"]);
                    dp.CodProd = Convert.ToInt32(rdr["CodProd"]);
                    dp.Preco = Convert.ToDouble(rdr["Preco"]);
                    dp.Qtde = Convert.ToInt32(rdr["Qtde"]);
                    dp.Desconto = Convert.ToDouble(rdr["Desconto"]);

                    detalhesped.Add(dp);
                }

                con.Close();
            }

            return detalhesped;
        }

        public DetalhesPed GetDetalhesPed(int? NumPed, int? CodProd)
        {
            DetalhesPed dp = new DetalhesPed();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "GetDetalhesPed";
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NumPed", NumPed);
                cmd.Parameters.AddWithValue("@CodProd", CodProd);

                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dp.NumPed = Convert.ToInt32(rdr["NumPed"]);
                    dp.CodProd = Convert.ToInt32(rdr["CodProd"]);
                    dp.Preco = Convert.ToDouble(rdr["Preco"]);
                    dp.Qtde = Convert.ToInt32(rdr["Qtde"]);
                    dp.Desconto = Convert.ToDouble(rdr["Desconto"]);
                }

                con.Close();
            }

            return dp;
        }


        public void UpdateDetalhesPed(DetalhesPed detalhesped)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "UpdateDetalhesPed";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NumPed", detalhesped.NumPed);
                cmd.Parameters.AddWithValue("@CodProd", detalhesped.CodProd);
                cmd.Parameters.AddWithValue("@Preco", detalhesped.Preco);
                cmd.Parameters.AddWithValue("@Qtde", detalhesped.Qtde);
                cmd.Parameters.AddWithValue("@Desconto", detalhesped.Desconto);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
    }
}
