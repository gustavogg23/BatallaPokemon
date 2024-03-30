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
    public partial class SelectorPokemon : Form
    {
        private int contadorPokemones = 0;
        public SelectorPokemon()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionPokemones()) // Se verifica que los dos jugadores hayan seleccionado 6 pokemones cada uno
            {
                this.Visible = false; //permite ocultar el form de "SelectorPokemon" para dar paso al FORM "BC_BATALLA"

                BC_BATALLA formBC_BATALLA = new BC_BATALLA();
                formBC_BATALLA.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ambos jugadores deben seleccionar 6 pokemones");
                return;
            }
        }

        // Método para validar que ambos jugadores hayan seleccionado 6 pokemones
        private Boolean ValidarSeleccionPokemones()
        {
            if (LOGIN.DatosJugadores.player1.getPokemones().getTamano() == 6 && LOGIN.DatosJugadores.player2.getPokemones().getTamano() == 6) // Si ambos jugadores han seleccionado 6 pokemones
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void panelPokemones_Paint(object sender, PaintEventArgs e) // NOTA: Este método no se utiliza NO BORRAR
        {
      
        }

        private void CrearBotonesPokemones()
        {
            panelPokemones.Controls.Clear();

            for (int i = 1; i <= 151; i++)
            {
                Pokemon pokemon = BarraCarga.DatosListas.listaPokemones.buscar(i); //busca el pokemon en la lista de pokemones según su número

                Button btnPokemon = new Button(); // Se crea un nuevo botón
                btnPokemon.Size = new Size(55, 55); // Se establece el tamaño del botón
                btnPokemon.FlatStyle = FlatStyle.Flat; // Se establece el estilo del botón
                btnPokemon.BackColor = Color.Transparent; // Se establece el color de fondo del botón
                try
                {
                    string rutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
                    btnPokemon.BackgroundImage = Image.FromFile(Path.Combine(rutaProyecto, "Resources", $"{pokemon.getImagen()}.png"));
                    //btnPokemon.BackgroundImage = Image.FromFile($"C:/Users/gusta/Documentos/UNIMAR/TRIMESTRE V/Programación 2/BatallaPokemon/BatallaPokemon_juego/Resources/{pokemon.getImagen()}.png"); // Se establece la imagen de fondo del botón
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                btnPokemon.BackgroundImageLayout = ImageLayout.Stretch; // Se establece el diseño de la imagen de fondo del botón
                btnPokemon.FlatAppearance.BorderSize = 0; // Se establece el tamaño del borde del botón
                btnPokemon.FlatAppearance.MouseDownBackColor = Color.Transparent; // Se establece el color de fondo del botón cuando se presiona
                btnPokemon.FlatAppearance.MouseOverBackColor = Color.Transparent; // Se establece el color de fondo del botón cuando el mouse pasa por encima
                btnPokemon.Cursor = Cursors.Hand; // Se establece el cursor del botón
                btnPokemon.Margin = new Padding(6); // Se establece el margen del botón

                // Se establece el evento click del botón
                btnPokemon.Click += (s, e) => { Entrenador entrenador = DeterminarEntrenador();
                    if (entrenador.getPokemones().getTamano() < 6)
                    {
                        if (!entrenador.getPokemones().estaEnLista(pokemon.getNumero()))
                        {
                            entrenador.agregarPokemon(pokemon);
                            contadorPokemones++;
                            MessageBox.Show($"{entrenador.getNombre()} ha seleccionado a {pokemon.getNombre()}");
                        }
                        else
                        {
                            MessageBox.Show("Ya has seleccionado a este pokémon");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Ya has seleccionado 6 pokemones");
                    }
                }; 
                panelPokemones.Controls.Add(btnPokemon); // Se agrega el botón al panel de pokemones
            }
        }

        // Método para determinar a cuál jugador le toca elegir un pokémon
        private Entrenador DeterminarEntrenador()
        {
            Entrenador entrenador;
            if (contadorPokemones % 2 == 0)
            {
                entrenador = LOGIN.DatosJugadores.player1;
            }
            else
            {
                entrenador = LOGIN.DatosJugadores.player2;
            }

            return entrenador;
        }

        private void SelectorPokemon_Load(object sender, EventArgs e)
        {
            CrearBotonesPokemones();
        }
    }
}
