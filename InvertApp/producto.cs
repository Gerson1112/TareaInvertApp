using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public class producto
    {

        public string Nombre { get; set; }

        public double Precio { get; set; }

        public string Categoria { get; set; }
        
        public int Cantidad { get; set; }

        public producto (string nombreproducto, double precio, int cantidad, string categorias)
        {
            this.Nombre = nombreproducto;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Categoria = categorias;

        }
    

    }
}
