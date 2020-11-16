namespace AerolineasInterfaz
{
    partial class VerVuelosPasajeros
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
            this.dgv1 = new AerolineasInterfaz.DGV();
            this.dgv2 = new AerolineasInterfaz.DGV();
            this.btbVerVuelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.Location = new System.Drawing.Point(12, 12);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(436, 426);
            this.dgv1.TabIndex = 0;
            // 
            // dgv2
            // 
            this.dgv2.Location = new System.Drawing.Point(454, 12);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(436, 426);
            this.dgv2.TabIndex = 1;
            // 
            // btbVerVuelo
            // 
            this.btbVerVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbVerVuelo.Location = new System.Drawing.Point(12, 454);
            this.btbVerVuelo.Name = "btbVerVuelo";
            this.btbVerVuelo.Size = new System.Drawing.Size(878, 60);
            this.btbVerVuelo.TabIndex = 2;
            this.btbVerVuelo.Text = "Seleccione un vuelo y precione aqui para verlo en detalle";
            this.btbVerVuelo.UseVisualStyleBackColor = true;
            this.btbVerVuelo.Click += new System.EventHandler(this.btbVerVuelo_Click);
            // 
            // VerVuelosPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(896, 526);
            this.Controls.Add(this.btbVerVuelo);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Name = "VerVuelosPasajeros";
            this.Text = "VerVuelosPasajeros";
            this.Load += new System.EventHandler(this.VerVuelosPasajeros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DGV dgv1;
        private DGV dgv2;
        private System.Windows.Forms.Button btbVerVuelo;
    }
}