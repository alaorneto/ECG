namespace ECG
{
    partial class FECGAbrirExame
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxSelecionarArquivo = new System.Windows.Forms.GroupBox();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.textBoxArquivo = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ondaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxExame = new System.Windows.Forms.GroupBox();
            this.groupBoxDados = new System.Windows.Forms.GroupBox();
            this.labelFreqCard = new System.Windows.Forms.Label();
            this.labelFreqResult = new System.Windows.Forms.Label();
            this.labelDiagQRS = new System.Windows.Forms.Label();
            this.labelDiagQRSResult = new System.Windows.Forms.Label();
            this.labelDiagT = new System.Windows.Forms.Label();
            this.labelDiagTResult = new System.Windows.Forms.Label();
            this.groupBoxSelecionarArquivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ondaChart)).BeginInit();
            this.groupBoxExame.SuspendLayout();
            this.groupBoxDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSelecionarArquivo
            // 
            this.groupBoxSelecionarArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSelecionarArquivo.Controls.Add(this.SalvarButton);
            this.groupBoxSelecionarArquivo.Controls.Add(this.buttonSelecionar);
            this.groupBoxSelecionarArquivo.Controls.Add(this.buttonAbrir);
            this.groupBoxSelecionarArquivo.Controls.Add(this.textBoxArquivo);
            this.groupBoxSelecionarArquivo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSelecionarArquivo.Location = new System.Drawing.Point(14, 14);
            this.groupBoxSelecionarArquivo.Name = "groupBoxSelecionarArquivo";
            this.groupBoxSelecionarArquivo.Size = new System.Drawing.Size(590, 99);
            this.groupBoxSelecionarArquivo.TabIndex = 0;
            this.groupBoxSelecionarArquivo.TabStop = false;
            this.groupBoxSelecionarArquivo.Text = "Selecionar arquivo";
            // 
            // SalvarButton
            // 
            this.SalvarButton.Location = new System.Drawing.Point(401, 59);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(87, 27);
            this.SalvarButton.TabIndex = 3;
            this.SalvarButton.Text = "Salvar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar.Location = new System.Drawing.Point(496, 59);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(87, 27);
            this.buttonSelecionar.TabIndex = 2;
            this.buttonSelecionar.Text = "Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbrir.Location = new System.Drawing.Point(496, 25);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(87, 27);
            this.buttonAbrir.TabIndex = 1;
            this.buttonAbrir.Text = "Abrir...";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // textBoxArquivo
            // 
            this.textBoxArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArquivo.Location = new System.Drawing.Point(7, 24);
            this.textBoxArquivo.Name = "textBoxArquivo";
            this.textBoxArquivo.Size = new System.Drawing.Size(481, 23);
            this.textBoxArquivo.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ondaChart
            // 
            chartArea2.Name = "OndaChartArea";
            this.ondaChart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.ondaChart.Legends.Add(legend2);
            this.ondaChart.Location = new System.Drawing.Point(6, 22);
            this.ondaChart.Name = "ondaChart";
            series2.ChartArea = "OndaChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "OndaSeries";
            this.ondaChart.Series.Add(series2);
            this.ondaChart.Size = new System.Drawing.Size(577, 124);
            this.ondaChart.TabIndex = 2;
            this.ondaChart.Text = "Onda";
            // 
            // groupBoxExame
            // 
            this.groupBoxExame.Controls.Add(this.ondaChart);
            this.groupBoxExame.Location = new System.Drawing.Point(14, 119);
            this.groupBoxExame.Name = "groupBoxExame";
            this.groupBoxExame.Size = new System.Drawing.Size(592, 158);
            this.groupBoxExame.TabIndex = 3;
            this.groupBoxExame.TabStop = false;
            this.groupBoxExame.Text = "Exame";
            // 
            // groupBoxDados
            // 
            this.groupBoxDados.Controls.Add(this.labelDiagTResult);
            this.groupBoxDados.Controls.Add(this.labelDiagT);
            this.groupBoxDados.Controls.Add(this.labelDiagQRSResult);
            this.groupBoxDados.Controls.Add(this.labelDiagQRS);
            this.groupBoxDados.Controls.Add(this.labelFreqResult);
            this.groupBoxDados.Controls.Add(this.labelFreqCard);
            this.groupBoxDados.Location = new System.Drawing.Point(14, 283);
            this.groupBoxDados.Name = "groupBoxDados";
            this.groupBoxDados.Size = new System.Drawing.Size(592, 97);
            this.groupBoxDados.TabIndex = 4;
            this.groupBoxDados.TabStop = false;
            this.groupBoxDados.Text = "Dados";
            // 
            // labelFreqCard
            // 
            this.labelFreqCard.AutoSize = true;
            this.labelFreqCard.Location = new System.Drawing.Point(6, 19);
            this.labelFreqCard.Name = "labelFreqCard";
            this.labelFreqCard.Size = new System.Drawing.Size(123, 15);
            this.labelFreqCard.TabIndex = 0;
            this.labelFreqCard.Text = "Frequência Cardíaca:";
            // 
            // labelFreqResult
            // 
            this.labelFreqResult.AutoSize = true;
            this.labelFreqResult.Location = new System.Drawing.Point(197, 23);
            this.labelFreqResult.Name = "labelFreqResult";
            this.labelFreqResult.Size = new System.Drawing.Size(41, 15);
            this.labelFreqResult.TabIndex = 1;
            this.labelFreqResult.Text = "0 bpm";
            // 
            // labelDiagQRS
            // 
            this.labelDiagQRS.AutoSize = true;
            this.labelDiagQRS.Location = new System.Drawing.Point(6, 44);
            this.labelDiagQRS.Name = "labelDiagQRS";
            this.labelDiagQRS.Size = new System.Drawing.Size(157, 15);
            this.labelDiagQRS.TabIndex = 2;
            this.labelDiagQRS.Text = "Diagnóstico Complexo QRS:";
            // 
            // labelDiagQRSResult
            // 
            this.labelDiagQRSResult.AutoSize = true;
            this.labelDiagQRSResult.Location = new System.Drawing.Point(197, 44);
            this.labelDiagQRSResult.Name = "labelDiagQRSResult";
            this.labelDiagQRSResult.Size = new System.Drawing.Size(11, 15);
            this.labelDiagQRSResult.TabIndex = 3;
            this.labelDiagQRSResult.Text = "-";
            // 
            // labelDiagT
            // 
            this.labelDiagT.AutoSize = true;
            this.labelDiagT.Location = new System.Drawing.Point(6, 69);
            this.labelDiagT.Name = "labelDiagT";
            this.labelDiagT.Size = new System.Drawing.Size(116, 15);
            this.labelDiagT.TabIndex = 4;
            this.labelDiagT.Text = "Diagnóstico Onda T:";
            // 
            // labelDiagTResult
            // 
            this.labelDiagTResult.AutoSize = true;
            this.labelDiagTResult.Location = new System.Drawing.Point(197, 69);
            this.labelDiagTResult.Name = "labelDiagTResult";
            this.labelDiagTResult.Size = new System.Drawing.Size(11, 15);
            this.labelDiagTResult.TabIndex = 5;
            this.labelDiagTResult.Text = "-";
            // 
            // FECGAbrirExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(618, 390);
            this.Controls.Add(this.groupBoxDados);
            this.Controls.Add(this.groupBoxExame);
            this.Controls.Add(this.groupBoxSelecionarArquivo);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FECGAbrirExame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Exame";
            this.groupBoxSelecionarArquivo.ResumeLayout(false);
            this.groupBoxSelecionarArquivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ondaChart)).EndInit();
            this.groupBoxExame.ResumeLayout(false);
            this.groupBoxDados.ResumeLayout(false);
            this.groupBoxDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelecionarArquivo;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.TextBox textBoxArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ondaChart;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.GroupBox groupBoxExame;
        private System.Windows.Forms.GroupBox groupBoxDados;
        private System.Windows.Forms.Label labelFreqResult;
        private System.Windows.Forms.Label labelFreqCard;
        private System.Windows.Forms.Label labelDiagTResult;
        private System.Windows.Forms.Label labelDiagT;
        private System.Windows.Forms.Label labelDiagQRSResult;
        private System.Windows.Forms.Label labelDiagQRS;
    }
}