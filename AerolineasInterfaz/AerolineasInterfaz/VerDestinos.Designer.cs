namespace AerolineasInterfaz
{
    partial class VerDestinos
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.Location = new System.Drawing.Point(9, 12);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(436, 426);
            this.dgv1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(436, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar el destino en Google Maps";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerDestinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(457, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv1);
            this.Name = "VerDestinos";
            this.Text = "VerDestinos";
            this.Load += new System.EventHandler(this.VerDestinos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DGV dgv1;
        private System.Windows.Forms.Button button1;
    }
}