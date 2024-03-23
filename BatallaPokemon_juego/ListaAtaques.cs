using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class ListaAtaques
    {
        private NodoAtaque cabeza;
        private int tamano;

        public ListaAtaques()
        {
            this.cabeza = null;
            this.tamano = 0;
        }

        public bool estaVacia()
        {
            return cabeza == null;
        }

        public void agregar(Ataque ataque)
        {
            NodoAtaque nuevo = new NodoAtaque(ataque);
            if (estaVacia())
            {
                cabeza = nuevo;
            }
            else
            {
                NodoAtaque aux = cabeza;
                while (aux.getSiguiente() != null)
                {
                    aux = aux.getSiguiente();
                }
                aux.setSiguiente(nuevo);
            }
            tamano++;
        }

        public Ataque buscar(string nombre)
        {
            NodoAtaque aux = cabeza;
            while (aux != null)
            {
                if (aux.getAtaque().getNombre() == nombre)
                {
                    return aux.getAtaque();
                }
                aux = aux.getSiguiente();
            }
            return null;
        }
    }
}
