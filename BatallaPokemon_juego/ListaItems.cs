using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class ListaItems
    {
        // Atributos
        private NodoItem cabeza;
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
        public void agregar(Item valor)
        {
            NodoItem nuevo = new NodoItem(valor); // Se crea un nuevo nodo
            if (estaVacia()) // Si la lista está vacía, el nuevo nodo será la cabeza
            {
                cabeza = nuevo;
            }
            else // Si la lista no está vacía, se recorre la lista hasta llegar al último nodo y se agrega el nuevo nodo
            {
                NodoItem aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
                while (aux.getSiguiente() != null) // Mientras el nodo auxiliar no sea el último nodo
                {
                    aux = aux.getSiguiente(); // Se pasa al siguiente nodo
                }
                aux.setSiguiente(nuevo); // Se agrega el nuevo nodo al final de la lista
            }
            tamano++; // Se aumenta el tamaño de la lista
        }

        // Método para buscar un item en la lista
        public Item buscar(string nombre)
        {
            NodoItem aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
            while (aux != null) // Mientras el nodo auxiliar no sea nulo
            {
                if (aux.getValor().getNombre() == nombre) // Si el nombre del item del nodo auxiliar es igual al nombre buscado
                {
                    return aux.getValor(); // Se retorna el item del nodo auxiliar
                }
                aux = aux.getSiguiente(); // Se pasa al siguiente nodo
            }
            return null; // Si no se encuentra el item, se retorna nulo
        }

        // Método para eliminar un item de la lista
        public void eliminar(string nombre)
        {
            if (cabeza != null) // Si la lista no está vacía
            {
                if (cabeza.getValor().getNombre() == nombre) // Si el nombre del item de la cabeza es igual al nombre buscado
                {
                    cabeza = cabeza.getSiguiente(); // Se elimina la cabeza
                    tamano--; // Se disminuye el tamaño de la lista
                }
                else // Si el nombre del item de la cabeza no es igual al nombre buscado
                {
                    NodoItem aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
                    while (aux.getSiguiente() != null) // Mientras el nodo auxiliar no sea el último nodo
                    {
                        if (aux.getSiguiente().getValor().getNombre() == nombre) // Si el nombre del item del siguiente nodo es igual al nombre buscado
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
