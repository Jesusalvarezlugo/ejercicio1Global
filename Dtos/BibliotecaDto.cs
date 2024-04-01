using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.Dtos
{
    internal class BibliotecaDto
    {
        //Atributos

        long idBiblioteca;
        string nombreBiblioteca = "aaaaa";
        string direccion = "aaaaa";

        

        //Getters y Setters
        public long IdBiblioteca { get => idBiblioteca; set => idBiblioteca = value; }
        public string NombreBiblioteca { get => nombreBiblioteca; set => nombreBiblioteca = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        //Constructores

        public BibliotecaDto()
        {

        }
        public BibliotecaDto(long idBiblioteca, string nombreBiblioteca, string direccion)
        {
            this.idBiblioteca = idBiblioteca;
            this.nombreBiblioteca = nombreBiblioteca;
            this.direccion = direccion;
        }
    }
}
