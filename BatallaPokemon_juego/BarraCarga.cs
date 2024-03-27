using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //PARA PODER UTILIZAR SONIDOS DENTRO DEL PROGRAMA

namespace BatallaPokemon_juego
{
    public partial class BarraCarga : Form
    {
        // Con esta clase se puede acceder a las listas que se creen desde cualquier parte del programa
        public static class DatosListas
        {
            public static ListaAtaques listaAtaques = new ListaAtaques();
            public static ListaPokemones listaPokemones = new ListaPokemones();
            public static ListaJugadores listaJugadores = new ListaJugadores();
        }

        public event EventHandler CargaCompleta; //evento que permite indicar que la carga ha llegado al 100%

        private int incremento = 100;
        private int incrementoInicial = 0;
        private SoundPlayer player = new SoundPlayer(Properties.Resources.WhatsApp_Video_2024_03_17_at_3_45_50_PM);

        public BarraCarga()
        {
            InitializeComponent();
            Load += BarraCarga_Load;
        }

        private void BarraCarga_Load(object sender, EventArgs e)
        {
            IniciarCarga();
        }

        private void IniciarCarga()
        {
            player.Play(); //para iniciar la reproduccion

            // Se cargan los ataques, pokemones y jugadores
            CargarAtaques();
            CargarPokemones();
            CargarJugadores();

            Timer timer = new Timer();
            timer.Interval = 100; //Intervalo de actualizacion de la barra
            timer.Tick += (s, e) =>
            {
                if (incrementoInicial < incremento)
                {
                    incrementoInicial++;
                    ActualizarProgreso(incrementoInicial, incremento);
                }
                else
                {
                    player.Stop();//para detener la reproduccion al cerrar el formulario
                    timer.Stop();

                    CargaCompleta?.Invoke(this, EventArgs.Empty); //para llamar el evento de carga completa
                    Close(); //para cerrar la ventana de carga
                }
            };
            timer.Start();
        }

        private void ActualizarProgreso(int incrementoInicial, int incremento)
        {
            int porcentaje = (int)Math.Round((double)incrementoInicial / incremento * 100); //para calcular el porcentaje de carga

            progressBar1.Value = incrementoInicial; //para actualizar la barra de carga y el label que muestra el porcentaje
            label1.Text = $"Cargando...{porcentaje}%";
        }

        // Método para cargar los ataques desde el archivo Ataques.txt
        private void CargarAtaques()
        {
            Archivo archivo = new Archivo("Ataques.txt"); // Se crea un objeto de la clase Archivo
            string[] lineas = archivo.Leer(); // Se lee el archivo y se guarda en un arreglo de strings
            foreach (string linea in lineas) // Se recorre el arreglo de strings
            {
                string[] datos = linea.Split(','); // Se separan los datos de la línea por comas
                Ataque ataque = new Ataque(datos[0], datos[1], datos[2]); // Se crea un objeto de la clase Ataque con los datos de la línea
                DatosListas.listaAtaques.agregar(ataque); // Se agrega el ataque a la lista de ataques
            } 
        }

        // Método para cargar los pokemones desde el archivo Pokemones.txt
        private void CargarPokemones()
        {
            Archivo archivo = new Archivo("Pokemones.txt"); 
            string[] lineas = archivo.Leer(); 
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');
                if (datos.Length < 17) // Se verifica que la línea tenga el formato correcto
                {
                    Console.WriteLine($"Error: la línea '{linea}' no tiene el formato correcto."); // Se muestra un mensaje de error
                    continue; // Se salta a la siguiente iteración del ciclo
                }
                Ataque[] ataques = new Ataque[4]; // Se crea un arreglo de ataques
                for (int i = 0; i < 4; i++) // Se recorren los ataques
                {
                    ataques[i] = DatosListas.listaAtaques.buscar(datos[13 + i]); // Se busca el ataque en la lista de ataques y se guarda en el arreglo
                } 
                Pokemon pokemon = new Pokemon(int.Parse(datos[0]), datos[1], datos[2], datos[3], int.Parse(datos[4]), int.Parse(datos[5]), int.Parse(datos[6]), int.Parse(datos[7]), int.Parse(datos[8]), int.Parse(datos[9]), datos[10], datos[11], datos[12], ataques); // Se crea un objeto de la clase Pokemon con los datos de la línea
                DatosListas.listaPokemones.agregar(pokemon); // Se agrega el pokemon a la lista de pokemones
            }
        }

        // Método para cargar los jugadores desde el archivo Jugadores.txt
        private void CargarJugadores()
        {
            Archivo archivo = new Archivo("Jugadores.txt");
            string[] lineas = archivo.Leer(); 
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');
                Entrenador entrenador = new Entrenador(datos[0], int.Parse(datos[1])); // Se crea un objeto de la clase Entrenador con los datos de la línea
                DatosListas.listaJugadores.agregar(entrenador); // Se agrega el entrenador a la lista de jugadores
            }
        }
    }
}