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
    public partial class Form_TORNEO : Form
    {
        public Form_TORNEO()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void btnJug4_Click(object sender, EventArgs e)
        {
            this.Close(); // Para cerrar el formulario actual

            LOGIN_4 formLogin4 = new LOGIN_4();
            formLogin4.ShowDialog();
        }

        private void btnJug8_Click(object sender, EventArgs e)
        {
            this.Close(); // Para cerrar el formulario actual

            LOGIN_8 formLogin8 = new LOGIN_8();
            formLogin8.ShowDialog();
        }
    }
}
