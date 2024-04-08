using ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.Servicios
{
    internal class LibroImplementacion : LibroInterfaz
    {
        public void crearLibro(List<LibroDto> listaAntiguaLib)
        {
            LibroDto libroNuevo = nuevoLibro();
            libroNuevo.IdLibro = autoIdL(listaAntiguaLib);

            listaAntiguaLib.Add(libroNuevo);
        }

        private LibroDto nuevoLibro()
        {
            LibroDto libro= new LibroDto();

            Console.WriteLine("Introduce el titulo del libro: ");
            libro.TituloLibro = Console.ReadLine();
            Console.WriteLine("Introduce el subtitulo del libro: ");
            libro.SubtituloLibro = Console.ReadLine();
            Console.WriteLine("Introduce el autor del libro:");
            libro.AutorLibro = Console.ReadLine();
            Console.WriteLine("Introduce el ISBN del lirbo: ");
            libro.ISBN1 = Console.ReadLine();
            Console.WriteLine("Introduce el stock del libro: ");
            libro.StockLibro=Int32.Parse(Console.ReadLine());

            return libro;
        }

        private long autoIdL(List<LibroDto> listaAntiguaLib)
        {
            int tamanioLista = listaAntiguaLib.Count;
            long nuevoId;
            if (tamanioLista > 0)
            {
                nuevoId = listaAntiguaLib[tamanioLista - 1].IdLibro + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;
        }
        
        public void validarIsbn(List<LibroDto> listaAntiguaLib)
        {
            string ibsnAPedir;

            Console.WriteLine("Introduzca el ISBN: ");
            ibsnAPedir = Console.ReadLine();

            for(int i = 0; i < listaAntiguaLib.Count; i++)
            {
                if (ibsnAPedir.Equals(listaAntiguaLib[i].ISBN1))
                {
                    listaAntiguaLib[i].ISBN1=ibsnAPedir;
                    break;
                }
                              
            }
            Console.WriteLine("El IBSN es correcto.");
          
        }
    }
}
