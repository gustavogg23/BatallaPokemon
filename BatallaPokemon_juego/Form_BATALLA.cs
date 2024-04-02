using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatallaPokemon_juego
{
    public partial class Form_BATALLA : Form
    {
        private Batalla batalla;
        public Form_BATALLA()
        {
            InitializeComponent();

            // Se inicializa la batalla
            batalla = new Batalla(LOGIN.DatosJugadores.player1, LOGIN.DatosJugadores.player2);
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form_BATALLA_Load(object sender, EventArgs e)
        {
            Random ImgRandom = new Random();
            int randomImagen = ImgRandom.Next(1, 7); //RANGO DE IMAGENES QUE ESTAN DISPONIBLES

            // SWITCH PARA ESTABLECER UNA IMAGEN DE FONDO, DEPENDIENDO DEL NUMERO ALEATORIO
            switch (randomImagen)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.FondoBatalla1;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.FondoBatalla2;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.FondoBatalla3;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources.FondoBatalla4;
                    break;
                case 5:
                    this.BackgroundImage = Properties.Resources.FondoBatalla5;
                    break;
                case 6:
                    this.BackgroundImage = Properties.Resources.FondoBatalla6;
                    break;
                case 7:
                    this.BackgroundImage = Properties.Resources.FondoBatalla7;
                    break;
                default:
                    this.BackgroundImage = Properties.Resources.FondoBatalla1; //IMAGEN POR DEFECTO POR SI NO HAY COINCIDENCIA CON LOS ANTERIORES 
                    break;
            }
            this.BackgroundImageLayout = ImageLayout.Stretch; //PARA AJUSTAR LAS IMAGENES AL TAMAÑO DEL FORMULARIO

            // Se obtienen los pokemones de cada jugador
            Pokemon pokemonJugador1 = batalla.getPokemonActivo1();
            Pokemon pokemonJugador2 = batalla.getPokemonActivo2();

            // Se establecen las imágenes de los pokemones de cada jugador
            try
            {
                string rutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
                pictureBox1.Image = Image.FromFile(Path.Combine(rutaProyecto, "Resources", $"{pokemonJugador1.getImagenEspalda()}.gif"));
                pictureBox2.Image = Image.FromFile(Path.Combine(rutaProyecto, "Resources", $"{pokemonJugador2.getImagenFrente()}.gif"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void luchar_Click(object sender, EventArgs e)
        {
            LUCHA FormLucha = new LUCHA();
            FormLucha.ShowDialog();
        }

        private void pokemon_Click(object sender, EventArgs e)
        {
            BtnPOKEMON FormBtnPOKEMON = new BtnPOKEMON();
            FormBtnPOKEMON.ShowDialog();
        }

        private void bolsa_Click(object sender, EventArgs e)
        {
            BOLSA FormBOLSA = new BOLSA();
            FormBOLSA.ShowDialog();
        }
    }
}
