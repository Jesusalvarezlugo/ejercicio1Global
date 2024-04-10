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
            Console.WriteLine("3. Acceder al menu de una biblioteca");
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
            Console.WriteLine("3. Crear Prestamo");
            Console.WriteLine("###################");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

        public void menuPrin(List<BibliotecaDto> listaAntiguaBib)
        {
            int opcionS;
            bool cerrarMenu = false;
            BibliotecaInterfaz bi = new BibliotecaImplementacion();

            while (!cerrarMenu)
            {
                try
                {
                    opcionS=mostrarMenuYSeleccionPrin();

                    switch (opcionS)
                    {
                        case 0:
                            Console.WriteLine("[INFO] se cerrara la aplicacion.");
                            cerrarMenu = true;
                            break;

                        case 1:
                            Console.WriteLine("[INFO] se creara una biblioteca.");
                            bi.crearBiblioteca(listaAntiguaBib);
                            break;

                        case 2:
                            Console.WriteLine("[INFO] se veran las bibliotecas ");
                            foreach(BibliotecaDto biblioteca in listaAntiguaBib)
                            {
                                Console.WriteLine(biblioteca.ToString());
                            }
                            break;
                    }

                }catch (Exception e)
                {
                    Console.WriteLine("Error al iniciar el menu:  "+e.Message);
                }
                

                
            }
        }

        public void menuBiblioteca(List<ClienteDto> listaClienteAnt,List<LibroDto> listaLibroAnt,List<PrestamoDto> listaPrestamoAnt)
        {
            int opcionS;
            bool cerrarMenuB = false;
            ClienteInterfaz ci = new ClienteImplementacion();
            LibroInterfaz li = new LibroImplementacion();
            PrestamoInterfaz pi = new PrestamoImplementacion();

            while (!cerrarMenuB)
            {
                opcionS = mostrarMenuYseleccionSec();

                switch (opcionS)
                {
                    case 0:
                        Console.WriteLine("[INFO] se cerrara el menu de la biblioteca");
                        cerrarMenuB = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] se creara un cliente");
                        ci.validarBiblioteca(listaClienteAnt);
                        ci.crearCliente(listaClienteAnt);

                        foreach(ClienteDto cliente in listaClienteAnt)
                        {
                            Console.WriteLine(cliente.ToString());
                        }
                        break;

                    case 2:
                        Console.WriteLine("[INFO] se creara un libro");
                        li.validarIsbn(listaLibroAnt);
                        li.crearLibro(listaLibroAnt);

                        foreach(LibroDto libro in listaLibroAnt)
                        {
                            Console.WriteLine(libro.ToString());
                        }

                        break;

                    case 3:
                        Console.WriteLine("[INFO] se creara un prestamo");
                        pi.crearPrestamo(listaPrestamoAnt);
                        foreach(PrestamoDto prestamo in listaPrestamoAnt)
                        {
                            Console.Write(prestamo.ToString());
                        }
                        break;

                    default:
                        Console.WriteLine("Opcion introducida no valida");
                        break;
                }
            }
        }
    }
}
