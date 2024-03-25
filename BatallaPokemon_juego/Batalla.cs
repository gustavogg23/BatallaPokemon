using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class Batalla
    {
        // Atributos
        private Entrenador entrenador1;
        private Entrenador entrenador2;
        private int turno;

        // Método constructor
        public Batalla(Entrenador entrenador1, Entrenador entrenador2)
        {
            this.entrenador1 = entrenador1;
            this.entrenador2 = entrenador2;
            determinarTurno();
        }

        // Método para determinar quien tiene el primer turno
        public void determinarTurno()
        {
            Pokemon pokemon1 = entrenador1.getPokemones().getPrimero().getValor();
            Pokemon pokemon2 = entrenador2.getPokemones().getPrimero().getValor();

            if (pokemon1.getVelocidad() > pokemon2.getVelocidad())
            {
                turno = 1;
            }
            else
            {
                turno = 2;
            }
        }

        // Método para obtener el entrenador que tiene el turno
        public Entrenador getEntrenadorTurno()
        {
            if (turno == 1)
            {
                return entrenador1;
            }
            else
            {
                return entrenador2;
            }
        }

        // Método para obtener el entrenador que no tiene el turno
        public Entrenador getEntrenadorNoTurno()
        {
            if (turno == 1)
            {
                return entrenador2;
            }
            else
            {
                return entrenador1;
            }
        }
    }
}
