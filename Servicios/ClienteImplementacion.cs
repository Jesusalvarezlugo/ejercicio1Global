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
        public void crearCliente(List<ClienteDto> listaAntiguaCli,List<BibliotecaDto> listaAntiguaB)
        {
            ClienteDto clienteNuevo = nuevoCliente();
            clienteNuevo.IdCliente = autoIdC(listaAntiguaCli);

            if(validarBiblioteca1(clienteNuevo.IdBiblio,listaAntiguaB))
            {
                listaAntiguaCli.Add(clienteNuevo);
            }
            else
            {
                Console.WriteLine("No existe la biblioteca.");
            }
            
            
        }

        private ClienteDto nuevoCliente()
        {
            ClienteDto cliente = new ClienteDto();
            string fechaNacimiento;
            int numDni;

            Console.WriteLine("Introduzca el nombre del cliente: ");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del cliente: ");
            cliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca la fecha de nacimiento del cliente: ");
            fechaNacimiento = Console.ReadLine();
            cliente.FechaNacimiento=Convert.ToDateTime(fechaNacimiento);
            Console.WriteLine("Introduzca el numero del dni: ");
            numDni=Int32.Parse(Console.ReadLine());
            cliente.DniCliente=dniCompleto(numDni);
            Console.WriteLine("Introduzca el id de la biblioteca donde crear el cliente: ");
            cliente.IdBiblio=Int64.Parse(Console.ReadLine());
           
           
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

        private string dniCompleto(int numDni)

        {
            char letraDni = 't';
            switch (numDni % 23)
            {
                case 0:
                    letraDni = 'T';
                    break;

                case 1:
                    letraDni = 'R';
                    break;

                case 2:
                    letraDni = 'W';
                    break;

                case 3:
                    letraDni = 'A';
                    break;

                case 4:
                    letraDni = 'G';
                    break;

                case 5:
                    letraDni = 'M';
                    break;

                case 6:
                    letraDni = 'Y';
                    break;

                case 7:
                    letraDni = 'F';
                    break;

                case 8:
                    letraDni = 'P';
                    break;

                case 9:
                    letraDni = 'D';
                    break;

                case 10:
                    letraDni = 'X';
                    break;

                case 11:
                    letraDni = 'B';
                    break;

                case 12:
                    letraDni = 'N';
                    break;

                case 13:
                    letraDni = 'J';
                    break;

                case 14:
                    letraDni = 'Z';
                    break;

                case 15:
                    letraDni = 'S';
                    break;

                case 16:
                    letraDni = 'Q';
                    break;

                case 17:
                    letraDni = 'V';
                    break;

                case 18:
                    letraDni = 'H';
                    break;

                case 19:
                    letraDni = 'L';
                    break;

                case 20:
                    letraDni = 'C';
                    break;

                case 21:
                    letraDni = 'K';
                    break;

                case 22:
                    letraDni = 'E';
                    break;

                default:
                    Console.WriteLine("ERROR! numero fuera de rango");
                    break;
            }

            string dniCompleto = numDni + "-" + letraDni;

            return dniCompleto;
        }

        

        private bool validarBiblioteca1(long idBiblioteca, List<BibliotecaDto> listaAntiguaBib)
        {
            bool hayBiblioteca = false;
            ClienteDto cliente = new ClienteDto();

            for(int i =0;i< listaAntiguaBib.Count;i++)
            {
                if (idBiblioteca == listaAntiguaBib[i].IdBiblioteca)
                {
                    idBiblioteca = cliente.IdBiblio;
                    hayBiblioteca=true;
                    
                }
                else
                {
                    Console.WriteLine("La biblioteca no existe.");
                    break;
                }
            }
            

            return hayBiblioteca;
        }
    }
}
