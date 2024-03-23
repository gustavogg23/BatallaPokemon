using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class ListaImagenes
    {
        private NodoImagen cabeza;
        private int tamano;

        public ListaImagenes()
        {
            this.cabeza = null;
            this.tamano = 0;
        }

        public bool estaVacia()
        {
            return cabeza == null;
        }

        public void agregar(string imagen)
        {
            NodoImagen nuevo = new NodoImagen(imagen);
            if (estaVacia())
            {
                cabeza = nuevo;
            }
            else
            {
                NodoImagen aux = cabeza;
                while (aux.getSiguiente() != null)
                {
                    aux = aux.getSiguiente();
                }
                aux.setSiguiente(nuevo);
            }
            tamano++;
        }

        public string buscar(string imagen)
        {
            NodoImagen aux = cabeza;
            while (aux != null)
            {
                if (aux.getImagen() == imagen)
                {
                    return aux.getImagen();
                }
                aux = aux.getSiguiente();
            }
            return null;
        }
    }
}
