using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2.Entidades;
using Microsoft.VisualBasic;

namespace Examen2.AccessoDatos.Operaciones
{
    public class OperacionesIngredientes : IOperaciones<Ingredientes>
    {
        private readonly string ConnectionString = "Data Source=.;Initial Catalog=Examen2;Integrated Security=True";
        Conexion cnn = new Conexion();
        public Ingredientes Buscar(string entidad)
        {
            string Sqlstring;

            try
            {
                if (entidad.Length == 1 || entidad.Length == 2)
                {

                    Sqlstring = string.Format("Select * from Ingredientes Where IdMenu = {0};", entidad);
                }
                else
                {


                    Sqlstring = string.Format("Select * from Ingredientes Where Nombre = {0};", entidad);

                }


                Ingredientes ingre;

                ingre = cnn.QueryUsingBuscar(Sqlstring);

                if (ingre != null)
                {

                    return ingre;

                }
            }
            catch (Exception ex)

            {

                Interaction.MsgBox("AccesoDatos.buscar" + ex.Message, 0, "Advertencia");

                return null;
            }

            return null;
        }

        public SqlDataAdapter buscarTodos()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(ConnectionString);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from  [dbo].[Ingredientes]", cnn);

                if (da != null)
                {

                    return da;

                }
                else
                {

                    Interaction.MsgBox("Error en la conexion con la Base de Datos", 0, "Advertencia");


                }
            }
            catch (Exception ex)
            {

                Interaction.MsgBox("AccesoDatos.buscarTodos" + ex.Message, 0, "Advertencia");


            }


            return null;
        }

       
        public bool Elminiar(Ingredientes entidad)
        {
            try
            {

                string Sqlstring = string.Format("delete  from Ingredientes where Nombre={0}", entidad.NombreIngre);

                if (cnn.nonQueryUsing(Sqlstring))
                {

                    return true;

                }
                else
                {

                    return false;
                }

            }
            catch (Exception ex)
            {

                Interaction.MsgBox("AccesoDatos.eliminar" + ex.Message, 0, "Advertencia");
                return false;

            }
        }

        public bool Insertar(Ingredientes entidad)
        {


            try
            {

                string Sqlstring2 = string.Format("INSERT INTO[dbo].[Ingredientes]([Nombre],[Descripcion] VALUES ('{0}','{1}'"
                    , entidad.NombreIngre, entidad.DescripcionIngre);
                cnn.nonQueryUsing(Sqlstring2);


            }
            catch (Exception ex)
            {

                Interaction.MsgBox("AccesoDatos.insertar" + ex.Message, 0, "Advertencia");
                return false;

            }

            return true;
        }

        public void Modificar(Ingredientes entidad)
        {
            throw new NotImplementedException();
        }
    }
}
