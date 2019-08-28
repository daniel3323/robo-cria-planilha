namespace RoboCriaPlanilha
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerarExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerarExcel
            // 
            this.btnGerarExcel.Location = new System.Drawing.Point(12, 12);
            this.btnGerarExcel.Name = "btnGerarExcel";
            this.btnGerarExcel.Size = new System.Drawing.Size(135, 63);
            this.btnGerarExcel.TabIndex = 0;
            this.btnGerarExcel.Text = "Gerar Relatório";
            this.btnGerarExcel.UseVisualStyleBackColor = true;
            this.btnGerarExcel.Click += new System.EventHandler(this.BtnGerarExcel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(162, 87);
            this.Controls.Add(this.btnGerarExcel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarExcel;
    }
}

