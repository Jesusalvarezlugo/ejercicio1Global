using ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void crearFichero(List<BibliotecaDto> listaAntiguaBib/*, List<ClienteDto> listaAntiguaCliente, List<LibroDto> listaAntiguaLib, List<PrestamoDto> listaAntiguaPres*/,string ruta)
        {
            StreamWriter sw = new StreamWriter(ruta);

            foreach(BibliotecaDto bib in listaAntiguaBib)
            {
                string s = bib.IdBiblioteca+";"+bib.NombreBiblioteca + ";" + bib.Direccion;
                sw.WriteLine(s);
            }

            sw.Close();
        }

        public void leerFicheros(string ruta, List<BibliotecaDto> listaAntiguaBib)
        {
            try
            {
                

                string[] lineas =File.ReadAllLines(ruta) ;

                foreach (string linea in lineas)
                {
                    string[] biblioteca = linea.Split(";");
                    BibliotecaDto bibl = new BibliotecaDto();
                    bibl.IdBiblioteca = Convert.ToInt64(biblioteca[0]);
                    bibl.NombreBiblioteca = biblioteca[1];
                    bibl.Direccion = biblioteca[2];

                    listaAntiguaBib.Add(bibl);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR!! No se pueden leer las listas.");
            }

            
        }
    }
}
