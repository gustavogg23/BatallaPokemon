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
    public partial class BC_BATALLA : Form
    {
        private int incremento = 100;
        private int incrementoInicial = 0;
        private SoundPlayer player = new SoundPlayer(Properties.Resources.WhatsApp_Video_2024_03_17_at_3_45_50_PM);

        public BC_BATALLA()
        {
            InitializeComponent();
            Load += BC_BATALLA_Load;
        }

        private void BC_BATALLA_Load(object sender, EventArgs e)
        {
            IniciarCarga();
        }
        private void IniciarCarga()
        {
            player.Play(); //para iniciar la reproduccion

            // Se llama al método para agregar los items a la lista de items del entrenador
            AgregarItems();

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
                    this.Hide(); //para cerrar la ventana de carga

                    Form_BATALLA formBATALLA = new Form_BATALLA();
                    formBATALLA.ShowDialog();
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

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Método para agregar los items a la lista de items del entrenador para poder usar en batalla
        private void AgregarItems()
        {
            // Se crea cada objeto Item con su nombre y cantidad
            Item pocion = new Item("Poción", 3);
            Item superPocion = new Item("Superpoción", 2);
            Item hiperPocion = new Item("Hiperpoción", 1);
            Item antiparalisis = new Item("Antiparálisis", 3);
            Item antidoto = new Item("Antídoto", 2);
            Item despertar = new Item("Despertar", 3);
            Item curaTotal = new Item("Cura Total", 1);
            Item maxPocion = new Item("Max Poción", 1);
            Item precisionX = new Item("Precisión X", 6);

            // Se crea una pila para cada item
            PilaItems pilaPocion = new PilaItems();
            PilaItems pilaSuperPocion = new PilaItems();
            PilaItems pilaHiperPocion = new PilaItems();
            PilaItems pilaAntiparalisis = new PilaItems();
            PilaItems pilaAntidoto = new PilaItems();
            PilaItems pilaDespertar = new PilaItems();
            PilaItems pilaCuraTotal = new PilaItems();
            PilaItems pilaMaxPocion = new PilaItems();
            PilaItems pilaPrecisionX = new PilaItems();

            // Se agrega cada item a su respectiva pila
            for (int i = 0; i < 3; i++)
            {
                pilaPocion.push(pocion);
                pilaAntiparalisis.push(antiparalisis);
                pilaDespertar.push(despertar);
            }

            for (int i = 0; i < 2; i++)
            {
                pilaSuperPocion.push(superPocion);
                pilaAntidoto.push(antidoto);
            }

            pilaHiperPocion.push(hiperPocion);
            pilaCuraTotal.push(curaTotal);
            pilaMaxPocion.push(maxPocion);

            for (int i = 0; i < 6; i++)
            {
                pilaPrecisionX.push(precisionX);
            }

            // Se agregan las pilas de items a la lista de items de los jugadores
            LOGIN.DatosJugadores.player1.agregarItem(pilaPocion);
            LOGIN.DatosJugadores.player1.agregarItem(pilaSuperPocion);
            LOGIN.DatosJugadores.player1.agregarItem(pilaHiperPocion);
            LOGIN.DatosJugadores.player1.agregarItem(pilaAntiparalisis);
            LOGIN.DatosJugadores.player1.agregarItem(pilaAntidoto);
            LOGIN.DatosJugadores.player1.agregarItem(pilaDespertar);
            LOGIN.DatosJugadores.player1.agregarItem(pilaCuraTotal);
            LOGIN.DatosJugadores.player1.agregarItem(pilaMaxPocion);
            LOGIN.DatosJugadores.player1.agregarItem(pilaPrecisionX);

            LOGIN.DatosJugadores.player2.agregarItem(pilaPocion);
            LOGIN.DatosJugadores.player2.agregarItem(pilaSuperPocion);
            LOGIN.DatosJugadores.player2.agregarItem(pilaHiperPocion);
            LOGIN.DatosJugadores.player2.agregarItem(pilaAntiparalisis);
            LOGIN.DatosJugadores.player2.agregarItem(pilaAntidoto);
            LOGIN.DatosJugadores.player2.agregarItem(pilaDespertar);
            LOGIN.DatosJugadores.player2.agregarItem(pilaCuraTotal);
            LOGIN.DatosJugadores.player2.agregarItem(pilaMaxPocion);
            LOGIN.DatosJugadores.player2.agregarItem(pilaPrecisionX);
        }
    }
}
