using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class Mantenimientodecategorias
    {
        
        public void agregarcategoria()
        {

            Console.WriteLine("Escriba el nombre de la categoria que quiere agregar: ");
            string nombrecategoria = Console.ReadLine();

            categoria nuevacategoria = new categoria(nombrecategoria);

            repositorio.Instancia.Litasdecategorias.Add(nuevacategoria);

            Console.WriteLine("La categoria se ha agregado correctamente");
            Console.ReadKey();  
        }

        public void editcategoria()
        {

            int editcatego;
            listarcategorias();
            Console.WriteLine("Selecione el producto a editar: ");
            editcatego = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la nueva categoria: ");
            string nuevacategoria = Console.ReadLine();

            repositorio.Instancia.Litasdecategorias[editcatego - 1].Nombre = nuevacategoria;

            Console.WriteLine("La categoria ha logrado editarse....");
            Console.ReadKey();   
        }

        public void delecatego()
        {
            listarcategorias();
            Console.WriteLine("Selecione la categoria que desea eliminar: ");
            int elimcategoria = int.Parse(Console.ReadLine());

            Console.WriteLine("Si estas seguro que desea eliminar esa categoria. S/N?...");
            string opcion = Console.ReadLine();

            if (opcion == "S" || opcion == "s")
            {
                repositorio.Instancia.Litasdecategorias.RemoveAt(elimcategoria - 1);

                Console.WriteLine("La categoria se ha eliminado correctamente....");
                Console.ReadKey();
                
            }
        }

        public void listarcategorias()
        {
            for (int i = 0; i < repositorio.Instancia.Litasdecategorias.Count; i++)
            {
                categoria categoriainterada = repositorio.Instancia.Litasdecategorias[i];
                Console.WriteLine((i + 1 + " - " + categoriainterada.Nombre));
            }  
        }
    }
}
