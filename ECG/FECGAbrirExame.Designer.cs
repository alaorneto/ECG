﻿namespace ECG
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxSelecionarArquivo = new System.Windows.Forms.GroupBox();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.textBoxArquivo = new System.Windows.Forms.TextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ondaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxSelecionarArquivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ondaChart)).BeginInit();
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
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(5, 120);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(609, 123);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ondaChart
            // 
            chartArea1.Name = "OndaChartArea";
            this.ondaChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.ondaChart.Legends.Add(legend1);
            this.ondaChart.Location = new System.Drawing.Point(5, 250);
            this.ondaChart.Name = "ondaChart";
            series1.ChartArea = "OndaChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "OndaSeries";
            this.ondaChart.Series.Add(series1);
            this.ondaChart.Size = new System.Drawing.Size(600, 165);
            this.ondaChart.TabIndex = 2;
            this.ondaChart.Text = "Onda";
            // 
            // FECGAbrirExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(618, 429);
            this.Controls.Add(this.ondaChart);
            this.Controls.Add(this.picBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ondaChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelecionarArquivo;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.TextBox textBoxArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ondaChart;
        private System.Windows.Forms.Button SalvarButton;
    }
}