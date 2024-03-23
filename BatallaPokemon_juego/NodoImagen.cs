using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class NodoImagen
    {
        private string imagen;
        private NodoImagen siguiente;

        public NodoImagen(string imagen)
        {
            this.imagen = imagen;
            this.siguiente = null;
        }

        public string getImagen()
        {
            return imagen;
        }

        public void setImagen(string imagen)
        {
            this.imagen = imagen;
        }

        public NodoImagen getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(NodoImagen siguiente)
        {
            this.siguiente = siguiente;
        }
    }
}
