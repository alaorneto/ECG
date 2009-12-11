namespace ECG
{
    partial class FECFAbrirExame
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
            this.groupBoxSelecionarArquivo = new System.Windows.Forms.GroupBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxArquivo = new System.Windows.Forms.TextBox();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.groupBoxSelecionarArquivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSelecionarArquivo
            // 
            this.groupBoxSelecionarArquivo.Controls.Add(this.buttonAbrir);
            this.groupBoxSelecionarArquivo.Controls.Add(this.textBoxArquivo);
            this.groupBoxSelecionarArquivo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSelecionarArquivo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSelecionarArquivo.Name = "groupBoxSelecionarArquivo";
            this.groupBoxSelecionarArquivo.Size = new System.Drawing.Size(506, 54);
            this.groupBoxSelecionarArquivo.TabIndex = 0;
            this.groupBoxSelecionarArquivo.TabStop = false;
            this.groupBoxSelecionarArquivo.Text = "Selecionar arquivo";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(5, 72);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(522, 50);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // textBoxArquivo
            // 
            this.textBoxArquivo.Location = new System.Drawing.Point(6, 22);
            this.textBoxArquivo.Name = "textBoxArquivo";
            this.textBoxArquivo.Size = new System.Drawing.Size(413, 23);
            this.textBoxArquivo.TabIndex = 0;
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Location = new System.Drawing.Point(425, 22);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(75, 23);
            this.buttonAbrir.TabIndex = 1;
            this.buttonAbrir.Text = "Abrir...";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // FECFAbrirExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 130);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.groupBoxSelecionarArquivo);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FECFAbrirExame";
            this.Text = "Abrir Exame";
            this.groupBoxSelecionarArquivo.ResumeLayout(false);
            this.groupBoxSelecionarArquivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelecionarArquivo;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.TextBox textBoxArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}