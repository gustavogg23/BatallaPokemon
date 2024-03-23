﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class ListaJugadores
    {
        //Atributos
        private NodoJugador cabeza;
        private int tamano;


        //Método constructor
        public ListaJugadores()
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
        public void agregar(Entrenador valor)
        {
            NodoJugador nuevo = new NodoJugador(valor); // Se crea un nuevo nodo
            if (estaVacia()) // Si la lista está vacía, el nuevo nodo será la cabeza
            {
                cabeza = nuevo;
            }
            else // Si la lista no está vacía, se recorre la lista hasta llegar al último nodo y se agrega el nuevo nodo
            {
                NodoJugador aux = cabeza; // Se crea un nodo auxiliar para recorrer la lista
                while (aux.getSiguiente() != null) // Mientras el nodo auxiliar no sea el último nodo
                {
                    aux = aux.getSiguiente(); // Se pasa al siguiente nodo
                }
                aux.setSiguiente(nuevo); // Se agrega el nuevo nodo al final de la lista
            }
            tamano++; // Se aumenta el tamaño de la lista
        }
    }
}
