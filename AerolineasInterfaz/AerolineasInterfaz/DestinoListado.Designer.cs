namespace AerolineasInterfaz
{
    partial class DestinoListado
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
            this.dgvDestinosListados = new AerolineasInterfaz.DGV();
            this.SuspendLayout();
            // 
            // dgvDestinosListados
            // 
            this.dgvDestinosListados.Location = new System.Drawing.Point(12, 12);
            this.dgvDestinosListados.Name = "dgvDestinosListados";
            this.dgvDestinosListados.Size = new System.Drawing.Size(436, 426);
            this.dgvDestinosListados.TabIndex = 0;
            // 
            // DestinoListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.dgvDestinosListados);
            this.Name = "DestinoListado";
            this.Text = "DestinoListado";
            this.Load += new System.EventHandler(this.DestinoListado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DGV dgvDestinosListados;
    }
}