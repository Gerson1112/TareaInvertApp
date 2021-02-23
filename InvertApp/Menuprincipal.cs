using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class Menuprincipal : iMenu
    {

        public void imprimirmenu()
        {

            Salida_de_invetario salida = new Salida_de_invetario();
            Entrada_de_inventario entrada = new Entrada_de_inventario();
            try{
            
                iMenu menu1;
                Console.Clear();
                Console.WriteLine("\n---Menu Principal--- \n1.Mantenimiento de categorias \n2.Mantenimiento de productos \n3.Entrada de inventario \n4.Salida de inventario \n5.Salir ");
                int menu0 = int.Parse(Console.ReadLine());

                switch (menu0)
                {
                    case 1:
                        menu1 = new Menucategoria();
                        menu1.imprimirmenu();
                        break;
                    case 2:
                        menu1 = new Menuproducto();
                        menu1.imprimirmenu();
                        break;
                    case 3:
                        entrada.entradaeinventario();
                        imprimirmenu();
                        break;
                    case 4:
                        salida.salidadeinventario();
                        imprimirmenu();
                        break;
                    case 5:
                        Console.WriteLine("El sistema se va a cerrar...");
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

