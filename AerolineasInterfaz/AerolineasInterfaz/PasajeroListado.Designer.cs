namespace AerolineasInterfaz
{
    partial class PasajeroListado
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
            this.dgvPasajerosLista = new AerolineasInterfaz.DGV();
            this.SuspendLayout();
            // 
            // dgvPasajerosLista
            // 
            this.dgvPasajerosLista.Location = new System.Drawing.Point(12, 12);
            this.dgvPasajerosLista.Name = "dgvPasajerosLista";
            this.dgvPasajerosLista.Size = new System.Drawing.Size(436, 426);
            this.dgvPasajerosLista.TabIndex = 0;
            // 
            // PasajeroListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.dgvPasajerosLista);
            this.Name = "PasajeroListado";
            this.Text = "PasajeroListado";
            this.Load += new System.EventHandler(this.PasajeroListado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DGV dgvPasajerosLista;
    }
}