using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatallaPokemon_juego
{
    public partial class LOGIN_8 : Form
    {
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

    }
}
