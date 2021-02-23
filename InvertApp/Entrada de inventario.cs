using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class Entrada_de_inventario
    {

        public void Listaentrada()
        {
            for (int i = 0; i < repositorio.Instancia.Listarproductos.Count; i++)
            {
                producto prodcutointerada = repositorio.Instancia.Listarproductos[i];
                Console.WriteLine((i + 1 + "- " + " Nombre: " + prodcutointerada.Nombre + " Cantidad: " + prodcutointerada.Cantidad));
            }

        }
        public void entradaeinventario()
        {
            Listaentrada();
            Console.WriteLine("Selecciona un producto: ");
            int producto = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad que desea entrar al inventario: ");
            int entrada = int.Parse(Console.ReadLine());

            int inventario = repositorio.Instancia.Listarproductos[producto - 1].Cantidad + entrada;
            repositorio.Instancia.Listarproductos[producto - 1].Cantidad = inventario;

            Console.WriteLine("Se ha entrado la cantidad introducida del producto");
            Console.ReadKey();

        }
    }
}
