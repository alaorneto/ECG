﻿namespace ECG
{
    partial class FECGIniciarTreinamento
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
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.comboBoxOnda = new System.Windows.Forms.ComboBox();
            this.labelOnda = new System.Windows.Forms.Label();
            this.buttonTreinar = new System.Windows.Forms.Button();
            this.textBoxTaxaErro = new System.Windows.Forms.TextBox();
            this.labelTaxaErro = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxChart = new System.Windows.Forms.GroupBox();
            this.treinamentoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelIteracoes = new System.Windows.Forms.Label();
            this.labelTxErro = new System.Windows.Forms.Label();
            this.labelQtdeIteracoesResult = new System.Windows.Forms.Label();
            this.labelTxErroResult = new System.Windows.Forms.Label();
            this.groupBoxConfig.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoChart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.comboBoxOnda);
            this.groupBoxConfig.Controls.Add(this.labelOnda);
            this.groupBoxConfig.Controls.Add(this.buttonTreinar);
            this.groupBoxConfig.Controls.Add(this.textBoxTaxaErro);
            this.groupBoxConfig.Controls.Add(this.labelTaxaErro);
            this.groupBoxConfig.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(749, 70);
            this.groupBoxConfig.TabIndex = 0;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Opções";
            // 
            // comboBoxOnda
            // 
            this.comboBoxOnda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOnda.FormattingEnabled = true;
            this.comboBoxOnda.Items.AddRange(new object[] {
            "Complexo QRS",
            "Onda T"});
            this.comboBoxOnda.Location = new System.Drawing.Point(158, 37);
            this.comboBoxOnda.Name = "comboBoxOnda";
            this.comboBoxOnda.Size = new System.Drawing.Size(140, 23);
            this.comboBoxOnda.TabIndex = 4;
            // 
            // labelOnda
            // 
            this.labelOnda.AutoSize = true;
            this.labelOnda.Location = new System.Drawing.Point(155, 19);
            this.labelOnda.Name = "labelOnda";
            this.labelOnda.Size = new System.Drawing.Size(40, 15);
            this.labelOnda.TabIndex = 3;
            this.labelOnda.Text = "Onda:";
            // 
            // buttonTreinar
            // 
            this.buttonTreinar.Location = new System.Drawing.Point(668, 37);
            this.buttonTreinar.Name = "buttonTreinar";
            this.buttonTreinar.Size = new System.Drawing.Size(75, 23);
            this.buttonTreinar.TabIndex = 2;
            this.buttonTreinar.Text = "Treinar";
            this.buttonTreinar.UseVisualStyleBackColor = true;
            this.buttonTreinar.Click += new System.EventHandler(this.buttonTreinar_Click);
            // 
            // textBoxTaxaErro
            // 
            this.textBoxTaxaErro.Location = new System.Drawing.Point(9, 37);
            this.textBoxTaxaErro.Name = "textBoxTaxaErro";
            this.textBoxTaxaErro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTaxaErro.Size = new System.Drawing.Size(140, 23);
            this.textBoxTaxaErro.TabIndex = 1;
            // 
            // labelTaxaErro
            // 
            this.labelTaxaErro.AutoSize = true;
            this.labelTaxaErro.Location = new System.Drawing.Point(6, 19);
            this.labelTaxaErro.Name = "labelTaxaErro";
            this.labelTaxaErro.Size = new System.Drawing.Size(77, 15);
            this.labelTaxaErro.TabIndex = 0;
            this.labelTaxaErro.Text = "Taxa de Erro:";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelTxErroResult);
            this.groupBoxInfo.Controls.Add(this.labelQtdeIteracoesResult);
            this.groupBoxInfo.Controls.Add(this.labelTxErro);
            this.groupBoxInfo.Controls.Add(this.labelIteracoes);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 88);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(749, 70);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Informações";
            // 
            // groupBoxChart
            // 
            this.groupBoxChart.Controls.Add(this.treinamentoChart);
            this.groupBoxChart.Location = new System.Drawing.Point(12, 164);
            this.groupBoxChart.Name = "groupBoxChart";
            this.groupBoxChart.Size = new System.Drawing.Size(749, 265);
            this.groupBoxChart.TabIndex = 2;
            this.groupBoxChart.TabStop = false;
            this.groupBoxChart.Text = "Gráfico";
            // 
            // treinamentoChart
            // 
            chartArea1.Name = "OndaChartArea";
            this.treinamentoChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.treinamentoChart.Legends.Add(legend1);
            this.treinamentoChart.Location = new System.Drawing.Point(6, 22);
            this.treinamentoChart.Name = "treinamentoChart";
            series1.ChartArea = "OndaChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "OndaSeries";
            this.treinamentoChart.Series.Add(series1);
            this.treinamentoChart.Size = new System.Drawing.Size(737, 237);
            this.treinamentoChart.TabIndex = 3;
            this.treinamentoChart.Text = "Treinamento";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(686, 438);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelIteracoes
            // 
            this.labelIteracoes.AutoSize = true;
            this.labelIteracoes.Location = new System.Drawing.Point(6, 21);
            this.labelIteracoes.Name = "labelIteracoes";
            this.labelIteracoes.Size = new System.Drawing.Size(144, 15);
            this.labelIteracoes.TabIndex = 0;
            this.labelIteracoes.Text = "Quantidade de Iterações:";
            // 
            // labelTxErro
            // 
            this.labelTxErro.AutoSize = true;
            this.labelTxErro.Location = new System.Drawing.Point(6, 46);
            this.labelTxErro.Name = "labelTxErro";
            this.labelTxErro.Size = new System.Drawing.Size(77, 15);
            this.labelTxErro.TabIndex = 1;
            this.labelTxErro.Text = "Taxa de Erro:";
            // 
            // labelQtdeIteracoesResult
            // 
            this.labelQtdeIteracoesResult.AutoSize = true;
            this.labelQtdeIteracoesResult.Location = new System.Drawing.Point(156, 21);
            this.labelQtdeIteracoesResult.Name = "labelQtdeIteracoesResult";
            this.labelQtdeIteracoesResult.Size = new System.Drawing.Size(14, 15);
            this.labelQtdeIteracoesResult.TabIndex = 2;
            this.labelQtdeIteracoesResult.Text = "0";
            // 
            // labelTxErroResult
            // 
            this.labelTxErroResult.AutoSize = true;
            this.labelTxErroResult.Location = new System.Drawing.Point(156, 46);
            this.labelTxErroResult.Name = "labelTxErroResult";
            this.labelTxErroResult.Size = new System.Drawing.Size(24, 15);
            this.labelTxErroResult.TabIndex = 3;
            this.labelTxErroResult.Text = "0.0";
            // 
            // FECGIniciarTreinamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 471);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxChart);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxConfig);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FECGIniciarTreinamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Treinamento";
            this.Load += new System.EventHandler(this.FECGIniciarTreinamento_Load);
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart treinamentoChart;
        private System.Windows.Forms.TextBox textBoxTaxaErro;
        private System.Windows.Forms.Label labelTaxaErro;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboBoxOnda;
        private System.Windows.Forms.Label labelOnda;
        private System.Windows.Forms.Button buttonTreinar;
        private System.Windows.Forms.Label labelTxErroResult;
        private System.Windows.Forms.Label labelQtdeIteracoesResult;
        private System.Windows.Forms.Label labelTxErro;
        private System.Windows.Forms.Label labelIteracoes;
    }
}