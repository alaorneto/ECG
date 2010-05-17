namespace ECG
{
    partial class FECGSalvarExame
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
            this.groupBoxQRS = new System.Windows.Forms.GroupBox();
            this.comboBoxQRS = new System.Windows.Forms.ComboBox();
            this.textBoxQRS = new System.Windows.Forms.TextBox();
            this.labelQRSReal = new System.Windows.Forms.Label();
            this.labelQRSSugerido = new System.Windows.Forms.Label();
            this.groupBoxT = new System.Windows.Forms.GroupBox();
            this.comboBoxT = new System.Windows.Forms.ComboBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.labelTReal = new System.Windows.Forms.Label();
            this.labelTSugerido = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBoxQRS.SuspendLayout();
            this.groupBoxT.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxQRS
            // 
            this.groupBoxQRS.Controls.Add(this.comboBoxQRS);
            this.groupBoxQRS.Controls.Add(this.textBoxQRS);
            this.groupBoxQRS.Controls.Add(this.labelQRSReal);
            this.groupBoxQRS.Controls.Add(this.labelQRSSugerido);
            this.groupBoxQRS.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxQRS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxQRS.Name = "groupBoxQRS";
            this.groupBoxQRS.Size = new System.Drawing.Size(482, 100);
            this.groupBoxQRS.TabIndex = 0;
            this.groupBoxQRS.TabStop = false;
            this.groupBoxQRS.Text = "Diagnóstico do Complexo QRS";
            // 
            // comboBoxQRS
            // 
            this.comboBoxQRS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQRS.FormattingEnabled = true;
            this.comboBoxQRS.Location = new System.Drawing.Point(253, 47);
            this.comboBoxQRS.Name = "comboBoxQRS";
            this.comboBoxQRS.Size = new System.Drawing.Size(220, 23);
            this.comboBoxQRS.TabIndex = 3;
            // 
            // textBoxQRS
            // 
            this.textBoxQRS.Location = new System.Drawing.Point(9, 47);
            this.textBoxQRS.Name = "textBoxQRS";
            this.textBoxQRS.ReadOnly = true;
            this.textBoxQRS.Size = new System.Drawing.Size(220, 23);
            this.textBoxQRS.TabIndex = 2;
            // 
            // labelQRSReal
            // 
            this.labelQRSReal.AutoSize = true;
            this.labelQRSReal.Location = new System.Drawing.Point(250, 29);
            this.labelQRSReal.Name = "labelQRSReal";
            this.labelQRSReal.Size = new System.Drawing.Size(102, 15);
            this.labelQRSReal.TabIndex = 1;
            this.labelQRSReal.Text = "Diagnóstico Real:";
            // 
            // labelQRSSugerido
            // 
            this.labelQRSSugerido.AutoSize = true;
            this.labelQRSSugerido.Location = new System.Drawing.Point(6, 29);
            this.labelQRSSugerido.Name = "labelQRSSugerido";
            this.labelQRSSugerido.Size = new System.Drawing.Size(126, 15);
            this.labelQRSSugerido.TabIndex = 0;
            this.labelQRSSugerido.Text = "Diagnóstico Sugerido:";
            // 
            // groupBoxT
            // 
            this.groupBoxT.Controls.Add(this.comboBoxT);
            this.groupBoxT.Controls.Add(this.textBoxT);
            this.groupBoxT.Controls.Add(this.labelTReal);
            this.groupBoxT.Controls.Add(this.labelTSugerido);
            this.groupBoxT.Location = new System.Drawing.Point(12, 118);
            this.groupBoxT.Name = "groupBoxT";
            this.groupBoxT.Size = new System.Drawing.Size(482, 100);
            this.groupBoxT.TabIndex = 1;
            this.groupBoxT.TabStop = false;
            this.groupBoxT.Text = "Diagnóstico da Onda T";
            // 
            // comboBoxT
            // 
            this.comboBoxT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxT.FormattingEnabled = true;
            this.comboBoxT.Location = new System.Drawing.Point(253, 47);
            this.comboBoxT.Name = "comboBoxT";
            this.comboBoxT.Size = new System.Drawing.Size(220, 23);
            this.comboBoxT.TabIndex = 3;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(9, 47);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.ReadOnly = true;
            this.textBoxT.Size = new System.Drawing.Size(220, 23);
            this.textBoxT.TabIndex = 2;
            // 
            // labelTReal
            // 
            this.labelTReal.AutoSize = true;
            this.labelTReal.Location = new System.Drawing.Point(250, 29);
            this.labelTReal.Name = "labelTReal";
            this.labelTReal.Size = new System.Drawing.Size(102, 15);
            this.labelTReal.TabIndex = 1;
            this.labelTReal.Text = "Diagnóstico Real:";
            // 
            // labelTSugerido
            // 
            this.labelTSugerido.AutoSize = true;
            this.labelTSugerido.Location = new System.Drawing.Point(6, 29);
            this.labelTSugerido.Name = "labelTSugerido";
            this.labelTSugerido.Size = new System.Drawing.Size(126, 15);
            this.labelTSugerido.TabIndex = 0;
            this.labelTSugerido.Text = "Diagnóstico Sugerido:";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(419, 224);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(338, 224);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FECGSalvarExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 257);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.groupBoxT);
            this.Controls.Add(this.groupBoxQRS);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FECGSalvarExame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salvar Exame";
            this.Load += new System.EventHandler(this.FECGSalvarExame_Load);
            this.groupBoxQRS.ResumeLayout(false);
            this.groupBoxQRS.PerformLayout();
            this.groupBoxT.ResumeLayout(false);
            this.groupBoxT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxQRS;
        private System.Windows.Forms.GroupBox groupBoxT;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.ComboBox comboBoxQRS;
        private System.Windows.Forms.TextBox textBoxQRS;
        private System.Windows.Forms.Label labelQRSReal;
        private System.Windows.Forms.Label labelQRSSugerido;
        private System.Windows.Forms.ComboBox comboBoxT;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.Label labelTReal;
        private System.Windows.Forms.Label labelTSugerido;
        private System.Windows.Forms.Button buttonCancelar;
    }
}