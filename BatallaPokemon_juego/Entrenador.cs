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
        private ListaItems items;

        // Método constructor
        public Entrenador(string nombre)
        {
            this.nombre = nombre;
            this.victorias = 0;
            this.pokemones = new ListaCircularDE();
            this.items = new ListaItems();
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

        public ListaItems getItems()
        {
            return items;
        }

        public void setItems(ListaItems items)
        {
            this.items = items;
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

        // Método para agregar un item a la lista de items del entrenador
        public void agregarItem(PilaItems item)
        {
            items.agregar(item);
        }

        // Método para buscar un item en la lista de items del entrenador
        public PilaItems buscarItem(PilaItems itemBuscado)
        {
            return items.buscar(itemBuscado);
        }

        // Método para eliminar un item de la lista de items del entrenador
        public void eliminarItem(PilaItems itemAEliminar)
        {
            items.eliminar(itemAEliminar);
        }

        // Método para mostrar la información del entrenador
        public string mostrarInfo()
        {
            return nombre + "," + victorias;
        }
    }
}
