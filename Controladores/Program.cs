using ejercicio1Global.Dtos;
using ejercicio1Global.Servicios;

namespace ejercicio1Global.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi=new MenuImplementacion();
            BibliotecaInterfaz bi=new BibliotecaImplementacion();
            List < BibliotecaDto > listaBiblioteca= new List<BibliotecaDto>();
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            List<LibroDto> listaLibros=new List<LibroDto>();
            List<PrestamoDto> listaPrestamos= new List<PrestamoDto>();
            bool cerrarMenu = false;
            int opcion;
            

            while (!cerrarMenu)
            {
                opcion=mi.mostrarMenuYSeleccionPrin();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("[INFO] se cerrara el menu.");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] se Creara una biblioteca");
                        bi.crearBiblioteca(listaBiblioteca);
                        break;

                    case 2:
                        Console.WriteLine("[INFO] se veran las bibliotecas");
                        foreach(BibliotecaDto biblioteca in listaBiblioteca)
                        {
                            Console.WriteLine(biblioteca.ToString()); 
                        }
                        break;

                    case 3:
                        Console.WriteLine("[INFO] se accedera al menu de la biblioteca");
                        mi.menuBiblioteca(listaClientes,listaLibros,listaPrestamos);
                        break;
                }
            }
        }
    }
}