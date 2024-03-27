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

        private void acceder_Click(object sender, EventArgs e) //validaciones de correo y contraseña al hacer click en "ACCEDER" 
        {
            string username1 = jugador1.Text;
            string username2 = jugador2.Text;

            if (IsValidusername1(username1) && IsValidusername2(username2))
            {
                GuardarDatos_Jugadores(username1, username2);
                MessageBox.Show("Los Datos han sido guardados exitosamente");
            }
        }

        private bool IsValidusername1(string username1) //Metodo para validar que el usuario 1 pueda usar solo letras y numeros
        {
            string pattern = @"^[a-zA-Z0-9]{8,12}$";
            return Regex.IsMatch(username1, pattern);
        }

        private bool IsValidusername2(string username2) //Metodo para validar que el usuario 2 pueda usar solo letras y numeros
        {
            string pattern = @"^[a-zA-Z0-9]{8,12}$";
            return Regex.IsMatch(username2, pattern);
        }

        private void GuardarDatos_Jugadores(string username1, string username2) //Metodo para guardar los datos en un archivo de texto
        {
            using (StreamWriter sw = new StreamWriter("Datos_Jugadores.txt", true))
            {
                sw.WriteLine($"JUGADOR 1: {username1}");
                sw.WriteLine($"JUGADOR 2: {username2}");
                sw.WriteLine();
            }
        }
    }
}
