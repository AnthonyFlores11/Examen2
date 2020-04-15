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
using System.Data;

namespace Examen2.Logica
{

    public class Operaciones
    {
        OperacionesIngredientes op = new OperacionesIngredientes();
        OperacionesMenu opM = new OperacionesMenu();
        Conexion con = new Conexion();

        #region Operaciones Menu

        #endregion

        public Boolean InsertaMenu(Menu menu)
        {
            try
            {

                if (opM.Insertar(menu))
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

        public Boolean EliminarMenu(Menu m)
        {
            try
            {

                if (opM.Elminiar(m))
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

        public Boolean Actualizar(Menu m)
        {
            try
            {

                if (opM.Modificar(m))
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
        public DataTable Cargardatos()
        {

            try
            {
                DataTable res = op.buscarTodos();
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

        public DataTable CargardatosM()
        {

            try
            {
                DataTable res = opM.buscarTodos();
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
