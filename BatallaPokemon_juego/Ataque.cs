using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class Ataque
    {
        // Atributos
        private string nombre;
        private string tipo;
        private ListaImagenes imagenes;

        // Método constructor
        public Ataque(string nombre, string tipo, ListaImagenes imagenes)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.imagenes = imagenes;
        }

        // Métodos Getters y Setters
        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getTipo()
        {
            return tipo;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public ListaImagenes getImagenes()
        {
            return imagenes;
        }

        public void setImagenes(ListaImagenes imagenes)
        {
            this.imagenes = imagenes;
        }
    }
}
