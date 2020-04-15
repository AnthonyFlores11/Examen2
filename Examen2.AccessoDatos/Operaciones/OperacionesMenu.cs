using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2.Entidades;

namespace Examen2.AccessoDatos.Operaciones
{
    public class OperacionesMenu : IOperaciones<Menu>
    {
        Conexion dat = new Conexion();
        public Menu Buscar(string entidad)
        {
            throw new NotImplementedException();
        }


        public bool Elminiar(Menu entidad)
        {
            string query = string.Format("DELETE Menu WHERE Nombre = {0};", entidad.Nombre);

            return dat.NonQuery(query);
        }

        public bool Insertar(Menu item)
        {
            string query = string.Format("INSERT INTO Menu (Nombre,Descripcion,Horario) " +
                "VALUES('{0}','{1}','{2}');",
                item.Nombre, item.Descripcion, item.Horario);

            return dat.NonQuery(query);
        }

        public bool Modificar(Menu item)
        {
            string query = string.Format("UPDATE Menu (Nombre,Descripcion,Horario) " +
                "VALUES('{0}','{1}','{2}');",
                item.Nombre, item.Descripcion, item.Horario);

            return dat.NonQuery(query);
        }

        public DataTable buscarTodos()
        {
           
                string query = string.Format("SELECT * FROM Menu;");

                return dat.ConexionADO(query);

            
        }
    }
}
