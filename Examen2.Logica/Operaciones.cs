using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2.Entidades;
using Examen2.AccessoDatos.Operaciones;
using Examen2.AccessoDatos;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace Examen2.Logica
{

    public class Operaciones
    {
        OperacionesIngredientes op = new OperacionesIngredientes();
        Conexion con = new Conexion();

        #region Operaciones Menu

        #endregion

        #region Operaciones Ingredientes

        #endregion

        public Boolean InsertarIngre(Ingredientes ingre)
        {
            try
            {

                if (op.Insertar(ingre))
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

                Console.WriteLine("Error en la conexion con la Base de Datos" + ex.Message, 0, "Advertencia");
                return false;
            }
        }

        public Boolean Eliminar(Ingredientes ingre)
        {
            try
            {
                if (op.Elminiar(ingre))
                {

                    return true;

                }
                else
                {
                    Console.WriteLine("Fallo al eliminar", 0, "Advertencia");
                    return false;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("LogicaNegocio.eliminar" + ex.Message, 0, "Advertencia");
                return false;
            }
        }
        public SqlDataAdapter Cargardatos()
        {

            try
            {
                SqlDataAdapter res = op.buscarTodos();
                if (res != null)
                {

                    return res;

                }
                else
                {

                    Console.WriteLine("Error en la conexion con la Base de Datos", 0, "Advertencia");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("LogicaNegocio.traerDatos" + ex.Message, 0, "Advertencia");

            }

            return null;
        }
    }
}
