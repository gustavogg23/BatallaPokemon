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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            BarraCarga BarraDeCarga = new BarraCarga();

            this.Hide();

            //mostramos el formulario como cuadro de dialogo
            BarraDeCarga.ShowDialog();
        }
    }
}
