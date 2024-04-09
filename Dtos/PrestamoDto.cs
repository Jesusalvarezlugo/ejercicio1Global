using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.Dtos
{
    internal class PrestamoDto
    {
        //Atributos

        long idPrestamo;
        long idLibro;
        long idCliente;
        DateTime fchPrestamo;
        DateTime fchEntrega;
        string estadoPrestamo = "aaaaa";
        long idBiblio;

        

        //Getters y Setters
        public long IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public long IdLibro { get => idLibro; set => idLibro = value; }
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime FchPrestamo { get => fchPrestamo; set => fchPrestamo = value; }
        public DateTime FchEntrega { get => fchEntrega; set => fchEntrega = value; }
        public string EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }
        public long IdBiblio { get => idBiblio; set => idBiblio = value; }

        //Constructores

        public PrestamoDto()
        {

        }
        public PrestamoDto(long idPrestamo, long idLibro, long idCliente, DateTime fchPrestamo, DateTime fchEntrega, string estadoPrestamo, long idBiblio)
        {
            this.idPrestamo = idPrestamo;
            this.idLibro = idLibro;
            this.idCliente = idCliente;
            this.fchPrestamo = fchPrestamo;
            this.fchEntrega = fchEntrega;
            this.estadoPrestamo = estadoPrestamo;
            this.idBiblio = idBiblio;
            
        }

        override
            public string ToString()
        {
            string texto ="ID prestamo: "+this.idPrestamo+"\nID cliente: "+this.idCliente+"\nID libro: "+this.idLibro+"\nfecha prestamo: "+this.fchPrestamo
                +"\n fecha entrega: "+this.fchEntrega+"\n Estado prestamo: "+this.estadoPrestamo;

            return texto;
        }
    }
}
