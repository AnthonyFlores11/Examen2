using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.AccessoDatos
{
    public interface IOperaciones <T>
    {
        Boolean Insertar(T entidad);
        Boolean Elminiar(T entidad);
        void Modificar(T entidad);
        T Buscar(string entidad);
        SqlDataAdapter buscarTodos();
       // List<T> BuscarTodos();


    }
}
