using ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.Servicios
{
    internal class BibliotecaImplementacion : BibliotecaInterfaz
    {
        public void crearBiblioteca(List<BibliotecaDto> listaBiblioAnt)
        {
            BibliotecaDto bibliotecaNueva = nuevaBiblioteca();
            bibliotecaNueva.IdBiblioteca = autoIdB(listaBiblioAnt);
            listaBiblioAnt.Add(bibliotecaNueva);
        }

        private BibliotecaDto nuevaBiblioteca()
        {
            BibliotecaDto biblioteca = new BibliotecaDto();

            Console.WriteLine("Introduzca el nombre de la biblioteca: ");
            biblioteca.NombreBiblioteca = Console.ReadLine();
            Console.WriteLine("Introduzca la direccion de la biblioteca: ");
            biblioteca.Direccion = Console.ReadLine();

            return biblioteca;


        }

        private long autoIdB(List<BibliotecaDto> listaBiblioAnt)
        {
            int tamanioLista = listaBiblioAnt.Count;
            long nuevoId;
            if (tamanioLista > 0)
            {
                nuevoId = listaBiblioAnt[tamanioLista - 1].IdBiblioteca + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;
        }
    }
}
