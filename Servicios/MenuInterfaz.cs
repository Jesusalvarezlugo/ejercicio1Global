using ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.Servicios
{
    internal interface MenuInterfaz
    {
        public int mostrarMenuYSeleccionPrin();

        public int mostrarMenuYseleccionSec();

        public void menuPrin(List<BibliotecaDto> listaAntiguaBib);

        public void menuBiblioteca(List<ClienteDto> listaClienteAnt, List<LibroDto> listaLibroAnt, List<PrestamoDto> listaPrestamoAnt);
    }
}
