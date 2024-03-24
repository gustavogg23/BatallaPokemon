using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class PilaItems
    {
        // Atributos
        private NodoItem cima;
        private int tamano;

        // Método constructor
        public PilaItems()
        {
            cima = null;
            tamano = 0;
        }

        // Método para verificar si la pila está vacía
        public bool estaVacia()
        {
            return cima == null;
        }

        // Método para obtener el tamaño de la pila
        public int getTamano()
        {
            return tamano;
        }

        // Método para insertar un item en la pila
        public void push(Item item)
        {
            NodoItem nuevo = new NodoItem(item);
            nuevo.setSiguiente(cima);
            cima = nuevo;
            tamano++;
        }

        // Método para eliminar un item de la pila
        public Item pop()
        {
            if (estaVacia())
            {
                return null;
            }
            Item item = cima.getValor();
            cima = cima.getSiguiente();
            tamano--;
            return item;
        }
    }
}
