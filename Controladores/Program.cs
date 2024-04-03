using ejercicio1Global.Servicios;

namespace ejercicio1Global.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi=new MenuImplementacion();
            BibliotecaInterfaz bi=new BibliotecaImplementacion();
            bool cerrarMenu = false;
            int opcion;

            while (!cerrarMenu)
            {
                try
                {
                    
                }catch(Exception e)
                {
                    Console.WriteLine("Error al iniciar el menu.");
                }
            }
        }
    }
}