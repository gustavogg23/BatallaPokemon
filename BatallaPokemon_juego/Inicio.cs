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
            Visible = false; //permite ocultar el formulario de inicio al ejecutar el juego
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BarraCarga BarraDeCarga = new BarraCarga();
            BarraDeCarga.CargaCompleta += BarraDeCarga_CargaCompleta; //se llama al evento de carga completa
            BarraDeCarga.ShowDialog(); //mostramos el formulario como cuadro de dialogo
        }

        private void BarraDeCarga_CargaCompleta(object sender, EventArgs e)
        {
            Show(); //Permite mostrar el form de inicio al cerrar la barra de carga
        }
        private void iniciar_Click(object sender, EventArgs e)
        {

        }
    }
}
