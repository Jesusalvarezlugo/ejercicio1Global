using ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.Servicios
{
    internal interface FicheroInterfaz
    {
        public void crearFichero(List<BibliotecaDto> listaAntiguaBib/*,List<ClienteDto> listaAntiguaCliente,List<LibroDto> listaAntiguaLib,List<PrestamoDto> listaAntiguaPres*/,string ruta);

        public void leerFicheros(string ruta, List<BibliotecaDto> listaAntiguaBib);
    }
}
