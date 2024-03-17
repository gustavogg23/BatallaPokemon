using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class ListaPokemones
    {
        //Atributos
        private Nodo cabeza;
        private int tamano;

        //Método constructor
        public ListaPokemones()
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
        public void agregar(Pokemon valor)
        {
            Nodo nuevo = new Nodo(valor); // Se crea un nuevo nodo
            if (estaVacia()) // Si la lista está vacía, el nuevo nodo será la cabeza
            {
                cabeza = nuevo;
            }
            else // Si la lista no está vacía, se recorre la lista hasta llegar al último nodo y se agrega el nuevo nodo
            {
                Nodo aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
                while (aux.getSiguiente() != null) // Mientras el nodo auxiliar no sea el último nodo
                {
                    aux = aux.getSiguiente(); // Se pasa al siguiente nodo
                }
                aux.setSiguiente(nuevo); // Se agrega el nuevo nodo al final de la lista
            }
            tamano++; // Se aumenta el tamaño de la lista
        }

        // Método para buscar un pokemon en la lista
        public Pokemon buscar(int numero)
        {
            Nodo aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
            while (aux != null) // Mientras el nodo auxiliar no sea nulo
            {
                if (aux.getValor().getNumero() == numero) // Si el número del pokemon del nodo auxiliar es igual al número buscado
                {
                    return aux.getValor(); // Se retorna el pokemon del nodo auxiliar
                }
                aux = aux.getSiguiente(); // Se pasa al siguiente nodo
            }
            return null; // Si no se encuentra el pokemon, se retorna nulo
        }

        // Método para eliminar un pokemon de la lista
        public void eliminar(int numero)
        {
            if (cabeza != null) // Si la lista no está vacía
            {
                if (cabeza.getValor().getNumero() == numero) // Si el número del pokemon de la cabeza es igual al número buscado
                {
                    cabeza = cabeza.getSiguiente(); // Se elimina la cabeza
                    tamano--; // Se disminuye el tamaño de la lista
                }
                else // Si el número del pokemon de la cabeza no es igual al número buscado
                {
                    Nodo aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
                    while (aux.getSiguiente() != null) // Mientras el nodo auxiliar no sea el último nodo
                    {
                        if (aux.getSiguiente().getValor().getNumero() == numero) // Si el número del pokemon del siguiente nodo es igual al número buscado
                        {
                            aux.setSiguiente(aux.getSiguiente().getSiguiente()); // Se elimina el nodo siguiente
                            tamano--; // Se disminuye el tamaño de la lista
                            break; // Se rompe el ciclo
                        }
                        aux = aux.getSiguiente(); // Se pasa al siguiente nodo
                    }
                }
            }
        }
    }
}
