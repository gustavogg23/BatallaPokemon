using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class NodoJugador
    {
        // Atributos
        private Entrenador valor;
        private NodoJugador siguiente;

        // Método constructor
        public NodoJugador(Entrenador valor)
        {
            this.valor = valor;
            this.siguiente = null;
        }

        // Métodos Getters y Setters
        public Entrenador getValor()
        {
            return valor;
        }

        public void setValor(Entrenador valor)
        {
            this.valor = valor;
        }

        public NodoJugador getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(NodoJugador siguiente)
        {
            this.siguiente = siguiente;
        }
    }
}
