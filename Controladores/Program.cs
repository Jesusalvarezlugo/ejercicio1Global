using ejercicio1Global.Dtos;
using ejercicio1Global.Servicios;

namespace ejercicio1Global.Controladores
{
    class Program
    {
        public static long idBibliotecaSeleccionada;
        static void Main(string[] args)
        {
            MenuInterfaz mi=new MenuImplementacion();
            BibliotecaInterfaz bi=new BibliotecaImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            List < BibliotecaDto > listaBiblioteca= new List<BibliotecaDto>();
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            List<LibroDto> listaLibros=new List<LibroDto>();
            List<PrestamoDto> listaPrestamos= new List<PrestamoDto>();
            bool cerrarMenu = false;
            int opcion;
            string rutaArchivo = "C:\\Users\\Jesús\\Documents\\ejercicio1Global\\bin\\Debug\\net6.0\\archivo.txt";

            //leer ficheros y guardar en listas

            fi.leerFicheros(rutaArchivo,listaBiblioteca);
            try
            {
                while (!cerrarMenu)
                {
                    opcion = mi.mostrarMenuYSeleccionPrin();

                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("[INFO] se cerrara el menu.");

                            //Guardar en ficheros
                            fi.crearFichero(listaBiblioteca, rutaArchivo);

                            cerrarMenu = true;
                            break;

                        case 1:
                            Console.WriteLine("[INFO] se Creara una biblioteca");
                            bi.crearBiblioteca(listaBiblioteca);
                            break;

                        case 2:
                            Console.WriteLine("[INFO] se veran las bibliotecas");
                            foreach (BibliotecaDto biblioteca in listaBiblioteca)
                            {
                                Console.WriteLine(biblioteca.ToString());
                            }
                            break;

                        case 3:
                            Console.WriteLine("[INFO] se accedera al menu de la biblioteca");
                            mi.menuBiblioteca(listaClientes, listaLibros, listaPrestamos, listaBiblioteca);
                            break;

                        default:
                            Console.WriteLine("Opcion elegida erronea");
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error en la aplicacion");
            }
            
        }
    }
}