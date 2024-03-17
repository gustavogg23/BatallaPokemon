namespace BatallaPokemon_juego
{
    partial class inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.iniciar = new System.Windows.Forms.Button();
            this.torneoBoton = new System.Windows.Forms.Button();
            this.rankingBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iniciar
            // 
            this.iniciar.BackColor = System.Drawing.Color.Transparent;
            this.iniciar.BackgroundImage = global::BatallaPokemon_juego.Properties.Resources.INICIAR;
            this.iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iniciar.FlatAppearance.BorderSize = 0;
            this.iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciar.Location = new System.Drawing.Point(522, 342);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(230, 76);
            this.iniciar.TabIndex = 0;
            this.iniciar.UseVisualStyleBackColor = false;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // torneoBoton
            // 
            this.torneoBoton.BackColor = System.Drawing.Color.Transparent;
            this.torneoBoton.BackgroundImage = global::BatallaPokemon_juego.Properties.Resources.TORN;
            this.torneoBoton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.torneoBoton.FlatAppearance.BorderSize = 0;
            this.torneoBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.torneoBoton.Location = new System.Drawing.Point(402, 524);
            this.torneoBoton.Name = "torneoBoton";
            this.torneoBoton.Size = new System.Drawing.Size(190, 62);
            this.torneoBoton.TabIndex = 1;
            this.torneoBoton.UseVisualStyleBackColor = false;
            // 
            // rankingBoton
            // 
            this.rankingBoton.BackColor = System.Drawing.Color.Transparent;
            this.rankingBoton.BackgroundImage = global::BatallaPokemon_juego.Properties.Resources.ranking1;
            this.rankingBoton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rankingBoton.FlatAppearance.BorderSize = 0;
            this.rankingBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rankingBoton.Location = new System.Drawing.Point(678, 524);
            this.rankingBoton.Name = "rankingBoton";
            this.rankingBoton.Size = new System.Drawing.Size(190, 62);
            this.rankingBoton.TabIndex = 2;
            this.rankingBoton.UseVisualStyleBackColor = false;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BatallaPokemon_juego.Properties.Resources.Fondo_inicio;
            this.ClientSize = new System.Drawing.Size(1279, 691);
            this.Controls.Add(this.rankingBoton);
            this.Controls.Add(this.torneoBoton);
            this.Controls.Add(this.iniciar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Button torneoBoton;
        private System.Windows.Forms.Button rankingBoton;
    }
}

