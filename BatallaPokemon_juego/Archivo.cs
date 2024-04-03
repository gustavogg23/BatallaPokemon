using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatallaPokemon_juego
{
    public class Archivo
    {
        //Atributos
        private string ruta;

        // Método constructor
        public Archivo(string ruta)
        {
            this.ruta = ruta;
        }

        // Método para crear un archivo de texto y/o sobreescribirlo
        public void Escribir(string texto)
        {
            StreamWriter escritor; // Objeto para escribir en el archivo

            if (File.Exists(ruta)) // Si el archivo ya existe, se sobreescribe
            {
                escritor = File.AppendText(ruta); 
            }
            else // Si el archivo no existe, se crea
            {
                escritor = new StreamWriter(ruta); // Se crea el archivo
            }

            escritor.WriteLine(texto); // Se escribe el texto en el archivo
            escritor.Close(); // Se cierra el archivo
        }

        public void Sobreescribir(string ruta, string texto)
        {
            StreamWriter escritor; // Objeto para escribir en el archivo

            // Si el archivo ya existe, se sobreescribe
            escritor = new StreamWriter(ruta);

            escritor.WriteLine(texto); // Se escribe el texto en el archivo
            escritor.Close(); // Se cierra el archivo
        }
        // Método para leer un archivo de texto
        public string[] Leer()
        {
            try 
            {
                string[] lineas = File.ReadAllLines(ruta); // Se leen todas las líneas del archivo
                return lineas; // Se retornan las líneas
            }
            catch (Exception e) // Si ocurre un error
            {
                MessageBox.Show("Error al leer el archivo: " + e.Message); // Se imprime el error
                return null; // Se retorna null
            }
        }
    }
}
