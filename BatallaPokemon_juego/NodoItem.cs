using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class NodoItem
    {
        // Atributos
        private Item valor;
        private NodoItem siguiente;

        // Método constructor
        public NodoItem(Item valor)
        {
            this.valor = valor;
            this.siguiente = null;
        }

        // Métodos Getters y Setters
        public Item getValor()
        {
            return valor;
        }

        public void setValor(Item valor)
        {
            this.valor = valor;
        }

        public NodoItem getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(NodoItem siguiente)
        {
            this.siguiente = siguiente;
        }
    }
}
