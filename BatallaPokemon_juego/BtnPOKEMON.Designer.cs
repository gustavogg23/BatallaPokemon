namespace BatallaPokemon_juego
{
    partial class BtnPOKEMON
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
            this.panelBtnPokemones = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelBtnPokemones
            // 
            this.panelBtnPokemones.BackColor = System.Drawing.Color.DarkCyan;
            this.panelBtnPokemones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtnPokemones.Location = new System.Drawing.Point(0, 0);
            this.panelBtnPokemones.Name = "panelBtnPokemones";
            this.panelBtnPokemones.Size = new System.Drawing.Size(160, 335);
            this.panelBtnPokemones.TabIndex = 0;
            // 
            // BtnPOKEMON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 335);
            this.Controls.Add(this.panelBtnPokemones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BtnPOKEMON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BtnPOKEMON";
            this.Load += new System.EventHandler(this.BtnPOKEMON_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelBtnPokemones;
    }
}