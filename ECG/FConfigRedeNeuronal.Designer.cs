namespace ECG
{
    partial class FConfigRedeNeuronal
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
            this.buttonQRSSalvar = new System.Windows.Forms.Button();
            this.textBoxQRSNeuronios = new System.Windows.Forms.TextBox();
            this.textBoxQRSEntradas = new System.Windows.Forms.TextBox();
            this.textBoxQRSDesc = new System.Windows.Forms.TextBox();
            this.labelQRSNeuronios = new System.Windows.Forms.Label();
            this.labelQRSEntradas = new System.Windows.Forms.Label();
            this.labelQRSDesc = new System.Windows.Forms.Label();
            this.labelQRSConfig = new System.Windows.Forms.Label();
            this.labelQRSSalvas = new System.Windows.Forms.Label();
            this.comboBoxQRS = new System.Windows.Forms.ComboBox();
            this.buttonQRSCarregar = new System.Windows.Forms.Button();
            this.groupBoxT = new System.Windows.Forms.GroupBox();
            this.buttonTSalvar = new System.Windows.Forms.Button();
            this.textBoxTNeuronios = new System.Windows.Forms.TextBox();
            this.textBoxTEntradas = new System.Windows.Forms.TextBox();
            this.textBoxTDesc = new System.Windows.Forms.TextBox();
            this.labelTNeuronios = new System.Windows.Forms.Label();
            this.labelTEntradas = new System.Windows.Forms.Label();
            this.labelTDesc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTSalvas = new System.Windows.Forms.Label();
            this.comboBoxT = new System.Windows.Forms.ComboBox();
            this.buttonTCarregar = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBoxQRS.SuspendLayout();
            this.groupBoxT.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxQRS
            // 
            this.groupBoxQRS.Controls.Add(this.buttonQRSSalvar);
            this.groupBoxQRS.Controls.Add(this.textBoxQRSNeuronios);
            this.groupBoxQRS.Controls.Add(this.textBoxQRSEntradas);
            this.groupBoxQRS.Controls.Add(this.textBoxQRSDesc);
            this.groupBoxQRS.Controls.Add(this.labelQRSNeuronios);
            this.groupBoxQRS.Controls.Add(this.labelQRSEntradas);
            this.groupBoxQRS.Controls.Add(this.labelQRSDesc);
            this.groupBoxQRS.Controls.Add(this.labelQRSConfig);
            this.groupBoxQRS.Controls.Add(this.labelQRSSalvas);
            this.groupBoxQRS.Controls.Add(this.comboBoxQRS);
            this.groupBoxQRS.Controls.Add(this.buttonQRSCarregar);
            this.groupBoxQRS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxQRS.Name = "groupBoxQRS";
            this.groupBoxQRS.Size = new System.Drawing.Size(520, 165);
            this.groupBoxQRS.TabIndex = 0;
            this.groupBoxQRS.TabStop = false;
            this.groupBoxQRS.Text = "Redes do Complexo QRS";
            // 
            // buttonQRSSalvar
            // 
            this.buttonQRSSalvar.Location = new System.Drawing.Point(438, 125);
            this.buttonQRSSalvar.Name = "buttonQRSSalvar";
            this.buttonQRSSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonQRSSalvar.TabIndex = 10;
            this.buttonQRSSalvar.Text = "Salvar";
            this.buttonQRSSalvar.UseVisualStyleBackColor = true;
            this.buttonQRSSalvar.Click += new System.EventHandler(this.buttonQRSSalvar_Click);
            // 
            // textBoxQRSNeuronios
            // 
            this.textBoxQRSNeuronios.Location = new System.Drawing.Point(345, 96);
            this.textBoxQRSNeuronios.Name = "textBoxQRSNeuronios";
            this.textBoxQRSNeuronios.Size = new System.Drawing.Size(168, 23);
            this.textBoxQRSNeuronios.TabIndex = 9;
            // 
            // textBoxQRSEntradas
            // 
            this.textBoxQRSEntradas.Location = new System.Drawing.Point(208, 96);
            this.textBoxQRSEntradas.Name = "textBoxQRSEntradas";
            this.textBoxQRSEntradas.Size = new System.Drawing.Size(131, 23);
            this.textBoxQRSEntradas.TabIndex = 8;
            // 
            // textBoxQRSDesc
            // 
            this.textBoxQRSDesc.Location = new System.Drawing.Point(9, 96);
            this.textBoxQRSDesc.Name = "textBoxQRSDesc";
            this.textBoxQRSDesc.Size = new System.Drawing.Size(193, 23);
            this.textBoxQRSDesc.TabIndex = 7;
            // 
            // labelQRSNeuronios
            // 
            this.labelQRSNeuronios.AutoSize = true;
            this.labelQRSNeuronios.Location = new System.Drawing.Point(342, 78);
            this.labelQRSNeuronios.Name = "labelQRSNeuronios";
            this.labelQRSNeuronios.Size = new System.Drawing.Size(171, 15);
            this.labelQRSNeuronios.TabIndex = 6;
            this.labelQRSNeuronios.Text = "Neurônios (separados por \";\")";
            // 
            // labelQRSEntradas
            // 
            this.labelQRSEntradas.AutoSize = true;
            this.labelQRSEntradas.Location = new System.Drawing.Point(205, 78);
            this.labelQRSEntradas.Name = "labelQRSEntradas";
            this.labelQRSEntradas.Size = new System.Drawing.Size(59, 15);
            this.labelQRSEntradas.TabIndex = 5;
            this.labelQRSEntradas.Text = "Entradas:";
            // 
            // labelQRSDesc
            // 
            this.labelQRSDesc.AutoSize = true;
            this.labelQRSDesc.Location = new System.Drawing.Point(6, 78);
            this.labelQRSDesc.Name = "labelQRSDesc";
            this.labelQRSDesc.Size = new System.Drawing.Size(65, 15);
            this.labelQRSDesc.TabIndex = 4;
            this.labelQRSDesc.Text = "Descrição:";
            // 
            // labelQRSConfig
            // 
            this.labelQRSConfig.AutoSize = true;
            this.labelQRSConfig.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQRSConfig.Location = new System.Drawing.Point(6, 63);
            this.labelQRSConfig.Name = "labelQRSConfig";
            this.labelQRSConfig.Size = new System.Drawing.Size(108, 15);
            this.labelQRSConfig.TabIndex = 3;
            this.labelQRSConfig.Text = "Nova Configuração";
            // 
            // labelQRSSalvas
            // 
            this.labelQRSSalvas.AutoSize = true;
            this.labelQRSSalvas.Location = new System.Drawing.Point(6, 19);
            this.labelQRSSalvas.Name = "labelQRSSalvas";
            this.labelQRSSalvas.Size = new System.Drawing.Size(119, 15);
            this.labelQRSSalvas.TabIndex = 2;
            this.labelQRSSalvas.Text = "Redes Armazenadas:";
            // 
            // comboBoxQRS
            // 
            this.comboBoxQRS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQRS.FormattingEnabled = true;
            this.comboBoxQRS.Location = new System.Drawing.Point(9, 37);
            this.comboBoxQRS.Name = "comboBoxQRS";
            this.comboBoxQRS.Size = new System.Drawing.Size(423, 23);
            this.comboBoxQRS.TabIndex = 1;
            // 
            // buttonQRSCarregar
            // 
            this.buttonQRSCarregar.Location = new System.Drawing.Point(438, 36);
            this.buttonQRSCarregar.Name = "buttonQRSCarregar";
            this.buttonQRSCarregar.Size = new System.Drawing.Size(75, 23);
            this.buttonQRSCarregar.TabIndex = 0;
            this.buttonQRSCarregar.Text = "Carregar";
            this.buttonQRSCarregar.UseVisualStyleBackColor = true;
            this.buttonQRSCarregar.Click += new System.EventHandler(this.buttonQRSCarregar_Click);
            // 
            // groupBoxT
            // 
            this.groupBoxT.Controls.Add(this.buttonTSalvar);
            this.groupBoxT.Controls.Add(this.textBoxTNeuronios);
            this.groupBoxT.Controls.Add(this.textBoxTEntradas);
            this.groupBoxT.Controls.Add(this.textBoxTDesc);
            this.groupBoxT.Controls.Add(this.labelTNeuronios);
            this.groupBoxT.Controls.Add(this.labelTEntradas);
            this.groupBoxT.Controls.Add(this.labelTDesc);
            this.groupBoxT.Controls.Add(this.label4);
            this.groupBoxT.Controls.Add(this.labelTSalvas);
            this.groupBoxT.Controls.Add(this.comboBoxT);
            this.groupBoxT.Controls.Add(this.buttonTCarregar);
            this.groupBoxT.Location = new System.Drawing.Point(12, 183);
            this.groupBoxT.Name = "groupBoxT";
            this.groupBoxT.Size = new System.Drawing.Size(520, 165);
            this.groupBoxT.TabIndex = 1;
            this.groupBoxT.TabStop = false;
            this.groupBoxT.Text = "Redes da Onda T";
            // 
            // buttonTSalvar
            // 
            this.buttonTSalvar.Location = new System.Drawing.Point(439, 126);
            this.buttonTSalvar.Name = "buttonTSalvar";
            this.buttonTSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonTSalvar.TabIndex = 18;
            this.buttonTSalvar.Text = "Salvar";
            this.buttonTSalvar.UseVisualStyleBackColor = true;
            this.buttonTSalvar.Click += new System.EventHandler(this.buttonTSalvar_Click);
            // 
            // textBoxTNeuronios
            // 
            this.textBoxTNeuronios.Location = new System.Drawing.Point(346, 97);
            this.textBoxTNeuronios.Name = "textBoxTNeuronios";
            this.textBoxTNeuronios.Size = new System.Drawing.Size(168, 23);
            this.textBoxTNeuronios.TabIndex = 17;
            // 
            // textBoxTEntradas
            // 
            this.textBoxTEntradas.Location = new System.Drawing.Point(209, 97);
            this.textBoxTEntradas.Name = "textBoxTEntradas";
            this.textBoxTEntradas.Size = new System.Drawing.Size(131, 23);
            this.textBoxTEntradas.TabIndex = 16;
            // 
            // textBoxTDesc
            // 
            this.textBoxTDesc.Location = new System.Drawing.Point(10, 97);
            this.textBoxTDesc.Name = "textBoxTDesc";
            this.textBoxTDesc.Size = new System.Drawing.Size(193, 23);
            this.textBoxTDesc.TabIndex = 15;
            // 
            // labelTNeuronios
            // 
            this.labelTNeuronios.AutoSize = true;
            this.labelTNeuronios.Location = new System.Drawing.Point(343, 79);
            this.labelTNeuronios.Name = "labelTNeuronios";
            this.labelTNeuronios.Size = new System.Drawing.Size(171, 15);
            this.labelTNeuronios.TabIndex = 14;
            this.labelTNeuronios.Text = "Neurônios (separados por \";\")";
            // 
            // labelTEntradas
            // 
            this.labelTEntradas.AutoSize = true;
            this.labelTEntradas.Location = new System.Drawing.Point(206, 79);
            this.labelTEntradas.Name = "labelTEntradas";
            this.labelTEntradas.Size = new System.Drawing.Size(59, 15);
            this.labelTEntradas.TabIndex = 13;
            this.labelTEntradas.Text = "Entradas:";
            // 
            // labelTDesc
            // 
            this.labelTDesc.AutoSize = true;
            this.labelTDesc.Location = new System.Drawing.Point(7, 79);
            this.labelTDesc.Name = "labelTDesc";
            this.labelTDesc.Size = new System.Drawing.Size(65, 15);
            this.labelTDesc.TabIndex = 12;
            this.labelTDesc.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nova Configuração";
            // 
            // labelTSalvas
            // 
            this.labelTSalvas.AutoSize = true;
            this.labelTSalvas.Location = new System.Drawing.Point(6, 19);
            this.labelTSalvas.Name = "labelTSalvas";
            this.labelTSalvas.Size = new System.Drawing.Size(119, 15);
            this.labelTSalvas.TabIndex = 2;
            this.labelTSalvas.Text = "Redes Armazenadas:";
            // 
            // comboBoxT
            // 
            this.comboBoxT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxT.FormattingEnabled = true;
            this.comboBoxT.Location = new System.Drawing.Point(9, 38);
            this.comboBoxT.Name = "comboBoxT";
            this.comboBoxT.Size = new System.Drawing.Size(423, 23);
            this.comboBoxT.TabIndex = 1;
            // 
            // buttonTCarregar
            // 
            this.buttonTCarregar.Location = new System.Drawing.Point(438, 37);
            this.buttonTCarregar.Name = "buttonTCarregar";
            this.buttonTCarregar.Size = new System.Drawing.Size(75, 23);
            this.buttonTCarregar.TabIndex = 0;
            this.buttonTCarregar.Text = "Carregar";
            this.buttonTCarregar.UseVisualStyleBackColor = true;
            this.buttonTCarregar.Click += new System.EventHandler(this.buttonTCarregar_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(456, 361);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(375, 361);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FConfigRedeNeuronal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 394);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxT);
            this.Controls.Add(this.groupBoxQRS);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FConfigRedeNeuronal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações de Rede Neuronal";
            this.Load += new System.EventHandler(this.FConfigRedeNeuronal_Load);
            this.groupBoxQRS.ResumeLayout(false);
            this.groupBoxQRS.PerformLayout();
            this.groupBoxT.ResumeLayout(false);
            this.groupBoxT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxQRS;
        private System.Windows.Forms.Label labelQRSSalvas;
        private System.Windows.Forms.ComboBox comboBoxQRS;
        private System.Windows.Forms.Button buttonQRSCarregar;
        private System.Windows.Forms.GroupBox groupBoxT;
        private System.Windows.Forms.Label labelTSalvas;
        private System.Windows.Forms.ComboBox comboBoxT;
        private System.Windows.Forms.Button buttonTCarregar;
        private System.Windows.Forms.Button buttonQRSSalvar;
        private System.Windows.Forms.TextBox textBoxQRSNeuronios;
        private System.Windows.Forms.TextBox textBoxQRSEntradas;
        private System.Windows.Forms.TextBox textBoxQRSDesc;
        private System.Windows.Forms.Label labelQRSNeuronios;
        private System.Windows.Forms.Label labelQRSEntradas;
        private System.Windows.Forms.Label labelQRSDesc;
        private System.Windows.Forms.Label labelQRSConfig;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonTSalvar;
        private System.Windows.Forms.TextBox textBoxTNeuronios;
        private System.Windows.Forms.TextBox textBoxTEntradas;
        private System.Windows.Forms.TextBox textBoxTDesc;
        private System.Windows.Forms.Label labelTNeuronios;
        private System.Windows.Forms.Label labelTEntradas;
        private System.Windows.Forms.Label labelTDesc;
        private System.Windows.Forms.Label label4;
    }
}