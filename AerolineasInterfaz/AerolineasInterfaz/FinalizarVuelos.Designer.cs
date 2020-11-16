namespace AerolineasInterfaz
{
    partial class FinalizarVuelos
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
            this.dgvVuelos = new AerolineasInterfaz.DGV();
            this.btbFinalizarVuelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.Location = new System.Drawing.Point(12, 12);
            this.dgvVuelos.Name = "dgvVuelos";
            this.dgvVuelos.Size = new System.Drawing.Size(436, 426);
            this.dgvVuelos.TabIndex = 0;
            // 
            // btbFinalizarVuelo
            // 
            this.btbFinalizarVuelo.Location = new System.Drawing.Point(12, 444);
            this.btbFinalizarVuelo.Name = "btbFinalizarVuelo";
            this.btbFinalizarVuelo.Size = new System.Drawing.Size(436, 49);
            this.btbFinalizarVuelo.TabIndex = 17;
            this.btbFinalizarVuelo.Text = "Si quiere finalizar un vuelo, seleccionelo y pecione AQUI";
            this.btbFinalizarVuelo.UseVisualStyleBackColor = true;
            this.btbFinalizarVuelo.Click += new System.EventHandler(this.btbFinalizarVuelo_Click);
            // 
            // FinalizarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(454, 499);
            this.Controls.Add(this.btbFinalizarVuelo);
            this.Controls.Add(this.dgvVuelos);
            this.Name = "FinalizarVuelos";
            this.Text = "FinalizarVuelos";
            this.Load += new System.EventHandler(this.FinalizarVuelos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DGV dgvVuelos;
        private System.Windows.Forms.Button btbFinalizarVuelo;
    }
}