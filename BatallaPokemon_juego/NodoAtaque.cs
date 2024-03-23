using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class NodoAtaque
    {
        private Ataque ataque;
        private NodoAtaque siguiente;

        public NodoAtaque(Ataque ataque)
        {
            this.ataque = ataque;
            this.siguiente = null;
        }

        public Ataque getAtaque()
        {
            return ataque;
        }

        public void setAtaque(Ataque ataque)
        {
            this.ataque = ataque;
        }

        public NodoAtaque getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(NodoAtaque siguiente)
        {
            this.siguiente = siguiente;
        }
    }
}
