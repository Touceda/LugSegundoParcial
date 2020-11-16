namespace AerolineasInterfaz
{
    partial class ListadosInfo
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvInfo = new AerolineasInterfaz.DGV();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.Location = new System.Drawing.Point(12, 12);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.Size = new System.Drawing.Size(436, 426);
            this.dgvInfo.TabIndex = 0;
            // 
            // ListadosInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.dgvInfo);
            this.Name = "ListadosInfo";
            this.Text = "ListadosInfo";
            this.Load += new System.EventHandler(this.ListadosInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DGV dgvInfo;
    }
}