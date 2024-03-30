using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class ListaCircularDE
    {
        // Atributos
        private NodoPokemon cabeza;
        private int tamano;

        // Método constructor
        public ListaCircularDE()
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
            NodoPokemon nuevo = new NodoPokemon(valor); // Se crea un nuevo nodo
            if (estaVacia()) // Si la lista está vacía, el nuevo nodo será la cabeza
            {
                cabeza = nuevo; // La cabeza apuntará al nuevo nodo
                cabeza.setSiguiente(cabeza); // El siguiente del nuevo nodo será la cabeza
                cabeza.setAnterior(cabeza); // El anterior del nuevo nodo será la cabeza
            }
            else // Si la lista no está vacía
            {
                NodoPokemon aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
                while (aux.getSiguiente() != cabeza) // Mientras el nodo auxiliar no sea el último nodo
                {
                    aux = aux.getSiguiente(); // Se pasa al siguiente nodo
                }
                aux.setSiguiente(nuevo); // El siguiente del último nodo será el nuevo nodo
                nuevo.setAnterior(aux); // El anterior del nuevo nodo será el último nodo
                nuevo.setSiguiente(cabeza); // El siguiente del nuevo nodo será la cabeza
                cabeza.setAnterior(nuevo); // El anterior de la cabeza será el nuevo nodo
            }
            tamano++; // Se aumenta el tamaño de la lista
        }

        // Método para buscar un pokemon en la lista
        public Pokemon buscar(int numero)
        {
            NodoPokemon aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
            while (aux != null) // Mientras no se llegue al final de la lista 
            {
                if (aux.getValor().getNumero() == numero) // Si el número del pokemon del nodo auxiliar es igual al número buscado
                {
                    return aux.getValor(); // Se retorna el pokemon del nodo auxiliar
                }
                aux = aux.getSiguiente(); // Se pasa al siguiente nodo
                if (aux == cabeza) // Si el nodo auxiliar es la cabeza, se termina el ciclo
                {
                    return null; // Si no se encuentra el pokemon, se retorna nulo
                }
            }
            return null; // Si no se encuentra el pokemon, se retorna nulo
        }

        // Método para verificar si ya está un pokemon en la lista
        public bool estaEnLista(int numero)
        {
            NodoPokemon aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
            while (aux != null) // Mientras no se llegue al final de la lista
            {
                if (aux.getValor().getNumero() == numero) // Si el número del pokemon del nodo auxiliar es igual al número buscado
                {
                    return true; // Se retorna verdadero
                }
                aux = aux.getSiguiente(); // Se pasa al siguiente nodo
                if (aux == cabeza) // Si el nodo auxiliar es la cabeza, se termina el ciclo
                {
                    return false; // Si no se encuentra el pokemon, se retorna falso
                }
            }
            return false; // Si no se encuentra el pokemon, se retorna falso
        }

        // Método para eliminar un pokemon de la lista
        public void eliminar(int numero)
        {
            if (cabeza != null) // En caso de que la lista no esté vacía 
            {
                NodoPokemon aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
                NodoPokemon ant = null; // Se crea un nodo auxiliar para guardar el nodo anterior
                do // Bucle para recorrer la lista 
                {
                    if (aux.getValor().getNumero() == numero) // Si el número del pokemon es igual al número del pokemon buscado 
                    {
                        if (ant != null) // En caso de que el nodo anterior no sea nulo 
                        {
                            ant.setSiguiente(aux.getSiguiente()); // El siguiente del nodo anterior será el siguiente del nodo actual
                            aux.getSiguiente().setAnterior(ant); // El anterior del siguiente del nodo actual será el nodo anterior
                            if (aux == cabeza) // Si el nodo actual es la cabeza
                            {
                                cabeza = aux.getSiguiente(); // La cabeza será el siguiente del nodo actual
                            }
                        }
                        else // En caso de que el nodo anterior sea nulo
                        {
                            cabeza = aux.getSiguiente(); // La cabeza será el siguiente del nodo actual
                            cabeza.setAnterior(aux.getAnterior()); // El anterior de la cabeza será el anterior del nodo actual
                            aux.getAnterior().setSiguiente(cabeza); // El siguiente del anterior del nodo actual será la cabeza
                        }
                        tamano--;
                        return; // Se termina el método
                    }
                    ant = aux; // El nodo anterior será el nodo actual
                    aux = aux.getSiguiente(); // El nodo actual será el siguiente del nodo actual
                } while (aux != cabeza); // Mientras el nodo actual no sea la cabeza
            }
        }

        // Método para obtener la cabeza de la lista
        public NodoPokemon getPrimero()
        {
            return cabeza;
        }

        // Método para obtener el tamaño de la lista
        public int getTamano()
        {
            return tamano;
        }

        // Método para recorrer la lista
        public void recorrer()
        {
            NodoPokemon aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
            do // Bucle para recorrer la lista
            {
                aux = aux.getSiguiente(); // Se pasa al siguiente nodo
            } 
            while (aux != cabeza); // Mientras el nodo auxiliar no sea la cabeza
        }
    }
}
