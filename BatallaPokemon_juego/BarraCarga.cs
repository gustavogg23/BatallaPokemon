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
        private int incremento = 100;
        private int incrementoInicial = 0;
        private SoundPlayer player = new SoundPlayer(Properties.Resources.WhatsApp_Video_2024_03_17_at_3_45_50_PM); 
        
        public BarraCarga()
        {
            InitializeComponent();
            IniciarCarga();
            DatosUsuario();
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
                    this.Close(); //Para cerrar la ventana luego de terminar la carga
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

        private void DatosUsuario()
        {
            using (Form inputForm = new Form())
            {
                inputForm.Text = "Registro Usuario"; inputForm.Size = new Size(300, 250);
                Label labelUsername = new Label();
                labelUsername.Text = "Nombre:"; labelUsername.Location = new Point(10, 10);

                TextBox textBoxUsername = new TextBox(); textBoxUsername.Location = new Point(labelUsername.Right + 10, 10);

                Button buttonGuardar = new Button(); buttonGuardar.Text = "Guardar";
                buttonGuardar.Location = new Point(inputForm.Width / 2 - 50, textBoxUsername.Bottom + 20); buttonGuardar.Click += (sender, e) =>
                {
                    string Username = textBoxUsername.Text;
                    MessageBox.Show("Alumno registrado exitosamente");
                    inputForm.Close();
                };
            }
        }
    }
}
