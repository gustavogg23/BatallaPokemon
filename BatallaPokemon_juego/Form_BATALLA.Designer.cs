namespace BatallaPokemon_juego
{
    partial class Form_BATALLA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BATALLA));
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.luchar = new System.Windows.Forms.Button();
            this.pokemon = new System.Windows.Forms.Button();
            this.bolsa = new System.Windows.Forms.Button();
            this.huir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.Image = global::BatallaPokemon_juego.Properties.Resources.salir;
            this.cerrar.Location = new System.Drawing.Point(1221, 12);
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
            this.minimizar.Location = new System.Drawing.Point(1170, 12);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(30, 30);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 1;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // luchar
            // 
            this.luchar.BackColor = System.Drawing.Color.Transparent;
            this.luchar.BackgroundImage = global::BatallaPokemon_juego.Properties.Resources.LUCHAR;
            this.luchar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.luchar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.luchar.FlatAppearance.BorderSize = 0;
            this.luchar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.luchar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.luchar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.luchar.Location = new System.Drawing.Point(1038, 406);
            this.luchar.Name = "luchar";
            this.luchar.Size = new System.Drawing.Size(195, 56);
            this.luchar.TabIndex = 2;
            this.luchar.UseVisualStyleBackColor = false;
            this.luchar.Click += new System.EventHandler(this.luchar_Click);
            // 
            // pokemon
            // 
            this.pokemon.BackColor = System.Drawing.Color.Transparent;
            this.pokemon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pokemon.BackgroundImage")));
            this.pokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pokemon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pokemon.FlatAppearance.BorderSize = 0;
            this.pokemon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pokemon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pokemon.Location = new System.Drawing.Point(1038, 467);
            this.pokemon.Name = "pokemon";
            this.pokemon.Size = new System.Drawing.Size(195, 56);
            this.pokemon.TabIndex = 3;
            this.pokemon.UseVisualStyleBackColor = false;
            this.pokemon.Click += new System.EventHandler(this.pokemon_Click);
            // 
            // bolsa
            // 
            this.bolsa.BackColor = System.Drawing.Color.Transparent;
            this.bolsa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bolsa.BackgroundImage")));
            this.bolsa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bolsa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bolsa.FlatAppearance.BorderSize = 0;
            this.bolsa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bolsa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bolsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bolsa.Location = new System.Drawing.Point(1038, 529);
            this.bolsa.Name = "bolsa";
            this.bolsa.Size = new System.Drawing.Size(195, 56);
            this.bolsa.TabIndex = 4;
            this.bolsa.UseVisualStyleBackColor = false;
            this.bolsa.Click += new System.EventHandler(this.bolsa_Click);
            // 
            // huir
            // 
            this.huir.BackColor = System.Drawing.Color.Transparent;
            this.huir.BackgroundImage = global::BatallaPokemon_juego.Properties.Resources.HUIR;
            this.huir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.huir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.huir.FlatAppearance.BorderSize = 0;
            this.huir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.huir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.huir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.huir.Location = new System.Drawing.Point(1038, 590);
            this.huir.Name = "huir";
            this.huir.Size = new System.Drawing.Size(195, 56);
            this.huir.TabIndex = 5;
            this.huir.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(415, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 285);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(763, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(285, 285);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(70, 547);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(176, 17);
            this.progressBar1.TabIndex = 8;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(1009, 118);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(176, 17);
            this.progressBar2.TabIndex = 9;
            // 
            // Form_BATALLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 652);
            this.Controls.Add(this.pokemon);
            this.Controls.Add(this.luchar);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.huir);
            this.Controls.Add(this.bolsa);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_BATALLA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_BATALLA";
            this.Load += new System.EventHandler(this.Form_BATALLA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.Button luchar;
        private System.Windows.Forms.Button pokemon;
        private System.Windows.Forms.Button bolsa;
        private System.Windows.Forms.Button huir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}