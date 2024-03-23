using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class NodoPokemon
    {
        //Atributos
        private Pokemon valor;
        private NodoPokemon siguiente;
        private NodoPokemon anterior;

        //Método constructor
        public NodoPokemon(Pokemon valor)
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

        public NodoPokemon getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(NodoPokemon siguiente)
        {
            this.siguiente = siguiente;
        }

        public NodoPokemon getAnterior()
        {
            return anterior;
        }

        public void setAnterior(NodoPokemon anterior)
        {
            this.anterior = anterior;
        }
    }
}
