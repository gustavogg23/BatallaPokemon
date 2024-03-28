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
    }
}
