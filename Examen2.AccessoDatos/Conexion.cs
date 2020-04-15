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



        public Boolean Query(string query)
        {
            SqlDataReader resultado = null;
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand(query, cnn);
                    resultado = cmd.ExecuteReader();
                    if (resultado.HasRows)
                    {
                        cmd.Dispose();
                        return false;
                    }
                    else
                    {
                        cmd.Dispose();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("El error es :", ex.Message);
                return true;
            }

        }
        public Boolean NonQuery(string sqlQuery)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand(sqlQuery, cnn);
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        cmd.Dispose();
                        return true;
                    }
                    else
                    {
                        cmd.Dispose();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("El error es :", ex.Message);
                return false;
            }
        }

        public DataTable ConexionADO(string query)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, ConnectionString);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
                return null;
            }
        }
    }
    }


