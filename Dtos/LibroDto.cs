using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.Dtos
{
    internal class LibroDto
    {
        //Atributos

        long idLibro;
        string tituloLibro = "aaaaa";
        string subtituloLibro = "aaaaa";
        string autorLibro = "aaaaa";
        string ISBN = "aaaaa";
        string editorialLibro = "aaaaa";
        int stockLibro=0;

        

        //Getters y Setters
        public long IdLibro { get => idLibro; set => idLibro = value; }
        public string TituloLibro { get => tituloLibro; set => tituloLibro = value; }
        public string SubtituloLibro { get => subtituloLibro; set => subtituloLibro = value; }
        public string AutorLibro { get => autorLibro; set => autorLibro = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string EditorialLibro { get => editorialLibro; set => editorialLibro = value; }
        public int StockLibro { get => stockLibro; set => stockLibro = value; }

        //Constructores

        public LibroDto()
        {

        }
        public LibroDto(long idLibro, string tituloLibro, string subtituloLibro, string autorLibro, string iSBN, string editorialLibro, int stockLibro)
        {
            this.idLibro = idLibro;
            this.tituloLibro = tituloLibro;
            this.subtituloLibro = subtituloLibro;
            this.autorLibro = autorLibro;
            ISBN = iSBN;
            this.editorialLibro = editorialLibro;
            this.stockLibro = stockLibro;
        }
    }
}
