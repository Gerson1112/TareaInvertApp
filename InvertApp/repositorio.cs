using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public class repositorio
    {

        public static repositorio Instancia { get; } = new repositorio();
        public List<categoria> Litasdecategorias { get; set; } = new List<categoria>();
        public List<producto> Listarproductos { get; set; } = new List<producto>();

        private repositorio()
        {


        }
        
    }
}
