using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon
{
    public class Nodo
    {
        //Atributos
        private Pokemon valor;
        private Nodo siguiente;

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
    }
}
