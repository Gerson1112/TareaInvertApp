using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public class categoria
    {
         
        public string Nombre { get; set; }

        public List<categoria> categoriaseleccionadas { get; set; } = new List<categoria>();

        public categoria(string nombrecategoria)
        {
            this.Nombre = nombrecategoria;
        }
    }
}
