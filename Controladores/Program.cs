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
                        Console.WriteLine("[INFO] se Creada una biblioteca");
                        bi.crearBiblioteca(listaBiblioteca);
                        break;

                    case 2:
                        Console.WriteLine("[INFO] se veran las bibliotecas");
                        foreach(BibliotecaDto biblioteca in listaBiblioteca)
                        {
                            Console.WriteLine(biblioteca.ToString()); 
                        }
                        break;
                }
            }
        }
    }
}