﻿using System;
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
    public partial class LUCHA : Form
    {
        public LUCHA()
        {
            InitializeComponent();
        }

        // Método para crear los botones de los ataques
        private void BotonesAtaques()
        {
            // Se obtiene la información del entrenador en turno
            Entrenador entrenadorTurno = InfoBatalla.batalla.getEntrenadorTurno();
            Entrenador entrenadorNoTurno = InfoBatalla.batalla.getEntrenadorNoTurno();

            // Se obtiene la información del pokemon en turno
            Pokemon pokemonTurno = (entrenadorTurno == InfoBatalla.batalla.getEntrenador1()) ? InfoBatalla.batalla.getPokemonActivo1() : InfoBatalla.batalla.getPokemonActivo2();
            Pokemon pokemonNoTurno = (entrenadorNoTurno == InfoBatalla.batalla.getEntrenador1()) ? InfoBatalla.batalla.getPokemonActivo1() : InfoBatalla.batalla.getPokemonActivo2();

            // Se recorre el arreglo de los ataques del pokemon
            for (int i = 0; i < pokemonTurno.getAtaques().Length; i++)
            {
                Ataque ataque = pokemonTurno.getAtaques()[i];

                // Se crea un botón para cada ataque
                Button btnAtaque = new Button();
                btnAtaque.Text = ataque.getNombre();
                btnAtaque.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                btnAtaque.ForeColor = Color.White;
                btnAtaque.TextAlign = ContentAlignment.MiddleCenter;
                btnAtaque.Width = 150;
                btnAtaque.Height = 50;

                int indiceAtaque = i;

                // Se agrega el evento click al botón
                btnAtaque.Click += async (s, e) =>
                {
                    // Se llama al método Atacar de la batalla al presionar el botón
                    InfoBatalla.batalla.atacar(indiceAtaque);

                    string rutaAtaque = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
                    string rutaImagenAtaque = Path.Combine(rutaAtaque, "Resources", $"{ataque.getImagen()}.gif");

                    Form_BATALLA.pictureBoxAtaque1.Image = Image.FromFile(rutaImagenAtaque);
                    Form_BATALLA.pictureBoxAtaque2.Image = Image.FromFile(rutaImagenAtaque);

                    if (entrenadorTurno == InfoBatalla.batalla.getEntrenador1())
                    {
                        Form_BATALLA.pictureBoxAtaque2.Visible = true;
                    }
                    else
                    {
                        Form_BATALLA.pictureBoxAtaque1.Visible = true;
                    }

                    await Task.Delay(2000);
                    Form_BATALLA.pictureBoxAtaque1.Visible = false;
                    Form_BATALLA.pictureBoxAtaque2.Visible = false;

                    // Se verifica si la vida del pokemon en turno es menor o igual a 0
                    if (pokemonNoTurno.getVida() <= 0)
                    {
                        MessageBox.Show("El pokemon " + pokemonNoTurno.getNombre() + " ha sido derrotado");
                        InfoBatalla.batalla.CambiarASiguientePokemon();
                        entrenadorNoTurno.getPokemones().eliminar(pokemonNoTurno.getNumero());

                        //this.Close(); // Cierra la ventana de la batalla

                        //inicio formInicio = Application.OpenForms["inicio"] as inicio;

                        //if (formInicio == null)
                        //{
                        //    formInicio = new inicio();
                        //}

                        //// Mostrar el formulario de inicio sin la barra de carga
                        //formInicio.Show();
                    }

                    // Se actualiza la información de los pokemones
                    AtaqueRealizado?.Invoke(this, EventArgs.Empty);

                    // Se cambia el turno
                    InfoBatalla.batalla.cambiarTurno();
                    this.Close();
                };

                // Se agrega el botón al panel
                panelAtaques.Controls.Add(btnAtaque);
            }
        }

        private void LUCHA_Load(object sender, EventArgs e)
        {
            // Se crean los botones de los ataques
            BotonesAtaques();
        }

        public delegate void AtaqueRealizadoEventHandler(object sender, EventArgs e);
        public event AtaqueRealizadoEventHandler AtaqueRealizado;
    }
}
