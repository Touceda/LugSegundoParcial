namespace AerolineasInterfaz
{
    partial class VuelosFinalizados
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
            this.dgvVuelosFinalizados = new AerolineasInterfaz.DGV();
            this.btbVerTodo = new System.Windows.Forms.Button();
            this.btbOcupacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dgvVuelosFinalizados
            // 
            this.dgvVuelosFinalizados.Location = new System.Drawing.Point(12, 12);
            this.dgvVuelosFinalizados.Name = "dgvVuelosFinalizados";
            this.dgvVuelosFinalizados.Size = new System.Drawing.Size(436, 426);
            this.dgvVuelosFinalizados.TabIndex = 0;
            // 
            // btbVerTodo
            // 
            this.btbVerTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbVerTodo.Location = new System.Drawing.Point(464, 222);
            this.btbVerTodo.Name = "btbVerTodo";
            this.btbVerTodo.Size = new System.Drawing.Size(324, 216);
            this.btbVerTodo.TabIndex = 1;
            this.btbVerTodo.Text = "Ver todos los vuelos finalizados";
            this.btbVerTodo.UseVisualStyleBackColor = true;
            this.btbVerTodo.Click += new System.EventHandler(this.btbVerTodo_Click);
            // 
            // btbOcupacion
            // 
            this.btbOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbOcupacion.Location = new System.Drawing.Point(464, 12);
            this.btbOcupacion.Name = "btbOcupacion";
            this.btbOcupacion.Size = new System.Drawing.Size(324, 204);
            this.btbOcupacion.TabIndex = 2;
            this.btbOcupacion.Text = "Ver Vuelos finalizados con Ocupacion menor al 40%";
            this.btbOcupacion.UseVisualStyleBackColor = true;
            this.btbOcupacion.Click += new System.EventHandler(this.btbOcupacion_Click);
            // 
            // VuelosFinalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbOcupacion);
            this.Controls.Add(this.btbVerTodo);
            this.Controls.Add(this.dgvVuelosFinalizados);
            this.Name = "VuelosFinalizados";
            this.Text = "VuelosFinalizados";
            this.Load += new System.EventHandler(this.VuelosFinalizados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DGV dgvVuelosFinalizados;
        private System.Windows.Forms.Button btbVerTodo;
        private System.Windows.Forms.Button btbOcupacion;
    }
}