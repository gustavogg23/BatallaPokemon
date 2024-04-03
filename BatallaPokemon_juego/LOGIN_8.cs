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
    public partial class LOGIN_8 : Form
    {
        public static class DatosJugadores // Clase para guardar los datos de los jugadores y poder acceder a ellos desde cualquier parte del programa
        {
            public static Entrenador player1;
            public static Entrenador player2;
            public static Entrenador player3;
            public static Entrenador player4;
            public static Entrenador player5;
            public static Entrenador player6;
            public static Entrenador player7;
            public static Entrenador player8;
        }
        public LOGIN_8()
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
        private void J18_Enter(object sender, EventArgs e) //metodo para que al hacer click sobre el cuadro de "JUGADOR" se quite la palabra y aparezca el cursor
        {
            if (J18.Text == "JUGADOR 1")
            {
                J18.Text = "";
                J18.ForeColor = Color.Black;
            }

        }

        private void J18_Leave(object sender, EventArgs e)
        {
            if (J18.Text == "")
            {
                J18.Text = "JUGADOR 1";
                J18.ForeColor = Color.DimGray;
            }
        }

        //JUGADOR 2
        private void J28_Enter(object sender, EventArgs e)
        {
            if (J28.Text == "JUGADOR 2")
            {
                J28.Text = "";
                J28.ForeColor = Color.Black;
            }

        }

        private void J28_Leave(object sender, EventArgs e)
        {
            if (J28.Text == "")
            {
                J28.Text = "JUGADOR 2";
                J28.ForeColor = Color.DimGray;
            }
        }

        //JUGADOR 3
        private void J38_Enter(object sender, EventArgs e)
        {
            if (J38.Text == "JUGADOR 3")
            {
                J38.Text = "";
                J38.ForeColor = Color.Black;
            }

        }

        private void J38_Leave(object sender, EventArgs e)
        {
            if (J38.Text == "")
            {
                J38.Text = "JUGADOR 3";
                J38.ForeColor = Color.DimGray;
            }
        }

        //JUGADOR 4
        private void J48_Enter(object sender, EventArgs e)
        {
            if (J48.Text == "JUGADOR 4")
            {
                J48.Text = "";
                J48.ForeColor = Color.Black;
            }

        }

        private void J48_Leave(object sender, EventArgs e)
        {
            if (J48.Text == "")
            {
                J48.Text = "JUGADOR 4";
                J48.ForeColor = Color.DimGray;
            }
        }

        //JUGADOR 5
        private void J58_Enter(object sender, EventArgs e)
        {
            if (J58.Text == "JUGADOR 5")
            {
                J58.Text = "";
                J58.ForeColor = Color.Black;
            }

        }

        private void J58_Leave(object sender, EventArgs e)
        {
            if (J58.Text == "")
            {
                J58.Text = "JUGADOR 5";
                J58.ForeColor = Color.DimGray;
            }
        }

        //JUGADOR 6
        private void J68_Enter(object sender, EventArgs e)
        {
            if (J68.Text == "JUGADOR 6")
            {
                J68.Text = "";
                J68.ForeColor = Color.Black;
            }

        }

        private void J68_Leave(object sender, EventArgs e)
        {
            if (J68.Text == "")
            {
                J68.Text = "JUGADOR 6";
                J68.ForeColor = Color.DimGray;
            }
        }

        //JUGADOR 7
        private void J78_Enter(object sender, EventArgs e)
        {
            if (J78.Text == "JUGADOR 7")
            {
                J78.Text = "";
                J78.ForeColor = Color.Black;
            }

        }

        private void J78_Leave(object sender, EventArgs e)
        {
            if (J78.Text == "")
            {
                J78.Text = "JUGADOR 7";
                J78.ForeColor = Color.DimGray;
            }
        }

        //JUGADOR 8
        private void J88_Enter(object sender, EventArgs e)
        {
            if (J88.Text == "JUGADOR 8")
            {
                J88.Text = "";
                J88.ForeColor = Color.Black;
            }

        }

        private void J88_Leave(object sender, EventArgs e)
        {
            if (J88.Text == "")
            {
                J88.Text = "JUGADOR 8";
                J88.ForeColor = Color.DimGray;
            }
        }

        private void AccederL8_Click(object sender, EventArgs e)
        {
            string username1 = J18.Text;
            string username2 = J28.Text;
            string username3 = J38.Text;
            string username4 = J48.Text;
            string username5 = J58.Text;
            string username6 = J68.Text;
            string username7 = J78.Text;
            string username8 = J88.Text;

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
            if (!IsValidusername1(username1) || !IsValidusername2(username2) || !IsValidusername3(username3) || !IsValidusername4(username4) || !IsValidusername4(username5) || !IsValidusername4(username6) || !IsValidusername4(username7) || !IsValidusername4(username8))
            {
                MessageBox.Show("Los nombres de usuario deben tener entre 8 y 12 caracteres y solo pueden contener letras y números");
                return;
            }

            // Se verifica que los jugadores estén registrados
            if (!JugadorNoRegistrado(username1, username2, username3, username4, username5, username6, username7, username8))
            {
                MessageBox.Show("Uno o ambos jugadores no están registrados");
                return;
            }

            // Si se cumplen todas las validaciones, se guarda el nombre de usuario en una variable global
            DatosJugadores.player1 = BarraCarga.DatosListas.listaJugadores.buscar(username1);
            DatosJugadores.player2 = BarraCarga.DatosListas.listaJugadores.buscar(username2);
            DatosJugadores.player3 = BarraCarga.DatosListas.listaJugadores.buscar(username3);
            DatosJugadores.player4 = BarraCarga.DatosListas.listaJugadores.buscar(username4);
            DatosJugadores.player5 = BarraCarga.DatosListas.listaJugadores.buscar(username5);
            DatosJugadores.player6 = BarraCarga.DatosListas.listaJugadores.buscar(username6);
            DatosJugadores.player7 = BarraCarga.DatosListas.listaJugadores.buscar(username7);
            DatosJugadores.player8 = BarraCarga.DatosListas.listaJugadores.buscar(username8);

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
        private bool IsValidusername3(string username3)
        {
            string pattern = @"^[a-zA-Z0-9]{4,12}$";
            return Regex.IsMatch(username3, pattern);
        }

        private bool IsValidusername4(string username4)
        {
            string pattern = @"^[a-zA-Z0-9]{4,12}$";
            return Regex.IsMatch(username4, pattern);
        }
        private bool IsValidusername5(string username5)
        {
            string pattern = @"^[a-zA-Z0-9]{4,12}$";
            return Regex.IsMatch(username5, pattern);
        }
        private bool IsValidusername6(string username6)
        {
            string pattern = @"^[a-zA-Z0-9]{4,12}$";
            return Regex.IsMatch(username6, pattern);
        }
        private bool IsValidusername7(string username7)
        {
            string pattern = @"^[a-zA-Z0-9]{4,12}$";
            return Regex.IsMatch(username7, pattern);
        }
        private bool IsValidusername8(string username8)
        {
            string pattern = @"^[a-zA-Z0-9]{4,12}$";
            return Regex.IsMatch(username8, pattern);
        }
        private void GuardarDatos_Jugadores(string username1, string username2, string username3, string username4, string username5, string username6, string username7, string username8) //Metodo para guardar los datos en un archivo de texto
        {
            Entrenador J18 = new Entrenador(username1, 0); // Se crea un nuevo entrenador con el nombre del jugador 1
            Entrenador J28 = new Entrenador(username2, 0); // Se crea un nuevo entrenador con el nombre del jugador 2
            Entrenador J38 = new Entrenador(username3, 0); // Se crea un nuevo entrenador con el nombre del jugador 3
            Entrenador J48 = new Entrenador(username4, 0); // Se crea un nuevo entrenador con el nombre del jugador 4
            Entrenador J58 = new Entrenador(username5, 0); // Se crea un nuevo entrenador con el nombre del jugador 5
            Entrenador J68 = new Entrenador(username6, 0); // Se crea un nuevo entrenador con el nombre del jugador 6
            Entrenador J78 = new Entrenador(username7, 0); // Se crea un nuevo entrenador con el nombre del jugador 7
            Entrenador J88 = new Entrenador(username8, 0); // Se crea un nuevo entrenador con el nombre del jugador 8

            BarraCarga.DatosListas.listaJugadores.agregar(J18); // Se agrega el jugador 1 a la lista de jugadores
            BarraCarga.DatosListas.listaJugadores.agregar(J28); // Se agrega el jugador 2 a la lista de jugadores
            BarraCarga.DatosListas.listaJugadores.agregar(J38); // Se agrega el jugador 3 a la lista de jugadores
            BarraCarga.DatosListas.listaJugadores.agregar(J48); // Se agrega el jugador 4 a la lista de jugadores
            BarraCarga.DatosListas.listaJugadores.agregar(J58); // Se agrega el jugador 5 a la lista de jugadores
            BarraCarga.DatosListas.listaJugadores.agregar(J68); // Se agrega el jugador 6 a la lista de jugadores
            BarraCarga.DatosListas.listaJugadores.agregar(J78); // Se agrega el jugador 7 a la lista de jugadores
            BarraCarga.DatosListas.listaJugadores.agregar(J88); // Se agrega el jugador 8 a la lista de jugadores

            Archivo archivo = new Archivo("Jugadores.txt"); // Se crea un nuevo objeto archivo
            string texto = J18.mostrarInfo() + "\n" + J28.mostrarInfo() + "\n" + J38.mostrarInfo() + "\n" + J48.mostrarInfo() + "\n" + J58.mostrarInfo() + "\n" + J68.mostrarInfo() + "\n" + J78.mostrarInfo() + "\n" + J88.mostrarInfo(); // Se crea un string con la información de los jugadores
            archivo.Escribir(texto); // Se escribe el string en el archivo
        }

        private void RegistrarL8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Se obtienen los nombres de usuario
            string username1 = J18.Text;
            string username2 = J28.Text;
            string username3 = J38.Text;
            string username4 = J48.Text;
            string username5 = J58.Text;
            string username6 = J68.Text;
            string username7 = J78.Text;
            string username8 = J88.Text;

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
            if (!IsValidusername1(username1) || !IsValidusername2(username2) || !IsValidusername3(username3) || !IsValidusername4(username4) || !IsValidusername5(username5) || !IsValidusername6(username6) || !IsValidusername7(username7) || !IsValidusername8(username8))
            {
                MessageBox.Show("Los nombres de usuario deben tener entre 8 y 12 caracteres y solo pueden contener letras y números");
                return;
            }

            // Se verifica que los jugadores no estén registrados
            if (JugadorYaRegistrado(username1, username2, username3, username4, username5, username6, username7, username8))
            {
                MessageBox.Show("Uno o ambos jugadores ya están registrados");
                return;
            }

            // Si se cumplen todas las validaciones, se guardan los datos de los jugadores
            GuardarDatos_Jugadores(username1, username2, username3, username4, username5, username6, username7, username8);
            MessageBox.Show("Los jugadores han sido registrados exitosamente");
        }

        private Boolean ValidarCampos() //Metodo para validar que los campos no esten vacios
        {
            if (J18.Text == "JUGADOR 1" || J28.Text == "JUGADOR 2" || J38.Text == "JUGADOR 3" || J48.Text == "JUGADOR 4" || J58.Text == "JUGADOR 5" || J68.Text == "JUGADOR 6" || J78.Text == "JUGADOR 7" || J88.Text == "JUGADOR 8")
            {
                MessageBox.Show("Por favor, llene todos los campos");
                return false;
            }
            return true;
        }

        private Boolean ValidarJugadores() //Metodo para validar que los jugadores no sean iguales
        {
            if (J18.Text == J28.Text || J18.Text == J38.Text || J18.Text == J48.Text || J18.Text == J58.Text || J18.Text == J68.Text || J18.Text == J78.Text || J18.Text == J88.Text || J28.Text == J38.Text || J28.Text == J48.Text || J28.Text == J58.Text || J28.Text == J68.Text || J28.Text == J78.Text || J28.Text == J88.Text || J38.Text == J48.Text || J38.Text == J58.Text || J38.Text == J68.Text || J38.Text == J78.Text || J38.Text == J88.Text || J48.Text == J58.Text || J48.Text == J68.Text || J48.Text == J78.Text || J48.Text == J88.Text || J58.Text == J68.Text || J58.Text == J78.Text || J58.Text == J88.Text || J68.Text == J78.Text || J68.Text == J88.Text || J78.Text == J88.Text)
            {
                MessageBox.Show("Los jugadores no pueden ser iguales");
                return false;
            }
            return true;
        }

        private Boolean JugadorYaRegistrado(string username1, string username2, string username3, string username4, string username5, string username6, string username7, string username8) //Metodo para verificar los jugadores esten registrados
        {
            ListaJugadores jugadores = BarraCarga.DatosListas.listaJugadores; // Se obtiene la lista de jugadores

            if (jugadores.existe(username1) || jugadores.existe(username2) || jugadores.existe(username3) || jugadores.existe(username4) || jugadores.existe(username5) || jugadores.existe(username6) || jugadores.existe(username6) || jugadores.existe(username8)) // Si los jugadores 1, 2, 3, 4, 5, 6, 7, 8 ya están registrados
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean JugadorNoRegistrado(string username1, string username2, string username3, string username4, string username5, string username6, string username7, string username8) //Metodo para validar que los jugadores no esten registrados
        {
            ListaJugadores jugadores = BarraCarga.DatosListas.listaJugadores; // Se obtiene la lista de jugadores

            if (jugadores.existe(username1) && jugadores.existe(username2) && jugadores.existe(username3) && jugadores.existe(username4) && jugadores.existe(username5) && jugadores.existe(username6) && jugadores.existe(username7) && jugadores.existe(username8)) //  Si los jugadores 1, 2, 3, 4, 5, 6, 7, 8 no están registrados
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
