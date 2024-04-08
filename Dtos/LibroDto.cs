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
        string iSBN = "aaaaa";
        string editorialLibro = "aaaaa";
        int stockLibro=0;
        long idBiblio;

        

        //Getters y Setters
        public long IdLibro { get => idLibro; set => idLibro = value; }
        public string TituloLibro { get => tituloLibro; set => tituloLibro = value; }
        public string SubtituloLibro { get => subtituloLibro; set => subtituloLibro = value; }
        public string AutorLibro { get => autorLibro; set => autorLibro = value; }
        public string ISBN1 { get => iSBN; set => iSBN = value; }
        public string EditorialLibro { get => editorialLibro; set => editorialLibro = value; }
        public int StockLibro { get => stockLibro; set => stockLibro = value; }
        public long IdBiblio { get => idBiblio; set => idBiblio = value; }

        //Constructores

        public LibroDto()
        {

        }
        public LibroDto(long idLibro, string tituloLibro, string subtituloLibro, string autorLibro, string iSBN, string editorialLibro, int stockLibro,long idBiblio)
        {
            this.idLibro = idLibro;
            this.tituloLibro = tituloLibro;
            this.subtituloLibro = subtituloLibro;
            this.autorLibro = autorLibro;
            this.iSBN = iSBN;
            this.editorialLibro = editorialLibro;
            this.stockLibro = stockLibro;
            this.idBiblio = idBiblio;
        }

        //Metodo toString

        override
            public string ToString()
        {
            string texto = "ID: "+this.idLibro+"\nTitulo: "+this.tituloLibro+"\nISBN: "+this.iSBN+"\niDBiblioteca: "+this.idBiblio;

            return texto;
        }
    }
}
