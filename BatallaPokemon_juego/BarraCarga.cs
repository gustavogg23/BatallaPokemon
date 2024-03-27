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
        public static class DatosListas
        {
            public static ListaAtaques listaAtaques = new ListaAtaques();
            public static ListaPokemones listaPokemones = new ListaPokemones();
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

        private void CargarAtaques()
        {
            Archivo archivo = new Archivo("Ataques.txt");
            string[] lineas = archivo.Leer();
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');
                Ataque ataque = new Ataque(datos[0], datos[1], datos[2]);
                DatosListas.listaAtaques.agregar(ataque);
            }
        }

        private void CargarPokemones()
        {
            Archivo archivo = new Archivo("Pokemones.txt");
            string[] lineas = archivo.Leer();
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');
                Ataque[] ataques = new Ataque[4];
                for (int i = 0; i < 4; i++)
                {
                    ataques[i] = DatosListas.listaAtaques.buscar(datos[13 + i]);
                }
                Pokemon pokemon = new Pokemon(int.Parse(datos[0]), datos[1], datos[2], datos[3], int.Parse(datos[4]), int.Parse(datos[5]), int.Parse(datos[6]), int.Parse(datos[11]), int.Parse(datos[12]), int.Parse(datos[13]), datos[8], datos[9], datos[10], ataques);
                DatosListas.listaPokemones.agregar(pokemon);
            }
        }
    }
}