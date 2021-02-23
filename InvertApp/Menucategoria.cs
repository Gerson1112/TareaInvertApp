using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class Menucategoria : iMenu
    {

        private Mantenimientodecategorias mantenimiento { get; set; }
        

        public Menucategoria()
        {
            mantenimiento = new Mantenimientodecategorias();
        }

        public void imprimirmenu()
        {
            try
            {
                iMenu menu;
                Console.Clear();
                Console.WriteLine("---Menu Categoria--- \n1.Agregar categorias \n2.Editar Categoria \n3.Eliminar Categoria \n4.Listar categorias \n5.Volver atrás");
                int menu1 = int.Parse(Console.ReadLine());

                switch (menu1)
                {
                    case 1:
                        mantenimiento.agregarcategoria();
                        imprimirmenu();
                        break;
                    case 2:
                        mantenimiento.editcategoria();
                        imprimirmenu();
                        break;
                    case 3:
                        mantenimiento.delecatego();
                        imprimirmenu();
                        break;
                    case 4:
                        mantenimiento.listarcategorias();
                        Console.ReadKey();
                        imprimirmenu();
                        break;
                    case 5:
                        menu = new Menuprincipal();
                        menu.imprimirmenu();
                        break;
                    default:
                        Console.WriteLine("Ha introducido una opcin no valida, vuelva a introducir una opcion pero esta vez del 1 al 5....");
                        Console.ReadKey();
                        imprimirmenu();
                        break;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Ha introducido una opcin no valida, vuelva a introducir una opcion pero esta vez del 1 al 5....");
                Console.ReadKey();
                imprimirmenu();

            }
        }
    }
}

