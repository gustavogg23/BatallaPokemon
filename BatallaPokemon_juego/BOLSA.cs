using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BatallaPokemon_juego.Form_BATALLA;

namespace BatallaPokemon_juego
{
    public partial class BOLSA : Form
    {
        public BOLSA()
        {
            InitializeComponent();
        }

        private void btnPocion_Click(object sender, EventArgs e)
        {
            //PilaItems pilaPocion = InfoBatalla.batalla.getEntrenadorTurno().getItems().buscar("Poción");

            //// Usa una poción
            //InfoBatalla.batalla.UsarItem(pilaPocion);

            // Lanza el evento de item usado
            ItemUsado?.Invoke(this, EventArgs.Empty);

            // Cierra el formulario de la Bolsa
            this.Close();
        }

        private void btnAntiPar_Click(object sender, EventArgs e)
        {
            //PilaItems pilaSuperpocion = InfoBatalla.batalla.getEntrenadorTurno().getItems().buscar("Superpoción");

            //// Usa una poción
            //InfoBatalla.batalla.UsarItem(pilaSuperpocion);

            //// Lanza el evento de item usado
            ItemUsado?.Invoke(this, EventArgs.Empty);

            // Cierra el formulario de la Bolsa
            this.Close();
        }

        private void btnCura_Click(object sender, EventArgs e)
        {
            //PilaItems pilaHiperpocion = InfoBatalla.batalla.getEntrenadorTurno().getItems().buscar("Hiperpoción");

            //// Usa una poción
            //InfoBatalla.batalla.UsarItem(pilaHiperpocion);

            //// Lanza el evento de item usado
            ItemUsado?.Invoke(this, EventArgs.Empty);

            // Cierra el formulario de la Bolsa
            this.Close();
        }

        private void btnSuper_Click(object sender, EventArgs e)
        {
            //PilaItems pilaAntipar = InfoBatalla.batalla.getEntrenadorTurno().getItems().buscar("Antiparálisis");

            //// Usa una poción
            //InfoBatalla.batalla.UsarItem(pilaAntipar);

            // Lanza el evento de item usado
            ItemUsado?.Invoke(this, EventArgs.Empty);

            // Cierra el formulario de la Bolsa
            this.Close();
        }

        private void btnAntidoto_Click(object sender, EventArgs e)
        {
            //PilaItems pilaAnti = InfoBatalla.batalla.getEntrenadorTurno().getItems().buscar("Antídoto");

            //// Usa una poción
            //InfoBatalla.batalla.UsarItem(pilaAnti);

            // Lanza el evento de item usado
            ItemUsado?.Invoke(this, EventArgs.Empty);

            // Cierra el formulario de la Bolsa
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            //PilaItems pilaDes = InfoBatalla.batalla.getEntrenadorTurno().getItems().buscar("Despertar");

            //// Usa una poción
            //InfoBatalla.batalla.UsarItem(pilaDes);

            // Lanza el evento de item usado
            ItemUsado?.Invoke(this, EventArgs.Empty);

            // Cierra el formulario de la Bolsa
            this.Close();
        }

        private void btnHiper_Click(object sender, EventArgs e)
        {
            //PilaItems pilaCura = InfoBatalla.batalla.getEntrenadorTurno().getItems().buscar("Cura Total");

            //// Usa una poción
            //InfoBatalla.batalla.UsarItem(pilaCura);

            // Lanza el evento de item usado
            ItemUsado?.Invoke(this, EventArgs.Empty);

            // Cierra el formulario de la Bolsa
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //PilaItems pilaMax = InfoBatalla.batalla.getEntrenadorTurno().getItems().buscar("Max Poción");

            //// Usa una poción
            //InfoBatalla.batalla.UsarItem(pilaMax);

            // Lanza el evento de item usado
            ItemUsado?.Invoke(this, EventArgs.Empty);

            // Cierra el formulario de la Bolsa
            this.Close();
        }

        private void btnPrecision_Click(object sender, EventArgs e)
        {
            //PilaItems pilaPrec = InfoBatalla.batalla.getEntrenadorTurno().getItems().buscar("Precisión X");

            //// Usa una poción
            //InfoBatalla.batalla.UsarItem(pilaPrec);

            // Lanza el evento de item usado
            ItemUsado?.Invoke(this, EventArgs.Empty);

            // Cierra el formulario de la Bolsa
            this.Close();
        }

        public delegate void ItemUsadoEventHandler(object sender, EventArgs e);
        public event ItemUsadoEventHandler ItemUsado;
    }
}
