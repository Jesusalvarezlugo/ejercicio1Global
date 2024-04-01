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
        DateTime fechaNacimiento;
        string dniCliente = "aaaaa";
        DateTime fchInicioSus;
        DateTime fchFinSus;

        

        //Getters y Setters
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public DateTime FchInicioSus { get => fchInicioSus; set => fchInicioSus = value; }
        public DateTime FchFinSus { get => fchFinSus; set => fchFinSus = value; }

        //Constructores

        public ClienteDto()
        {

        }
        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, DateTime fechaNacimiento, string dniCliente, DateTime fchInicioSus, DateTime fchFinSus)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.fechaNacimiento = fechaNacimiento;
            this.dniCliente = dniCliente;
            this.fchInicioSus = fchInicioSus;
            this.fchFinSus = fchFinSus;
        }
    }
}
