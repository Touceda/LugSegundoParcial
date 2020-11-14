namespace AerolineasInterfaz
{
    partial class DestinoModificar
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
            this.dgvModificarDestinos = new AerolineasInterfaz.DGV();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevoDestino = new System.Windows.Forms.TextBox();
            this.txtNuevaUbicacion = new System.Windows.Forms.TextBox();
            this.btbModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dgvModificarDestinos
            // 
            this.dgvModificarDestinos.Location = new System.Drawing.Point(12, 12);
            this.dgvModificarDestinos.Name = "dgvModificarDestinos";
            this.dgvModificarDestinos.Size = new System.Drawing.Size(436, 426);
            this.dgvModificarDestinos.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(511, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "despues precione el boton para modificarlo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(450, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "LinkMaps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(454, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(467, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "y luego complete el formulario con sus nuevos datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(576, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Seleccione el  destino";
            // 
            // txtNuevoDestino
            // 
            this.txtNuevoDestino.Location = new System.Drawing.Point(529, 207);
            this.txtNuevoDestino.Name = "txtNuevoDestino";
            this.txtNuevoDestino.Size = new System.Drawing.Size(329, 20);
            this.txtNuevoDestino.TabIndex = 13;
            // 
            // txtNuevaUbicacion
            // 
            this.txtNuevaUbicacion.Location = new System.Drawing.Point(527, 281);
            this.txtNuevaUbicacion.Name = "txtNuevaUbicacion";
            this.txtNuevaUbicacion.Size = new System.Drawing.Size(329, 20);
            this.txtNuevaUbicacion.TabIndex = 12;
            // 
            // btbModificar
            // 
            this.btbModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btbModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbModificar.Location = new System.Drawing.Point(454, 348);
            this.btbModificar.Name = "btbModificar";
            this.btbModificar.Size = new System.Drawing.Size(404, 90);
            this.btbModificar.TabIndex = 11;
            this.btbModificar.Text = "Modificar Destino";
            this.btbModificar.UseVisualStyleBackColor = false;
            this.btbModificar.Click += new System.EventHandler(this.btbModificar_Click_1);
            // 
            // DestinoModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNuevoDestino);
            this.Controls.Add(this.txtNuevaUbicacion);
            this.Controls.Add(this.btbModificar);
            this.Controls.Add(this.dgvModificarDestinos);
            this.Name = "DestinoModificar";
            this.Text = "DestinoModificar";
            this.Load += new System.EventHandler(this.DestinoModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DGV dgvModificarDestinos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevoDestino;
        private System.Windows.Forms.TextBox txtNuevaUbicacion;
        private System.Windows.Forms.Button btbModificar;
    }
}