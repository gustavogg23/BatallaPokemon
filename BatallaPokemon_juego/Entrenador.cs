using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class Entrenador
    {
        // Atributos
        private string nombre;
        private int victorias;
        private ListaCircularDE pokemones;

        // Método constructor
        public Entrenador(string nombre)
        {
            this.nombre = nombre;
            this.victorias = 0;
            this.pokemones = new ListaCircularDE();
        }

        // Métodos Getters y Setters
        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int getVictorias()
        {
            return victorias;
        }

        public void setVictorias(int victorias)
        {
            this.victorias = victorias;
        }

        public ListaCircularDE getPokemones()
        {
            return pokemones;
        }

        public void setPokemones(ListaCircularDE pokemones)
        {
            this.pokemones = pokemones;
        }

        // Método para agregar un pokemon a la lista de pokemones del entrenador
        public void agregarPokemon(Pokemon pokemon)
        {
            pokemones.agregar(pokemon);
        }

        // Método para buscar un pokemon en la lista de pokemones del entrenador
        public Pokemon buscarPokemon(int numero)
        {
            return pokemones.buscar(numero);
        }

        // Método para eliminar un pokemon de la lista de pokemones del entrenador
        public void eliminarPokemon(int numero)
        {
            pokemones.eliminar(numero);
        }
    }
}
