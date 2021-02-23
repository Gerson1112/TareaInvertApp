using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class Menuproducto : iMenu
    {
        private Mantenimientoproducto mantenimiento { get; set; } 
        public Menuproducto()
        {
            mantenimiento = new Mantenimientoproducto();     
        }

        public void imprimirmenu()
        {

            try { 
            
                iMenu menu;
                Console.Clear();
                Console.WriteLine("---Menu Producto--- \n1.Agregar Producto \n2.Editar Producto \n3.Eliminar Producto \n4.Listar Producto \n5.Volver atrás");
                int menu2 = int.Parse(Console.ReadLine());

                switch (menu2)
                { 
                    case 1:
                        mantenimiento.agregarproducto();
                        imprimirmenu();
                        break;
                    case 2:
                        mantenimiento.editproducto();
                        imprimirmenu();
                        break;
                    case 3:
                      mantenimiento.deleproducto();
                       imprimirmenu();
                       break;
                    case 4:
                        mantenimiento.listarproducto();
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



