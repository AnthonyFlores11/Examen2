using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Entidades
{
    public class Ingredientes
    {
        private string _nombreIngre;
        private string _descripcionIngre;

        public string NombreIngre { get => _nombreIngre; set => _nombreIngre = value; }
        public string DescripcionIngre { get => _descripcionIngre; set => _descripcionIngre = value; }

        public Ingredientes(string nombreIngre, string descripcionIngre)
        {
            _nombreIngre = nombreIngre;
            _descripcionIngre = descripcionIngre;
        }



    }
}
