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
        private Pokemon pokemonActivo1;
        private Pokemon pokemonActivo2;

        // Método constructor
        public Batalla(Entrenador entrenador1, Entrenador entrenador2)
        {
            this.entrenador1 = entrenador1;
            this.entrenador2 = entrenador2;
            determinarTurno();
            pokemonActivo1 = entrenador1.getPokemones().getPrimero().getValor();
            pokemonActivo2 = entrenador2.getPokemones().getPrimero().getValor();
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

        // Métodos Getters y Setters
        public Entrenador getEntrenador1()
        {
            return entrenador1;
        }

        public void setEntrenador1(Entrenador entrenador1)
        {
            this.entrenador1 = entrenador1;
        }

        public Entrenador getEntrenador2()
        {
            return entrenador2;
        }

        public void setEntrenador2(Entrenador entrenador2)
        {
            this.entrenador2 = entrenador2;
        }

        public int getTurno()
        {
            return turno;
        }

        public void setTurno(int turno)
        {
            this.turno = turno;
        }

        public Pokemon getPokemonActivo1()
        {
            return pokemonActivo1;
        }

        public void setPokemonActivo1(Pokemon pokemonActivo1)
        {
            this.pokemonActivo1 = pokemonActivo1;
        }

        public Pokemon getPokemonActivo2()
        {
            return pokemonActivo2;
        }

        public void setPokemonActivo2(Pokemon pokemonActivo2)
        {
            this.pokemonActivo2 = pokemonActivo2;
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

        // Método para cambiar turno
        public void cambiarTurno()
        {
            if (turno == 1)
            {
                turno = 2;
            }
            else
            {
                turno = 1;
            }
        }

        // Método para atacar
        public void atacar(int indiceAtaque)
        {
            // Se obtienen los pokemones activos de los entrenadores y se determina cual ataca y cual defiende
            Pokemon atacante = (turno == 1) ? pokemonActivo1 : pokemonActivo2;
            Pokemon defensor = (turno == 1) ? pokemonActivo2 : pokemonActivo1;

            // Se obtiene el ataque seleccionado por el atacante
            Ataque ataque = atacante.getAtaques()[indiceAtaque];

            // Se calcula el daño en base al ataque del atacante y la defensa del defensor
            int dmg = atacante.getAtaque() - defensor.getDefensa();

            // Para que siempre haya 1 como mínimo de daño
            dmg = Math.Max(dmg, 1);

            // Se calcula el multiplicador de efectividad del ataque
            decimal multEfectividad = CalcularEfectividadAtaque(ataque.getTipo(), defensor.getTipo1(), defensor.getTipo2());

            // Se aplica el multiplicador de efectividad al daño
            dmg = (int)Math.Round(dmg * multEfectividad);

            // Se genera un número al azar entre el 0 y el 100 para determinar si el ataque es crítico
            Random chanceCritico = new Random();
            if (chanceCritico.Next(0, 100) < 10) // Si el número es menor a 10 el ataque es crítico
            {
                dmg *= 3; // Se triplica el daño causado
            }

            // Se aplica el daño a la estadística de vida del defensor
            defensor.setVida(defensor.getVida() - dmg);

            // Se aplica efecto del ataque
            if (ataque.getEfecto() != "Ninguno")
            {
                AplicarEfectoAtaque(indiceAtaque);
            }

            // Si luego del ataque la vida del defensor es 0 o menor a 0 se elimina el pokemon de la lista de pokemones del entrenador
            if (defensor.getVida() <= 0)
            {
                getEntrenadorNoTurno().getPokemones().eliminar(defensor.getNumero());
            }

            // Se cambia el turno
            cambiarTurno();

            // Se aplica el efecto del estado alterado
            AplicarEfectoEstado();
        }

        public decimal CalcularEfectividadAtaque(string tipoAtaque, string tipoDefensor1, string tipoDefensor2)
        {
            decimal multiplicador;

            // Se verifica cada tipo y su efectividad contra los tipos del defensor
            if (tipoAtaque == "Normal" && (tipoDefensor1 == "Rock" || tipoDefensor2 == "Rock" || tipoDefensor1 == "Steel" || tipoDefensor2 == "Steel"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Normal" && (tipoDefensor1 == "Ghost" || tipoDefensor2 == "Ghost"))
            {
                multiplicador = 0m;
            }
            else if (tipoAtaque == "Fire" && (tipoDefensor1 == "Fire" || tipoDefensor2 == "Fire" || tipoDefensor1 == "Water" || tipoDefensor2 == "Water" || tipoDefensor1 == "Rock" || tipoDefensor2 == "Rock" || tipoDefensor1 == "Dragon" || tipoDefensor2 == "Dragon"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Fire" && (tipoDefensor1 == "Grass" || tipoDefensor2 == "Grass" || tipoDefensor1 == "Ice" || tipoDefensor2 == "Ice" || tipoDefensor1 == "Bug" || tipoDefensor2 == "Bug" || tipoDefensor1 == "Steel" || tipoDefensor2 == "Steel"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Water" && (tipoDefensor1 == "Water" || tipoDefensor2 == "Water" || tipoDefensor1 == "Grass" || tipoDefensor2 == "Grass" || tipoDefensor1 == "Dragon" || tipoDefensor2 == "Dragon"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Water" && (tipoDefensor1 == "Fire" || tipoDefensor2 == "Fire" || tipoDefensor1 == "Ground" || tipoDefensor2 == "Ground" || tipoDefensor1 == "Rock" || tipoDefensor2 == "Rock"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Electric" && (tipoDefensor1 == "Electric" || tipoDefensor2 == "Electric" || tipoDefensor1 == "Grass" || tipoDefensor2 == "Grass" || tipoDefensor1 == "Dragon" || tipoDefensor2 == "Dragon"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Electric" && (tipoDefensor1 == "Water" || tipoDefensor2 == "Water" || tipoDefensor1 == "Flying" || tipoDefensor2 == "Flying"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Electric" && (tipoDefensor1 == "Ground" || tipoDefensor2 == "Ground"))
            {
                multiplicador = 0m;
            }
            else if (tipoAtaque == "Grass" && (tipoDefensor1 == "Fire" || tipoDefensor2 == "Fire" || tipoDefensor1 == "Grass" || tipoDefensor2 == "Grass" || tipoDefensor1 == "Poison" || tipoDefensor2 == "Poison" || tipoDefensor1 == "Flying" || tipoDefensor2 == "Flying" || tipoDefensor1 == "Bug" || tipoDefensor2 == "Bug" || tipoDefensor1 == "Dragon" || tipoDefensor2 == "Dragon" || tipoDefensor1 == "Steel" || tipoDefensor2 == "Steel"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Grass" && (tipoDefensor1 == "Water" || tipoDefensor2 == "Water" || tipoDefensor1 == "Ground" || tipoDefensor2 == "Ground" || tipoDefensor1 == "Rock" || tipoDefensor2 == "Rock"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Ice" && (tipoDefensor1 == "Fire" || tipoDefensor2 == "Fire" || tipoDefensor1 == "Water" || tipoDefensor2 == "Water" || tipoDefensor1 == "Ice" || tipoDefensor2 == "Ice" || tipoDefensor1 == "Steel" || tipoDefensor2 == "Steel"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Ice" && (tipoDefensor1 == "Grass" || tipoDefensor2 == "Grass" || tipoDefensor1 == "Ground" || tipoDefensor2 == "Ground" || tipoDefensor1 == "Flying" || tipoDefensor2 == "Flying" || tipoDefensor1 == "Dragon" || tipoDefensor2 == "Dragon"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Fightig" && (tipoDefensor1 == "Poison" || tipoDefensor2 == "Poison" || tipoDefensor1 == "Flying" || tipoDefensor2 == "Flying" || tipoDefensor1 == "Psychic" || tipoDefensor2 == "Psychic" || tipoDefensor1 == "Bug" || tipoDefensor2 == "Bug" || tipoDefensor1 == "Fairy" || tipoDefensor2 == "Fairy"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Fightig" && (tipoDefensor1 == "Normal" || tipoDefensor2 == "Normal" || tipoDefensor1 == "Ice" || tipoDefensor2 == "Ice" || tipoDefensor1 == "Rock" || tipoDefensor2 == "Rock" || tipoDefensor1 == "Steel" || tipoDefensor2 == "Steel"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Fighting" && (tipoDefensor1 == "Ghost" || tipoDefensor2 == "Ghost"))
            {
                multiplicador = 0m;
            }
            else if (tipoAtaque == "Poison" && (tipoDefensor1 == "Poison" || tipoDefensor2 == "Poison" || tipoDefensor1 == "Ground" || tipoDefensor2 == "Ground" || tipoDefensor1 == "Rock" || tipoDefensor2 == "Rock" || tipoDefensor1 == "Ghost" || tipoDefensor2 == "Ghost"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Poison" && (tipoDefensor1 == "Grass" || tipoDefensor2 == "Grass" || tipoDefensor1 == "Fairy" || tipoDefensor2 == "Fairy"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Poison" && (tipoDefensor1 == "Steel" || tipoDefensor2 == "Steel"))
            {
                multiplicador = 0m;
            }
            else if (tipoAtaque == "Ground" && (tipoDefensor1 == "Grass" || tipoDefensor2 == "Grass" || tipoDefensor1 == "Bug" || tipoDefensor2 == "Bug"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Ground" && (tipoDefensor1 == "Fire" || tipoDefensor2 == "Fire" || tipoDefensor1 == "Electric" || tipoDefensor2 == "Electric" || tipoDefensor1 == "Poison" || tipoDefensor2 == "Poison" || tipoDefensor1 == "Rock" || tipoDefensor2 == "Rock" || tipoDefensor1 == "Steel" || tipoDefensor2 == "Steel"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Ground" && (tipoDefensor1 == "Flying" || tipoDefensor2 == "Flying"))
            {
                multiplicador = 0m;
            }
            else if (tipoAtaque == "Flying" && (tipoDefensor1 == "Electric" || tipoDefensor2 == "Electric" || tipoDefensor1 == "Rock" || tipoDefensor2 == "Rock" || tipoDefensor1 == "Steel" || tipoDefensor2 == "Steel"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Flying" && (tipoDefensor1 == "Grass" || tipoDefensor2 == "Grass" || tipoDefensor1 == "Fighting" || tipoDefensor2 == "Fighting" || tipoDefensor1 == "Bug" || tipoDefensor2 == "Bug"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Psychic" && (tipoDefensor1 == "Psychic" || tipoDefensor2 == "Psychic" || tipoDefensor1 == "Steel" || tipoDefensor2 == "Steel"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Psychic" && (tipoDefensor1 == "Fighting" || tipoDefensor2 == "Fighting" || tipoDefensor1 == "Poison" || tipoDefensor2 == "Poison"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Bug" && (tipoDefensor1 == "Fire" || tipoDefensor2 == "Fire" || tipoDefensor1 == "Fighting" || tipoDefensor2 == "Fighting" || tipoDefensor1 == "Poison" || tipoDefensor2 == "Poison" || tipoDefensor1 == "Flying" || tipoDefensor2 == "Flying" || tipoDefensor1 == "Ghost" || tipoDefensor2 == "Ghost" || tipoDefensor1 == "Steel" || tipoDefensor2 == "Steel"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Bug" && (tipoDefensor1 == "Grass" || tipoDefensor2 == "Grass" || tipoDefensor1 == "Psychic" || tipoDefensor2 == "Psychic" || tipoDefensor1 == "Fairy" || tipoDefensor2 == "Fairy"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Rock" && (tipoDefensor1 == "Fighting" || tipoDefensor2 == "Fighting" || tipoDefensor1 == "Ground" || tipoDefensor2 == "Ground" || tipoDefensor1 == "Steel" || tipoDefensor2 == "Steel"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Rock" && (tipoDefensor1 == "Fire" || tipoDefensor2 == "Fire" || tipoDefensor1 == "Ice" || tipoDefensor2 == "Ice" || tipoDefensor1 == "Flying" || tipoDefensor2 == "Flying" || tipoDefensor1 == "Bug" || tipoDefensor2 == "Bug"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Ghost" && (tipoDefensor1 == "Normal" || tipoDefensor2 == "Normal"))
            {
                multiplicador = 0m;
            }
            else if (tipoAtaque == "Ghost" && (tipoDefensor1 == "Psychic" || tipoDefensor2 == "Psychic" || tipoDefensor1 == "Ghost" || tipoDefensor2 == "Ghost"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Dragon" && (tipoDefensor1 == "Steel" || tipoDefensor2 == "Steel"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Dragon" && (tipoDefensor1 == "Dragon" || tipoDefensor2 == "Dragon"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Fairy" && (tipoDefensor1 == "Fighting" || tipoDefensor2 == "Fighting" || tipoDefensor1 == "Dragon" || tipoDefensor2 == "Dragon"))
            {
                multiplicador = 2m;
            }
            else if (tipoAtaque == "Fairy" && (tipoDefensor1 == "Fire" || tipoDefensor2 == "Fire" || tipoDefensor1 == "Poison" || tipoDefensor2 == "Poison" || tipoDefensor1 == "Steel" || tipoDefensor2 == "Steel"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Steel" && (tipoDefensor1 == "Fire" || tipoDefensor2 == "Fire" || tipoDefensor1 == "Water" || tipoDefensor2 == "Water" || tipoDefensor1 == "Electric" || tipoDefensor2 == "Electric" || tipoDefensor1 == "Steel" || tipoDefensor2 == "Steel"))
            {
                multiplicador = 0.5m;
            }
            else if (tipoAtaque == "Steel" && (tipoDefensor1 == "Ice" || tipoDefensor2 == "Ice" || tipoDefensor1 == "Rock" || tipoDefensor2 == "Rock" || tipoDefensor1 == "Fairy" || tipoDefensor2 == "Fairy"))
            {
                multiplicador = 2m;
            }
            else
            {
                multiplicador = 1m;
            }

            return multiplicador;
        }

        // Método para aplicar el efecto de un ataque
        public void AplicarEfectoAtaque(int indiceAtaque)
        {
            // Se obtiene el pokemon activo del atacante
            Pokemon atacante = (turno == 1) ? pokemonActivo1 : pokemonActivo2;
            Pokemon defensor = (turno == 1) ? pokemonActivo2 : pokemonActivo1;

            // Se obtiene el ataque seleccionado por el atacante
            Ataque ataque = atacante.getAtaques()[indiceAtaque];

            // Se cambia el estado del pokemon defensor según el efecto del ataque
            defensor.setEstado(ataque.getEfecto());
        }

        // Método para aplicar el efecto de un estado alterado
        public void AplicarEfectoEstado()
        {
            // Se obtiene el pokemon activo del turno
            Pokemon pokemon = (turno == 1) ? pokemonActivo1 : pokemonActivo2;

            // Se verifica si el pokemon tiene un estado alterado
            if (pokemon.getEstado() != "Ninguno")
            {
                // Se aplica el efecto del estado alterado
                switch (pokemon.getEstado())
                {
                    case "Envenenado": // Si el estado es envenenado se le resta 5 de vida al pokemon
                        pokemon.setVida(pokemon.getVida() - 5);
                        break;
                    case "Paralisis": // Si el estado es paralisis se le reduce la velocidad a la mitad
                        Random rnd = new Random(); // Se crea un objeto de la clase Random
                        if (rnd.Next(0, 100) < 20) // Se genera un número aleatorio entre el 0 y el 100
                        {
                            pokemon.setAtaque(pokemon.getAtaque() / 2); // Si el número es menor a 20 se reduce el ataque a la mitad
                        }
                        break;
                    case "Dormido": // Si el estado es dormido se le reduce la defensa a la mitad
                        Random rnd2 = new Random();
                        if (rnd2.Next(0, 100) < 50) // Se genera un número aleatorio entre el 0 y el 100
                        {
                            pokemon.setEstado("Ninguno"); // Si el número es menor a 50 se despierta el pokemon
                        }
                        else
                        {
                            pokemon.setDefensa(pokemon.getDefensa() / 2); // Si el número es mayor o igual a 50 se reduce la defensa a la mitad
                        }
                        break;
                }
            }
        }

        // Método para cambiar pokemon activo
        public void CambiarPokemon(int numeroPokemon)
        {
            // Se obtiene el pokemon seleccionado por el entrenador
            Pokemon nuevoPokemon = getEntrenadorTurno().getPokemones().buscar(numeroPokemon);

            // Se cambia el pokemon activo
            if (turno == 1)
            {
                pokemonActivo1 = nuevoPokemon;
            }
            else
            {
                pokemonActivo2 = nuevoPokemon;
            }

            // Se cambia el turno
            cambiarTurno();
        }

        // Método para usar un item
        public void UsarItem(PilaItems itemSeleccionado)
        {
            // Se obtiene el entrenador en turno
            Entrenador entrenador = getEntrenadorTurno();

            // Se busca la pilas de items seleccionada por el entrenador
            PilaItems item = entrenador.getItems().buscar(itemSeleccionado);

            // Se verifica que la pila del item seleccionado no esté vacía
            if (!item.estaVacia())
            {
                // Se obtiene el item de la pila
                Item itemUsado = item.pop();

                // Se verifica el tipo de item
                switch (itemUsado.getNombre())
                {
                    case "Poción": // Si el item es una poción se le suma 20 de vida al pokemon activo
                        if (turno == 1)
                        {
                            pokemonActivo1.setVida(pokemonActivo1.getVida() + 20);
                        }
                        else
                        {
                            pokemonActivo2.setVida(pokemonActivo2.getVida() + 20);
                        }
                        break;
                    case "Superpoción": // Si el item es una poción máxima se le suma 50 de vida al pokemon activo
                        if (turno == 1)
                        {
                            pokemonActivo1.setVida(pokemonActivo1.getVida() + 50);
                        }
                        else
                        {
                            pokemonActivo2.setVida(pokemonActivo2.getVida() + 50);
                        }
                        break;
                    case "Hiperpoción": // Si el item es un revivir se revive al pokemon activo
                        if (turno == 1)
                        {
                            pokemonActivo1.setVida(pokemonActivo1.getVida() + 200);
                        }
                        else
                        {
                            pokemonActivo2.setVida(pokemonActivo2.getVida() + 200);
                        }
                        break;
                    case "Antiparálisis":
                        // Si el item es una antiparalisis se cura la paralisis del pokemon activo
                        if (turno == 1)
                        {
                            pokemonActivo1.setEstado("Ninguno");
                            pokemonActivo1.setAtaque(pokemonActivo1.getAtaque() * 2);
                        }
                        else
                        {
                            pokemonActivo2.setEstado("Ninguno");
                            pokemonActivo2.setAtaque(pokemonActivo2.getAtaque() * 2);
                        }
                        break;
                    case "Antídoto":
                        // Si el item es un antídoto se cura el envenenamiento del pokemon activo
                        if (turno == 1)
                        {
                            pokemonActivo1.setEstado("Ninguno");
                        }
                        else
                        {
                            pokemonActivo2.setEstado("Ninguno");
                        }
                        break;
                    case "Despertar":
                        // Si el item es un despertar se despierta al pokemon activo
                        if (turno == 1)
                        {
                            pokemonActivo1.setEstado("Ninguno");
                            pokemonActivo1.setDefensa(pokemonActivo1.getDefensa() * 2);
                        }
                        else
                        {
                            pokemonActivo2.setEstado("Ninguno");
                            pokemonActivo2.setDefensa(pokemonActivo2.getDefensa() * 2);
                        }
                        break;
                    case "Cura Total":
                        // Si el item es una cura total se cura cualquier estado alterado del pokemon activo y reestablece su vida
                        if (turno == 1)
                        {
                            pokemonActivo1.setEstado("Ninguno");
                            pokemonActivo1.setVida(pokemonActivo1.getVidaMax());
                        }
                        else
                        {
                            pokemonActivo2.setEstado("Ninguno");
                            pokemonActivo2.setVida(pokemonActivo2.getVidaMax());
                        }
                        break;
                    case "Max Poción":
                        // Si el item es una poción máxima que reestablece la vida del pokemon activo
                        if (turno == 1)
                        {
                            pokemonActivo1.setVida(pokemonActivo1.getVidaMax());
                        }
                        else
                        {
                            pokemonActivo2.setVida(pokemonActivo2.getVidaMax());
                        }
                        break;
                    case "Precisión X":
                        // Si el item es una poción máxima se le suma 50 de vida al pokemon activo
                        if (turno == 1)
                        {
                            decimal precision = pokemonActivo1.getAtaque() * 0.22m;
                            pokemonActivo1.setAtaque((int) Math.Round(pokemonActivo1.getAtaque() + precision));
                        }
                        else
                        {
                            decimal precision = pokemonActivo2.getAtaque() * 0.22m;
                            pokemonActivo2.setAtaque((int)Math.Round(pokemonActivo2.getAtaque() + precision));
                        }
                        break;
                }
            }

            // Se cambia el turno
            cambiarTurno();
        }
    }
}
