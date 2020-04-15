using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2.Entidades;

namespace Examen2.AccessoDatos
{
    public class Conexion
    {
        private readonly string ConnectionString = "Data Source=.;Initial Catalog=Examen2;Integrated Security=True";

        

        public Boolean nonQueryUsing(string query)
        {


            SqlCommand cmd;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                try
                {
                    connection.Open();
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Conexion.nonQueryUsing Error: " + ex.Message, 0, "Advertencia");
                    return false;
                }
            }

            return true;

        }



        public SqlDataReader QueryUsing(string query)
        {


            SqlCommand cmd;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                try
                {
                    connection.Open();

                    cmd = new SqlCommand(query, connection);
                    SqlDataReader resultado = cmd.ExecuteReader();
                    cmd.Dispose();
                    if (resultado.HasRows)
                    {


                        return resultado;
                    }

                }
                catch (Exception ex)
                {

                    Interaction.MsgBox("Conexion.QueryUsing Error: " + ex.Message, 0, "Advertencia");

                }
            }
            return null;


        }

        public Ingredientes QueryUsingBuscar(string query)
        {


            SqlCommand cmd;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                try
                {
                    connection.Open();

                    cmd = new SqlCommand(query, connection);
                    SqlDataReader resultado = cmd.ExecuteReader();
                    cmd.Dispose();
                    if (resultado.Read())
                    {
                        return new Ingredientes(resultado.GetString(0).Trim(), resultado.GetString(1).Trim());

                    }

                }
                catch (Exception ex)
                {

                    Interaction.MsgBox("Conexion.QueryUsingBuscar -> Error: " + ex.Message, 0, "Advertencia");
                    return null;

                }
            }
            return null;


        }



        public List<Ingredientes> QueryUsingLista(string query)
        {

            List<Ingredientes> ingredientes = new List<Ingredientes>();
            SqlCommand cmd;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                try
                {
                    connection.Open();
                    cmd = new SqlCommand(query, connection);
                    SqlDataReader resultado = cmd.ExecuteReader();
                    cmd.Dispose();
                    if (resultado.HasRows)
                    {
                        while (resultado.Read())
                        {

                            ingredientes.Add(new Ingredientes(resultado.GetString(0).Trim(), resultado.GetString(1).Trim()));

                        }

                        return ingredientes;
                    }

                }
                catch (Exception ex)
                {

                    Interaction.MsgBox("Conexion.QueryUsingLista Error: " + ex.Message, 0, "Advertencia");

                }
            }
            return null;


        }
    }
}

