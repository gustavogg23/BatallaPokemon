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
        private string efecto;
        private string imagen;

        // Método constructor
        public Ataque(string nombre, string tipo, string efecto, string imagen)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.efecto = efecto;
            this.imagen = imagen; ;
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

        public string getEfecto()
        {
            return efecto;
        }

        public void setEfecto(string efecto)
        {
            this.efecto = efecto;
        }

        public string getImagen()
        {
            return imagen;
        }

        public void setImagen(string imagen)
        {
            this.imagen = imagen;
        }
    }
}
