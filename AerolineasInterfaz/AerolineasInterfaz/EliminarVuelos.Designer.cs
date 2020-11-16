namespace AerolineasInterfaz
{
    partial class EliminarVuelos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btbBorrarC = new System.Windows.Forms.Button();
            this.btbBorrarI = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBorrarVC = new AerolineasInterfaz.DGV();
            this.dgvBorrarVI = new AerolineasInterfaz.DGV();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(460, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y precione el boton para darle de baja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccione un Vuelo";
            // 
            // btbBorrarC
            // 
            this.btbBorrarC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btbBorrarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbBorrarC.Location = new System.Drawing.Point(12, 505);
            this.btbBorrarC.Name = "btbBorrarC";
            this.btbBorrarC.Size = new System.Drawing.Size(436, 78);
            this.btbBorrarC.TabIndex = 12;
            this.btbBorrarC.Text = "Eliminar Vuelo Comun";
            this.btbBorrarC.UseVisualStyleBackColor = false;
            this.btbBorrarC.Click += new System.EventHandler(this.btbBorrarC_Click);
            // 
            // btbBorrarI
            // 
            this.btbBorrarI.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btbBorrarI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbBorrarI.Location = new System.Drawing.Point(506, 505);
            this.btbBorrarI.Name = "btbBorrarI";
            this.btbBorrarI.Size = new System.Drawing.Size(436, 78);
            this.btbBorrarI.TabIndex = 16;
            this.btbBorrarI.Text = "Eliminar Vuelo Internacional";
            this.btbBorrarI.UseVisualStyleBackColor = false;
            this.btbBorrarI.Click += new System.EventHandler(this.btbBorrarI_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(183, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Comunes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(666, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Internacionales";
            // 
            // dgvBorrarVC
            // 
            this.dgvBorrarVC.Location = new System.Drawing.Point(12, 73);
            this.dgvBorrarVC.Name = "dgvBorrarVC";
            this.dgvBorrarVC.Size = new System.Drawing.Size(436, 426);
            this.dgvBorrarVC.TabIndex = 19;
            // 
            // dgvBorrarVI
            // 
            this.dgvBorrarVI.Location = new System.Drawing.Point(506, 73);
            this.dgvBorrarVI.Name = "dgvBorrarVI";
            this.dgvBorrarVI.Size = new System.Drawing.Size(436, 426);
            this.dgvBorrarVI.TabIndex = 20;
            // 
            // EliminarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(950, 590);
            this.Controls.Add(this.dgvBorrarVI);
            this.Controls.Add(this.dgvBorrarVC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btbBorrarI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbBorrarC);
            this.Name = "EliminarVuelos";
            this.Text = "EliminarVueloComun";
            this.Load += new System.EventHandler(this.EliminarVueloComun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbBorrarC;
        private System.Windows.Forms.Button btbBorrarI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DGV dgvBorrarVC;
        private DGV dgvBorrarVI;
    }
}