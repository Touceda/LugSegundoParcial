namespace AerolineasInterfaz
{
    partial class LlenarVuelo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPasajeros = new AerolineasInterfaz.DGV();
            this.dgvVuelos = new AerolineasInterfaz.DGV();
            this.label3 = new System.Windows.Forms.Label();
            this.btbAñadirPasajero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vuelos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(630, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pasajeros";
            // 
            // dgvPasajeros
            // 
            this.dgvPasajeros.Location = new System.Drawing.Point(454, 47);
            this.dgvPasajeros.Name = "dgvPasajeros";
            this.dgvPasajeros.Size = new System.Drawing.Size(436, 426);
            this.dgvPasajeros.TabIndex = 4;
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.Location = new System.Drawing.Point(12, 47);
            this.dgvVuelos.Name = "dgvVuelos";
            this.dgvVuelos.Size = new System.Drawing.Size(436, 426);
            this.dgvVuelos.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(188, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(566, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecciona un vuelo, un pasajero y pulsa un boton para añadirlo";
            // 
            // btbAñadirPasajero
            // 
            this.btbAñadirPasajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbAñadirPasajero.Location = new System.Drawing.Point(12, 527);
            this.btbAñadirPasajero.Name = "btbAñadirPasajero";
            this.btbAñadirPasajero.Size = new System.Drawing.Size(872, 41);
            this.btbAñadirPasajero.TabIndex = 6;
            this.btbAñadirPasajero.Text = "Añadir Pasajero al Avion";
            this.btbAñadirPasajero.UseVisualStyleBackColor = true;
            this.btbAñadirPasajero.Click += new System.EventHandler(this.btbAñadirPasajero_Click);
            // 
            // LlenarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(896, 580);
            this.Controls.Add(this.btbAñadirPasajero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPasajeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVuelos);
            this.Name = "LlenarVuelo";
            this.Text = "LlenarVuelo";
            this.Load += new System.EventHandler(this.LlenarVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DGV dgvVuelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DGV dgvPasajeros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btbAñadirPasajero;
    }
}