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
    public class PedidoDAL : IPedidoDAL
    {

        string connectionString;

        public PedidoDAL()
        {
            var myJsonString = File.ReadAllText("./appsettings.json");

            var myJObject = JObject.Parse(myJsonString);

            connectionString = myJObject.SelectToken("$.ConnectionStrings.EmpresaDB").Value<string>();
        }


        public void AddPedido(Pedido pedido)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "CreatePedido";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NumPed", pedido.NumPed);
                cmd.Parameters.AddWithValue("@CodCli", pedido.CodCli);
                cmd.Parameters.AddWithValue("@CodFun", pedido.CodFun);
                cmd.Parameters.AddWithValue("@DataPed", pedido.DataPed);
                cmd.Parameters.AddWithValue("@DataEntrega", pedido.DataEntrega);
                cmd.Parameters.AddWithValue("@Frete", pedido.Frete);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeletePedido(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "DeletePedido";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NumPed", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<Pedido> GetAllPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllPedidos", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Pedido pedido = new Pedido();

                    pedido.NumPed = Convert.ToInt32(rdr["NumPed"]);
                    pedido.CodCli = rdr["CodCli"].ToString();
                    pedido.CodFun = Convert.ToInt32(rdr["CodFun"]);
                    pedido.DataPed = Convert.ToDateTime(rdr["DataPed"]);
                    pedido.DataEntrega = Convert.ToDateTime(rdr["DataEntrega"]);
                    pedido.Frete = Convert.ToDouble(rdr["Frete"]);

                    pedidos.Add(pedido);
                }

                con.Close();
            }

            return pedidos;
        }

        public Pedido GetPedido(int? id)
        {
            Pedido pedido = new Pedido();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "GetPedido";
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NumPed", id);

                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    pedido.NumPed = Convert.ToInt32(rdr["NumPed"]);
                    pedido.CodCli = rdr["CodCli"].ToString();
                    pedido.CodFun = Convert.ToInt32(rdr["CodFun"]);
                    pedido.DataPed = Convert.ToDateTime(rdr["DataPed"]);
                    pedido.DataEntrega = Convert.ToDateTime(rdr["DataEntrega"]);
                    pedido.Frete = Convert.ToDouble(rdr["Frete"]);
                }

                con.Close();
            }

            return pedido;
        }

        public void UpdatePedido(Pedido pedido)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comando = "UpdatePedido";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NumPed", pedido.NumPed);
                cmd.Parameters.AddWithValue("@CodCli", pedido.CodCli);
                cmd.Parameters.AddWithValue("@CodFun", pedido.CodFun);
                cmd.Parameters.AddWithValue("@DataPed", pedido.DataPed);
                cmd.Parameters.AddWithValue("@DataEntrega", pedido.DataEntrega);
                cmd.Parameters.AddWithValue("@Frete", pedido.Frete);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
    }
}
