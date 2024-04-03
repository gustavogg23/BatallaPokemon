using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatallaPokemon_juego
{
    public partial class LOGIN_4 : Form
    {
        public static class DatosJugadores // Clase para guardar los datos de los jugadores y poder acceder a ellos desde cualquier parte del programa
        {
            public static Entrenador player1;
            public static Entrenador player2;
            public static Entrenador player3;
            public static Entrenador player4;
        }
        public LOGIN_4()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual y mostrar el menú de inicio
            this.Close();

            // Verificar si el formulario de inicio ya está creado
            inicio formInicio = Application.OpenForms["inicio"] as inicio;

            if (formInicio == null)
            {
                formInicio = new inicio();
            }

            // Mostrar el formulario de inicio sin la barra de carga
            formInicio.Show();
        }

        //JUGADOR 1
        private void J14_Enter(object sender, EventArgs e)
        {
            if (J14.Text == "JUGADOR 1")
            {
                J14.Text = "";
                J14.ForeColor = Color.Black;
            }
        }

        private void J14_Leave(object sender, EventArgs e)
        {
            if (J14.Text == "")
            {
                J14.Text = "JUGADOR 1";
                J14.ForeColor = Color.DimGray;
            }
        }

        //JUGADOR 2
        private void J24_Enter(object sender, EventArgs e)
        {
            if (J24.Text == "JUGADOR 2")
            {
                J24.Text = "";
                J24.ForeColor = Color.Black;
            }
        }

        private void J24_Leave(object sender, EventArgs e)
        {
            if (J24.Text == "")
            {
                J24.Text = "JUGADOR 2";
                J24.ForeColor = Color.DimGray;
            }
        }

        //JUGADOR 3
        private void J34_Enter(object sender, EventArgs e)
        {
            if (J34.Text == "JUGADOR 3")
            {
                J34.Text = "";
                J34.ForeColor = Color.Black;
            }
        }

        private void J34_Leave(object sender, EventArgs e)
        {
            if (J34.Text == "")
            {
                J34.Text = "JUGADOR 3";
                J34.ForeColor = Color.DimGray;
            }
        }

        //JUGADOR 4
        private void J44_Enter(object sender, EventArgs e)
        {
            if (J44.Text == "JUGADOR 4")
            {
                J44.Text = "";
                J44.ForeColor = Color.Black;
            }
        }

        private void J44_Leave(object sender, EventArgs e)
        {
            if (J44.Text == "")
            {
                J44.Text = "JUGADOR 4";
                J44.ForeColor = Color.DimGray;
            }
        }

        private void AccederL4_Click(object sender, EventArgs e)
        {
            string username1 = J14.Text;
            string username2 = J24.Text;
            string username3 = J34.Text;
            string username4 = J44.Text;

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
            if (!IsValidusername1(username1) || !IsValidusername2(username2) || !IsValidusername3(username3) || !IsValidusername4(username4))
            {
                MessageBox.Show("Los nombres de usuario deben tener entre 8 y 12 caracteres y solo pueden contener letras y números");
                return;
            }

            // Se verifica que los jugadores estén registrados
            if (!JugadorNoRegistrado(username1, username2, username3, username4))
            {
                MessageBox.Show("Uno o ambos jugadores no están registrados");
                return;
            }

            // Si se cumplen todas las validaciones, se guarda el nombre de usuario en una variable global
            DatosJugadores.player1 = BarraCarga.DatosListas.listaJugadores.buscar(username1);
            DatosJugadores.player2 = BarraCarga.DatosListas.listaJugadores.buscar(username2);
            DatosJugadores.player3 = BarraCarga.DatosListas.listaJugadores.buscar(username3);
            DatosJugadores.player4 = BarraCarga.DatosListas.listaJugadores.buscar(username4);

            this.Visible = false; //permite ocultar el form de LOGIN para dar paso al FORM "SelectorPokemon"

            SelectorPokemon formSelectorP = new SelectorPokemon();
            formSelectorP.ShowDialog();

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
        private bool IsValidusername3(string username3) //Metodo para validar que el usuario 2 pueda usar solo letras y numeros
        {
            string pattern = @"^[a-zA-Z0-9]{4,12}$";
            return Regex.IsMatch(username3, pattern);
        }

        private bool IsValidusername4(string username4) //Metodo para validar que el usuario 2 pueda usar solo letras y numeros
        {
            string pattern = @"^[a-zA-Z0-9]{4,12}$";
            return Regex.IsMatch(username4, pattern);
        }
        private void GuardarDatos_Jugadores(string username1, string username2, string username3, string username4) //Metodo para guardar los datos en un archivo de texto
        {
            Entrenador J14 = new Entrenador(username1, 0); // Se crea un nuevo entrenador con el nombre del jugador 1
            Entrenador J24 = new Entrenador(username2, 0); // Se crea un nuevo entrenador con el nombre del jugador 2
            Entrenador J34 = new Entrenador(username3, 0); // Se crea un nuevo entrenador con el nombre del jugador 3
            Entrenador J44 = new Entrenador(username4, 0); // Se crea un nuevo entrenador con el nombre del jugador 4

            BarraCarga.DatosListas.listaJugadores.agregar(J14); // Se agrega el jugador 1 a la lista de jugadores
            BarraCarga.DatosListas.listaJugadores.agregar(J24); // Se agrega el jugador 2 a la lista de jugadores
            BarraCarga.DatosListas.listaJugadores.agregar(J34); // Se agrega el jugador 3 a la lista de jugadores
            BarraCarga.DatosListas.listaJugadores.agregar(J44); // Se agrega el jugador 4 a la lista de jugadores

            Archivo archivo = new Archivo("Jugadores.txt"); // Se crea un nuevo objeto archivo
            string texto = J14.mostrarInfo() + "\n" + J24.mostrarInfo() + "\n" + J34.mostrarInfo() + "\n" + J44.mostrarInfo(); // Se crea un string con la información de los jugadores
            archivo.Escribir(texto); // Se escribe el string en el archivo
        }

        private void RegistrarL4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Se obtienen los nombres de usuario
            string username1 = J14.Text;
            string username2 = J24.Text;
            string username3 = J34.Text;
            string username4 = J44.Text;

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
            if (!IsValidusername1(username1) || !IsValidusername2(username2) || !IsValidusername3(username3) || !IsValidusername4(username4))
            {
                MessageBox.Show("Los nombres de usuario deben tener entre 8 y 12 caracteres y solo pueden contener letras y números");
                return;
            }

            // Se verifica que los jugadores no estén registrados
            if (JugadorYaRegistrado(username1, username2, username3, username4))
            {
                MessageBox.Show("Uno o ambos jugadores ya están registrados");
                return;
            }

            // Si se cumplen todas las validaciones, se guardan los datos de los jugadores
            GuardarDatos_Jugadores(username1, username2, username3, username4);
            MessageBox.Show("Los jugadores han sido registrados exitosamente");
        }

        private Boolean ValidarCampos() //Metodo para validar que los campos no esten vacios
        {
            if (J14.Text == "JUGADOR 1" || J24.Text == "JUGADOR 2" || J34.Text == "JUGADOR 3" || J44.Text == "JUGADOR 4")
            {
                MessageBox.Show("Por favor, llene todos los campos");
                return false;
            }
            return true;
        }

        private Boolean ValidarJugadores() //Metodo para validar que los jugadores no sean iguales
        {
            if (J14.Text == J24.Text || J14.Text == J34.Text || J14.Text == J44.Text || J24.Text == J34.Text || J24.Text == J44.Text || J34.Text == J44.Text)
            {
                MessageBox.Show("Los jugadores no pueden ser iguales");
                return false;
            }
            return true;
        }

        private Boolean JugadorYaRegistrado(string username1, string username2, string username3, string username4) //Metodo para verificar los jugadores esten registrados
        {
            ListaJugadores jugadores = BarraCarga.DatosListas.listaJugadores; // Se obtiene la lista de jugadores

            if (jugadores.existe(username1) || jugadores.existe(username2) || jugadores.existe(username3) || jugadores.existe(username4)) // Si el jugador 1 o el jugador 2 ya están registrados
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean JugadorNoRegistrado(string username1, string username2, string username3, string username4) //Metodo para validar que los jugadores no esten registrados
        {
            ListaJugadores jugadores = BarraCarga.DatosListas.listaJugadores; // Se obtiene la lista de jugadores

            if (jugadores.existe(username1) && jugadores.existe(username2) && jugadores.existe(username3) && jugadores.existe(username4)) // Si el jugador 1 o el jugador 2 no están registrados
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