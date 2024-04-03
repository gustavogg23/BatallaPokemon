namespace BatallaPokemon_juego
{
    partial class Form_TORNEO
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
            this.btnJug4 = new System.Windows.Forms.Button();
            this.btnJug8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJug4
            // 
            this.btnJug4.BackgroundImage = global::BatallaPokemon_juego.Properties.Resources.btnTorneo2;
            this.btnJug4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJug4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJug4.Location = new System.Drawing.Point(4, 414);
            this.btnJug4.Name = "btnJug4";
            this.btnJug4.Size = new System.Drawing.Size(195, 55);
            this.btnJug4.TabIndex = 0;
            this.btnJug4.Text = "4 JUGADORES";
            this.btnJug4.UseVisualStyleBackColor = true;
            this.btnJug4.Click += new System.EventHandler(this.btnJug4_Click);
            // 
            // btnJug8
            // 
            this.btnJug8.BackgroundImage = global::BatallaPokemon_juego.Properties.Resources.btnTorneo;
            this.btnJug8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJug8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJug8.Location = new System.Drawing.Point(220, 414);
            this.btnJug8.Name = "btnJug8";
            this.btnJug8.Size = new System.Drawing.Size(195, 55);
            this.btnJug8.TabIndex = 1;
            this.btnJug8.Text = "8 JUGADORES";
            this.btnJug8.UseVisualStyleBackColor = true;
            this.btnJug8.Click += new System.EventHandler(this.btnJug8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BatallaPokemon_juego.Properties.Resources.salir;
            this.pictureBox1.Location = new System.Drawing.Point(388, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form_TORNEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::BatallaPokemon_juego.Properties.Resources.fondo_Torneo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnJug8);
            this.Controls.Add(this.btnJug4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_TORNEO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_TORNEO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJug4;
        private System.Windows.Forms.Button btnJug8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}