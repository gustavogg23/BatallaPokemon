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
            this.barraVida1 = new System.Windows.Forms.ProgressBar();
            this.barraVida2 = new System.Windows.Forms.ProgressBar();
            this.nombrePokemon2 = new System.Windows.Forms.TextBox();
            this.nombrePokemon1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
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
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
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
            this.luchar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("luchar.BackgroundImage")));
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
            this.huir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("huir.BackgroundImage")));
            this.huir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.huir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.huir.FlatAppearance.BorderSize = 0;
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
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(364, 441);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(880, 324);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // barraVida1
            // 
            this.barraVida1.Location = new System.Drawing.Point(70, 547);
            this.barraVida1.Name = "barraVida1";
            this.barraVida1.Size = new System.Drawing.Size(176, 17);
            this.barraVida1.TabIndex = 8;
            // 
            // barraVida2
            // 
            this.barraVida2.Location = new System.Drawing.Point(1009, 94);
            this.barraVida2.Name = "barraVida2";
            this.barraVida2.Size = new System.Drawing.Size(176, 17);
            this.barraVida2.TabIndex = 9;
            // 
            // nombrePokemon2
            // 
            this.nombrePokemon2.BackColor = System.Drawing.Color.White;
            this.nombrePokemon2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombrePokemon2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon2.Location = new System.Drawing.Point(1009, 68);
            this.nombrePokemon2.Name = "nombrePokemon2";
            this.nombrePokemon2.Size = new System.Drawing.Size(176, 19);
            this.nombrePokemon2.TabIndex = 10;
            this.nombrePokemon2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nombrePokemon1
            // 
            this.nombrePokemon1.BackColor = System.Drawing.Color.White;
            this.nombrePokemon1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombrePokemon1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon1.Location = new System.Drawing.Point(70, 521);
            this.nombrePokemon1.Name = "nombrePokemon1";
            this.nombrePokemon1.Size = new System.Drawing.Size(176, 19);
            this.nombrePokemon1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(49, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 58);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(984, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 58);
            this.panel2.TabIndex = 13;
            // 
            // Form_BATALLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 652);
            this.Controls.Add(this.nombrePokemon1);
            this.Controls.Add(this.nombrePokemon2);
            this.Controls.Add(this.pokemon);
            this.Controls.Add(this.luchar);
            this.Controls.Add(this.barraVida2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barraVida1);
            this.Controls.Add(this.huir);
            this.Controls.Add(this.bolsa);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.Button luchar;
        private System.Windows.Forms.Button pokemon;
        private System.Windows.Forms.Button bolsa;
        private System.Windows.Forms.Button huir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar barraVida1;
        private System.Windows.Forms.ProgressBar barraVida2;
        private System.Windows.Forms.TextBox nombrePokemon2;
        private System.Windows.Forms.TextBox nombrePokemon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}