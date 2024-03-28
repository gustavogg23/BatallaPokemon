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
    public partial class SelectorPokemon : Form
    {
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
            this.Visible = false; //permite ocultar el form de "SelectorPokemon" para dar paso al FORM "BC_BATALLA"

            BC_BATALLA formBC_BATALLA = new BC_BATALLA();
            formBC_BATALLA.ShowDialog();
        }
    }
}
