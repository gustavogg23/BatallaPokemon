using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class ListaItems
    {
        private class NodoLista
        {
            public PilaItems pila;
            public NodoLista siguiente;

            public NodoLista(PilaItems pila)
            {
                this.pila = pila;
                this.siguiente = null;
            }

            public PilaItems getPila()
            {
                return pila;
            }

            public void setPila(PilaItems pila)
            {
                this.pila = pila;
            }

            public NodoLista getSiguiente()
            {
                return siguiente;
            }

            public void setSiguiente(NodoLista siguiente)
            {
                this.siguiente = siguiente;
            }
        }

        // Atributos
        private NodoLista cabeza;
        private int tamano;

        // Método constructor
        public ListaItems()
        {
            this.cabeza = null;
            this.tamano = 0;
        }

        // Método para saber si la lista está vacía
        public bool estaVacia()
        {
            return cabeza == null;
        }

        // Método para agregar un nuevo nodo al final de la lista
        public void agregar(PilaItems pila)
        {
            NodoLista nuevo = new NodoLista(pila); // Se crea un nuevo nodo
            if (estaVacia()) // Si la lista está vacía, el nuevo nodo será la cabeza
            {
                cabeza = nuevo;
            }
            else // Si la lista no está vacía, se recorre la lista hasta llegar al último nodo y se agrega el nuevo nodo
            {
                NodoLista aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
                while (aux.getSiguiente() != null) // Mientras el nodo auxiliar no sea el último nodo
                {
                    aux = aux.getSiguiente(); // Se pasa al siguiente nodo
                }
                aux.setSiguiente(nuevo); // Se agrega el nuevo nodo al final de la lista
            }
            tamano++; // Se aumenta el tamaño de la lista
        }

        // Método para buscar una pila de items en la lista
        public PilaItems buscar(PilaItems pilaBuscada)
        {
            NodoLista aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
            while (aux != null) // Mientras el nodo auxiliar no sea nulo
            {
                if (aux.getPila() == pilaBuscada) 
                {
                    return aux.getPila(); // Se retorna el item del nodo auxiliar
                }
                aux = aux.getSiguiente(); // Se pasa al siguiente nodo
            }
            return null; // Si no se encuentra la pila de items, se retorna nulo
        }

        // Método para eliminar una pila de items de la lista
        public void eliminar(PilaItems pilaAEliminar)
        {
            if (cabeza != null) // Si la lista no está vacía
            {
                if (cabeza.getPila() == pilaAEliminar) // 
                {
                    cabeza = cabeza.getSiguiente(); // Se elimina la cabeza
                    tamano--; // Se disminuye el tamaño de la lista
                }
                else 
                {
                    NodoLista aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
                    while (aux.getSiguiente() != null) // Mientras el nodo auxiliar no sea el último nodo
                    {
                        if (aux.getSiguiente().getPila() == pilaAEliminar) 
                        {
                            aux.setSiguiente(aux.getSiguiente().getSiguiente()); // Se elimina el siguiente nodo
                            tamano--; // Se disminuye el tamaño de la lista
                            break; // Se sale del ciclo
                        }
                        aux = aux.getSiguiente(); // Se pasa al siguiente nodo
                    }
                }
            }
        }
    }
}
