using ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.Servicios
{
    internal class PrestamoImplementacion : PrestamoInterfaz
    {
        public void crearPrestamo(List<PrestamoDto> listaAntiguaPres)
        {
            ClienteDto cliente = new ClienteDto();
            LibroDto libro = new LibroDto();
            PrestamoDto prestamo = new PrestamoDto();
            BibliotecaDto biblioteca = new BibliotecaDto();           
            long idCliente;
            long idLibro;
            long idBiblioteca;

            prestamo.IdPrestamo = idPrestamo(listaAntiguaPres);

            Console.WriteLine("Introduce el id de la biblioteca: ");
            idBiblioteca=Int64.Parse(Console.ReadLine());
            if(idBiblioteca.Equals(biblioteca.IdBiblioteca))
            {
                biblioteca.IdBiblioteca=idBiblioteca;
            }
            Console.WriteLine("Introduce tu id de cliente: ");
            idCliente=Int64.Parse(Console.ReadLine());

            if (idCliente.Equals(cliente.IdCliente))
            {
                cliente.IdCliente = idCliente;
            }

            Console.WriteLine("Introduce el id del libro: ");
            idLibro=Int64.Parse(Console.ReadLine());

            if (idLibro.Equals(libro.IdLibro))
            {
                libro.IdLibro = idLibro;
            }

           prestamo.FchPrestamo=DateTime.Now;
           prestamo.FchEntrega = prestamo.FchPrestamo.AddDays(8);
           prestamo.EstadoPrestamo = "En proceso";

            listaAntiguaPres.Add(prestamo);

        

                      
        
        }

        

        private long idPrestamo(List<PrestamoDto> listaAntiguaPres)
        {
            long nuevoId;
            int tamanioLista=listaAntiguaPres.Count;

            if (tamanioLista > 0)
            {
                nuevoId = listaAntiguaPres[tamanioLista - 1].IdPrestamo + 1;
            }
            else
            {
                nuevoId = 1;
            }

            return nuevoId;
        }

        

       
    }
}
