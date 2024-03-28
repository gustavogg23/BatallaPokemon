namespace BatallaPokemon_juego
{
    partial class SelectorPokemon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.lblPokemones = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPokemones = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.Image = global::BatallaPokemon_juego.Properties.Resources.salir;
            this.cerrar.Location = new System.Drawing.Point(80, 3);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(30, 30);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 0;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // minimizar
            // 
            this.minimizar.BackColor = System.Drawing.Color.Transparent;
            this.minimizar.Image = global::BatallaPokemon_juego.Properties.Resources.Minimizar;
            this.minimizar.Location = new System.Drawing.Point(45, 3);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(30, 30);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 1;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(840, 532);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(140, 37);
            this.aceptar.TabIndex = 2;
            this.aceptar.Text = "ACEPTAR";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // lblPokemones
            // 
            this.lblPokemones.BackColor = System.Drawing.Color.Transparent;
            this.lblPokemones.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPokemones.Font = new System.Drawing.Font("Agency FB", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokemones.Location = new System.Drawing.Point(0, 0);
            this.lblPokemones.Name = "lblPokemones";
            this.lblPokemones.Size = new System.Drawing.Size(992, 60);
            this.lblPokemones.TabIndex = 3;
            this.lblPokemones.Text = "POKEMONES";
            this.lblPokemones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.minimizar);
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Location = new System.Drawing.Point(870, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 51);
            this.panel1.TabIndex = 4;
            // 
            // panelPokemones
            // 
            this.panelPokemones.AutoScroll = true;
            this.panelPokemones.BackColor = System.Drawing.Color.Transparent;
            this.panelPokemones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPokemones.Location = new System.Drawing.Point(0, 60);
            this.panelPokemones.Name = "panelPokemones";
            this.panelPokemones.Size = new System.Drawing.Size(824, 521);
            this.panelPokemones.TabIndex = 5;
            this.panelPokemones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPokemones_Paint);
            // 
            // SelectorPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::BatallaPokemon_juego.Properties.Resources.ElegirPokemones;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 581);
            this.Controls.Add(this.panelPokemones);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPokemones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SelectorPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectorPokemon";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.SelectorPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label lblPokemones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelPokemones;
    }
}