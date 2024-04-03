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
    public partial class LOGIN_4 : Form
    {
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
    }
}
