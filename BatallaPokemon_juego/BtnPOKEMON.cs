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
using static BatallaPokemon_juego.Form_BATALLA;

namespace BatallaPokemon_juego
{
    public partial class BtnPOKEMON : Form
    {
        public BtnPOKEMON()
        {
            InitializeComponent();
        }

        private void BotonesPokemo()
        {
            panelBtnPokemones.Controls.Clear();

            // Se obtiene la información del jugador en turno
            Entrenador jugadorTurno = InfoBatalla.batalla.getEntrenadorTurno();

            // Se obtiene la lista de pokemones del jugador en turno
            ListaCircularDE pokemones = jugadorTurno.getPokemones();

            // Se recorre la lista de pokemones
            pokemones.recorrer((Pokemon pokemon) =>
            {
                // Se crea un botón para cada pokemon
                Button btnPokemon = new Button();
                btnPokemon.Text = pokemon.getNombre();
                btnPokemon.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                btnPokemon.ForeColor = Color.White;
                btnPokemon.TextAlign = ContentAlignment.MiddleCenter;
                btnPokemon.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnPokemon.Width = 150;
                btnPokemon.Height = 50;
                string rutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
                btnPokemon.BackgroundImage = Image.FromFile(Path.Combine(rutaProyecto, "Resources", $"{pokemon.getImagen()}.png"));
                btnPokemon.BackgroundImageLayout = ImageLayout.Center;
                btnPokemon.Cursor = Cursors.Hand; // Se establece el cursor del botón

                // Se agrega el evento click al botón
                btnPokemon.Click += (s, e) =>
                {
                    // Se cambia el pokemon en turno al presionar el botón
                    InfoBatalla.batalla.CambiarPokemon(pokemon.getNumero());

                    // Se muestra mensaje mostrando que pokemon se seleccionó
                    MessageBox.Show("Se seleccionó el pokemon " + pokemon.getNombre());

                    // Se cierra la ventana
                    this.Close();
                };

                panelBtnPokemones.Controls.Add(btnPokemon);
            });
        }

        private void BtnPOKEMON_Load(object sender, EventArgs e)
        {
            // Se crean los botones de los pokemones
            BotonesPokemo();
        }
    }
}
