using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace BatallaPokemon_juego
{
    public partial class LOGIN : Form
    {
        public static class DatosJugadores // Clase para guardar los datos de los jugadores y poder acceder a ellos desde cualquier parte del programa
        {
            public static Entrenador player1;
            public static Entrenador player2;
        }
        public LOGIN()
        {
            InitializeComponent();
        }

        private void jugador1_Enter(object sender, EventArgs e) //metodo para que al hacer click sobre el cuadro de "CORREO ELECTRONICO" se quite la palabra y aparezca el cursor
        {
            if (jugador1.Text == "JUGADOR 1")
            {
                jugador1.Text = "";
                jugador1.ForeColor = Color.Black;
            }

        }

        private void jugador1_Leave(object sender, EventArgs e)
        {
            if (jugador1.Text == "")
            {
                jugador1.Text = "JUGADOR 1";
                jugador1.ForeColor = Color.DimGray;
            }
        }

        private void jugador2_Enter(object sender, EventArgs e)
        {
            if (jugador2.Text == "JUGADOR 2")
            {
                jugador2.Text = "";
                jugador2.ForeColor = Color.Black;
            }
        }

        private void jugador2_Leave(object sender, EventArgs e)
        {
            if (jugador2.Text == "")
            {
                jugador2.Text = "JUGADOR 2";
                jugador2.ForeColor = Color.DimGray;
            }
        }

        private void acceder_Click(object sender, EventArgs e) //validaciones de nombre de usuario al hacer click en "ACCEDER" 
        {
            string username1 = jugador1.Text;
            string username2 = jugador2.Text;

            // Se verifican que los campos estén llenos
            if (!ValidarCampos())
            {
                return;
            }

            // Se verifica que ambos jugadores sean diferentes
            if (!ValidarJugadores())
            {
                return;
            }

            // Se verifica que los nombres de usuario sean válidos
            if (!IsValidusername1(username1) || !IsValidusername2(username2))
            {
                MessageBox.Show("Los nombres de usuario deben tener entre 8 y 12 caracteres y solo pueden contener letras y números");
                return;
            }

            // Se verifica que los jugadores estén registrados
            if (!JugadorNoRegistrado(username1, username2))
            {
                MessageBox.Show("Uno o ambos jugadores no están registrados");
                return;
            }

            // Si se cumplen todas las validaciones, se guarda el nombre de usuario en una variable global
            DatosJugadores.player1 = BarraCarga.DatosListas.listaJugadores.buscar(username1);
            DatosJugadores.player2 = BarraCarga.DatosListas.listaJugadores.buscar(username2);

            // Se abre la ventana de selección de pokemones
            SelectorPokemon seleccionPokemon = new SelectorPokemon();
            seleccionPokemon.Show();
        }

        private bool IsValidusername1(string username1) //Metodo para validar que el usuario 1 pueda usar solo letras y numeros
        {
            string pattern = @"^[a-zA-Z0-9]{4,12}$";
            return Regex.IsMatch(username1, pattern);
        }

        private bool IsValidusername2(string username2) //Metodo para validar que el usuario 2 pueda usar solo letras y numeros
        {
            string pattern = @"^[a-zA-Z0-9]{4,12}$";
            return Regex.IsMatch(username2, pattern);
        }

        private void GuardarDatos_Jugadores(string username1, string username2) //Metodo para guardar los datos en un archivo de texto
        {
            Entrenador jugador1 = new Entrenador(username1, 0); // Se crea un nuevo entrenador con el nombre del jugador 1
            Entrenador jugador2 = new Entrenador(username2, 0); // Se crea un nuevo entrenador con el nombre del jugador 2

            BarraCarga.DatosListas.listaJugadores.agregar(jugador1); // Se agrega el jugador 1 a la lista de jugadores
            BarraCarga.DatosListas.listaJugadores.agregar(jugador2); // Se agrega el jugador 2 a la lista de jugadores

            Archivo archivo = new Archivo("Jugadores.txt"); // Se crea un nuevo objeto archivo
            string texto = jugador1.mostrarInfo() + "\n" + jugador2.mostrarInfo(); // Se crea un string con la información de los jugadores
            archivo.Escribir(texto); // Se escribe el string en el archivo
        }

        private void registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Se obtienen los nombres de usuario
            string username1 = jugador1.Text;
            string username2 = jugador2.Text;

            // Se verifican que los campos estén llenos
            if (!ValidarCampos())
            {
                return;
            }

            // Se verifica que ambos jugadores sean diferentes
            if (!ValidarJugadores())
            {
                return;
            }

            // Se verifica que los nombres de usuario sean válidos
            if (!IsValidusername1(username1) || !IsValidusername2(username2))
            {
                MessageBox.Show("Los nombres de usuario deben tener entre 8 y 12 caracteres y solo pueden contener letras y números");
                return;
            }

            // Se verifica que los jugadores no estén registrados
            if (JugadorYaRegistrado(username1, username2))
            {
                MessageBox.Show("Uno o ambos jugadores ya están registrados");
                return;
            }

            // Si se cumplen todas las validaciones, se guardan los datos de los jugadores
            GuardarDatos_Jugadores(username1, username2);
            MessageBox.Show("Los jugadores han sido registrados exitosamente");
        }

        private Boolean ValidarCampos() //Metodo para validar que los campos no esten vacios
        {
            if (jugador1.Text == "JUGADOR 1" || jugador2.Text == "JUGADOR 2")
            {
                MessageBox.Show("Por favor, llene todos los campos");
                return false;
            }
            return true;
        }

        private Boolean ValidarJugadores() //Metodo para validar que los jugadores no sean iguales
        {
            if (jugador1.Text == jugador2.Text)
            {
                MessageBox.Show("Los jugadores no pueden ser iguales");
                return false;
            }
            return true;
        }

        private Boolean JugadorYaRegistrado(string username1, string username2) //Metodo para verificar los jugadores esten registrados
        {
            ListaJugadores jugadores = BarraCarga.DatosListas.listaJugadores; // Se obtiene la lista de jugadores

            if (jugadores.existe(username1) || jugadores.existe(username2)) // Si el jugador 1 o el jugador 2 ya están registrados
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean JugadorNoRegistrado(string username1, string username2) //Metodo para validar que los jugadores no esten registrados
        {
            ListaJugadores jugadores = BarraCarga.DatosListas.listaJugadores; // Se obtiene la lista de jugadores

            if (jugadores.existe(username1) && jugadores.existe(username2)) // Si el jugador 1 o el jugador 2 no están registrados
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
