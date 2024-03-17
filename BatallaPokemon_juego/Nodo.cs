using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class Nodo
    {
        //Atributos
        private Pokemon valor;
        private Nodo siguiente;
        private Nodo anterior;

        //Método constructor
        public Nodo(Pokemon valor)
        {
            this.valor = valor;
            this.siguiente = null;
        }

        //Métodos Getters y Setters
        public Pokemon getValor()
        {
            return valor;
        }

        public void setValor(Pokemon valor)
        {
            this.valor = valor;
        }

        public Nodo getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(Nodo siguiente)
        {
            this.siguiente = siguiente;
        }

        public Nodo getAnterior()
        {
            return anterior;
        }

        public void setAnterior(Nodo anterior)
        {
            this.anterior = anterior;
        }
    }
}
