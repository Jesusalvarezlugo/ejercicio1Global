﻿using ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.Servicios
{
    internal interface LibroInterfaz
    {
        public void crearLibro(List<LibroDto> listaAntiguaLib);

        public void validarIsbn(List<LibroDto> listaAntiguaLib);
    }
}
