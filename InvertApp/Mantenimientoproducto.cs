using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class Mantenimientoproducto
    {
        Mantenimientodecategorias Categori = new Mantenimientodecategorias();

        public void agregarproducto()
        {

            Console.WriteLine("Escriba el nombre del producto: ");
            string nombreproducto = Console.ReadLine();

            Console.WriteLine("introduce el precio del producto: ");
            double precioproducto = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la cantidad del producto: ");
            int cantidad = int.Parse(Console.ReadLine());


            if (repositorio.Instancia.Litasdecategorias.Count > 0)
            {
                Categori.listarcategorias();

                Console.WriteLine("Selecciona la categoria:  ");
                int catego = Convert.ToInt32(Console.ReadLine());

                string categorias = repositorio.Instancia.Litasdecategorias[catego - 1].Nombre;

                producto nuevoproducto = new producto(nombreproducto, precioproducto, cantidad, categorias);

                repositorio.Instancia.Listarproductos.Add(nuevoproducto);

                Console.WriteLine("La categoria se ha agregado correctamente");
                Console.ReadKey();

            }
            else
            {

                Console.WriteLine("no hay categorias registradas...");
                Console.ReadKey();

            }
        }

        public void editproducto()
        {

            int editproducto;
            listarproducto();
            Console.WriteLine("Selecione el producto a editar: ");
            editproducto = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el nuevo producto: ");
            string nuevoproducto = Console.ReadLine();

            Console.WriteLine("Introduce el nuevo precio: ");
            double nuevoprecio = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la nueva cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());


            if (repositorio.Instancia.Litasdecategorias.Count > 0)
            {
                Categori.listarcategorias();
                Console.WriteLine("Seleccione la categoria: ");
                int produ = int.Parse(Console.ReadLine());

                string categorias = repositorio.Instancia.Litasdecategorias[produ - 1].Nombre;
                repositorio.Instancia.Listarproductos[editproducto - 1].Nombre = nuevoproducto;
                repositorio.Instancia.Listarproductos[editproducto - 1].Precio = nuevoprecio;
                repositorio.Instancia.Listarproductos[editproducto - 1].Cantidad = cantidad;
                repositorio.Instancia.Listarproductos[editproducto - 1].Categoria = categorias;

                Console.WriteLine("El producto ha logrado editarse correctamente....");
                Console.ReadKey();

            }
        }

        public void deleproducto()
        {
            listarproducto();
            Console.WriteLine("Selecione el nombre del producto que desea eliminar: ");
            int elimproducto = int.Parse(Console.ReadLine());

            Console.WriteLine("Si estas seguro que desea eliminar esa categoria. S/N?...");
            string opcion = Console.ReadLine();

            if (opcion == "S" || opcion == "s")
            {
                repositorio.Instancia.Listarproductos.RemoveAt(elimproducto - 1);

                Console.WriteLine("La categoria se ha eliminado correctamente....");
                Console.ReadKey();

            }
        }

        public void listarproducto()
        {
            for (int i = 0; i < repositorio.Instancia.Listarproductos.Count; i++)
            {
                producto prodcutointerada = repositorio.Instancia.Listarproductos[i];
                Console.WriteLine((i + 1 + "- " + " Nombre: " + prodcutointerada.Nombre + " Precio, RD$: " + prodcutointerada.Precio + " Categoria: " + prodcutointerada.Categoria + " Cantidad: " + prodcutointerada.Cantidad));
            }
        }

           
    }
}
