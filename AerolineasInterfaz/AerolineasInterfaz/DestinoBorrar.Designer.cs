﻿namespace AerolineasInterfaz
{
    partial class DestinoBorrar
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
            this.dgvBorrarDestino = new AerolineasInterfaz.DGV();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btbBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dgvBorrarDestino
            // 
            this.dgvBorrarDestino.Location = new System.Drawing.Point(12, 12);
            this.dgvBorrarDestino.Name = "dgvBorrarDestino";
            this.dgvBorrarDestino.Size = new System.Drawing.Size(436, 426);
            this.dgvBorrarDestino.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(489, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y precione el boton para darle de baja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(538, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione un destino";
            // 
            // btbBorrar
            // 
            this.btbBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btbBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbBorrar.Location = new System.Drawing.Point(454, 194);
            this.btbBorrar.Name = "btbBorrar";
            this.btbBorrar.Size = new System.Drawing.Size(334, 244);
            this.btbBorrar.TabIndex = 8;
            this.btbBorrar.Text = "Eliminar Destino";
            this.btbBorrar.UseVisualStyleBackColor = false;
            this.btbBorrar.Click += new System.EventHandler(this.btbBorrar_Click_1);
            // 
            // DestinoBorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbBorrar);
            this.Controls.Add(this.dgvBorrarDestino);
            this.Name = "DestinoBorrar";
            this.Text = "DestinoBorrar";
            this.Load += new System.EventHandler(this.DestinoBorrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DGV dgvBorrarDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbBorrar;
    }
}