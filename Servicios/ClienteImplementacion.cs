using ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {
        public void crearCliente(List<ClienteDto> listaAntiguaCli)
        {
            ClienteDto clienteNuevo = nuevoCliente();
            clienteNuevo.IdCliente = autoIdC(listaAntiguaCli);

            listaAntiguaCli.Add(clienteNuevo);
        }

        private ClienteDto nuevoCliente()
        {
            ClienteDto cliente = new ClienteDto();
            string fechaNacimiento;

            Console.WriteLine("Introduzca el nombre del cliente: ");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del cliente: ");
            cliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca la fecha de nacimiento del cliente: ");
            fechaNacimiento = Console.ReadLine();
            cliente.FechaNacimiento=Convert.ToDateTime(fechaNacimiento);
            Console.WriteLine("Introduzca el dni del cliente: ");
            cliente.DniCliente = Console.ReadLine();

            return cliente;
        }

        private long autoIdC(List<ClienteDto> listaAntiguaCli)
        {
            int tamanioLista = listaAntiguaCli.Count;
            long nuevoId;
            if (tamanioLista > 0)
            {
                nuevoId = listaAntiguaCli[tamanioLista - 1].IdCliente + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;
        }
    }
}
