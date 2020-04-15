using System;
using System.Collections.Generic;
using System.Data;
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
        Conexion dat = new Conexion();

        public Ingredientes Buscar(string entidad)
        {
            throw new NotImplementedException();
        }

        public DataTable buscarTodos()
        {
            string query = string.Format("SELECT * FROM Ingredientes;");

            return dat.ConexionADO(query);
        }
       
        public bool Elminiar(Ingredientes entidad)
        {
            try
            {
                string query = string.Format("DELETE Ingredientes WHERE Nombre = {0};", entidad.NombreIngre);

                return dat.NonQuery(query);

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

                string query = string.Format("INSERT INTO[dbo].[Ingredientes](Nombre, Descripcion)" + " VALUES ('{0}','{1}');"
                    , entidad.NombreIngre, entidad.DescripcionIngre);

                return dat.NonQuery(query);

            }
            catch (Exception ex)
            {

                Interaction.MsgBox("AccesoDatos.insertar" + ex.Message, 0, "Advertencia");
                return false;

            }

        }

        public Boolean Modificar(Ingredientes entidad)
        {
            throw new NotImplementedException();
        }
    }
}
