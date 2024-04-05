using ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.Servicios
{
    internal interface PrestamoInterfaz
    {
        public void crearPrestamo(List<PrestamoDto> listaAntiguaPres);
    }
}
