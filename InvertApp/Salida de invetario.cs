using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public class Salida_de_invetario
    {
        public void Listasalida()
        {
            for (int i = 0; i < repositorio.Instancia.Listarproductos.Count; i++)
            {
                producto prodcutointerada = repositorio.Instancia.Listarproductos[i];
                Console.WriteLine((i + 1 + "- " + " Nombre: " + prodcutointerada.Nombre + " Cantidad: " + prodcutointerada.Cantidad));
            }
            
        }
        public void salidadeinventario()
        {
            Listasalida();
            Console.WriteLine("Selecciona un producto: ");
            int producto = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad que desea sacar del inventario: ");
            int salida = int.Parse(Console.ReadLine());

            if (salida <= repositorio.Instancia.Listarproductos[producto - 1].Cantidad)
            {

                int inventario = repositorio.Instancia.Listarproductos[producto - 1].Cantidad - salida;
                repositorio.Instancia.Listarproductos[producto - 1].Cantidad = inventario;

                Console.WriteLine("Se ha salido la cantidad introducida del producto");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("La cantidad ingresada es mayor a la existente.");
                Console.ReadKey();
            }
        }
    }
}
