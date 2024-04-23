using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.Dtos
{
    internal class ClienteDto
    {
        //Atributos

        long idCliente;
        string nombreCliente = "aaaaa";
        string apellidosCliente = "aaaaa";
        DateTime fechaNacimiento=31/12/9999 00:00:00;
        string dniCliente = "aaaaa";
        DateTime fchInicioSus;
        DateTime fchFinSus;
        long idBiblio;

        

        //Getters y Setters
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public DateTime FchInicioSus { get => fchInicioSus; set => fchInicioSus = value; }
        public DateTime FchFinSus { get => fchFinSus; set => fchFinSus = value; }
        public long IdBiblio { get => idBiblio; set => idBiblio = value; }

        //Constructores

        public ClienteDto()
        {

        }
        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, DateTime fechaNacimiento, string dniCliente, DateTime fchInicioSus, DateTime fchFinSus,long idBiblio)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.fechaNacimiento = fechaNacimiento;
            this.dniCliente = dniCliente;
            this.fchInicioSus = fchInicioSus;
            this.fchFinSus = fchFinSus;
            this.idBiblio = idBiblio;
        }

        //ToString

        override
            public string ToString()
        {
            string texto = "ID: "+this.idCliente+"\n Nombre: "+this.nombreCliente+"\n Apellidos: "+this.apellidosCliente+"\n Fecha de nacimiento: "+this.fechaNacimiento+
                "Dni: "+this.dniCliente+"\nIdBiblioteca: "+this.idBiblio;

            return texto;
        }
    }
}
