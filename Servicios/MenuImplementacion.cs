using ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        

        public int mostrarMenuYSeleccionPrin()
        {
            int opcion;

            Console.WriteLine("########################################");
            Console.WriteLine("0. Salir de la aplicacion");
            Console.WriteLine("1. Crear Biblioteca");
            Console.WriteLine("2. Ver Bibliotecas");
            Console.WriteLine("3. Acceder a la Biblioteca especifica");
            Console.WriteLine("########################################");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

        public int mostrarMenuYseleccionSec()
        {
            int opcion;

            Console.WriteLine("###################");
            Console.WriteLine("0. Salir del menu");
            Console.WriteLine("1. Crear Cliente");
            Console.WriteLine("2. Crear Libro");
            Console.WriteLine("2. Crear Prestamo");
            Console.WriteLine("###################");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

        public void menuPrin(List<BibliotecaDto> listaAntiguaBib)
        {
            int opcionS;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {

            }
        }
    }
}
