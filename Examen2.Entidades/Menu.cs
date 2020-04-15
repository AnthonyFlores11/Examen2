using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Entidades
{
    [Serializable]
    public class Menu
    {
        private string nombre;
        private string descripcion;
        private string horario;
        private int id;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Horario { get => horario; set => horario = value; }
        public int Id { get => id; set => id = value; }

        public Menu()
        {

        }
        public Menu(string nombre, string descripcion, string horario, int id)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.horario = horario;
            this.id = id;
        }

        public byte[] Serialize()
        {
            BinaryFormatter bin = new BinaryFormatter();
            MemoryStream mem = new MemoryStream();
            bin.Serialize(mem, this);
            return mem.GetBuffer();
        }

        public Menu DeSerialize(byte[] TransmissionBuffer)
        {
            byte[] dataBuffer = TransmissionBuffer.ToArray();
            BinaryFormatter bin = new BinaryFormatter();
            MemoryStream mem = new MemoryStream();
            mem.Write(dataBuffer, 0, dataBuffer.Length);
            mem.Seek(0, 0);

            return (Menu)bin.Deserialize(mem);
        }

    }
}
