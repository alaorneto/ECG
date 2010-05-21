namespace ECG
{
    partial class FDetalhaOndas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxQRS1 = new System.Windows.Forms.GroupBox();
            this.groupBoxQRS2 = new System.Windows.Forms.GroupBox();
            this.groupBoxT2 = new System.Windows.Forms.GroupBox();
            this.groupBoxT1 = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.chartQRS1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartQRS2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartT1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartT2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxQRS1.SuspendLayout();
            this.groupBoxQRS2.SuspendLayout();
            this.groupBoxT2.SuspendLayout();
            this.groupBoxT1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQRS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQRS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartT2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxQRS1
            // 
            this.groupBoxQRS1.Controls.Add(this.chartQRS1);
            this.groupBoxQRS1.Location = new System.Drawing.Point(12, 12);
            this.groupBoxQRS1.Name = "groupBoxQRS1";
            this.groupBoxQRS1.Size = new System.Drawing.Size(300, 200);
            this.groupBoxQRS1.TabIndex = 0;
            this.groupBoxQRS1.TabStop = false;
            this.groupBoxQRS1.Text = "1º Complexo QRS";
            // 
            // groupBoxQRS2
            // 
            this.groupBoxQRS2.Controls.Add(this.chartQRS2);
            this.groupBoxQRS2.Location = new System.Drawing.Point(318, 12);
            this.groupBoxQRS2.Name = "groupBoxQRS2";
            this.groupBoxQRS2.Size = new System.Drawing.Size(300, 200);
            this.groupBoxQRS2.TabIndex = 1;
            this.groupBoxQRS2.TabStop = false;
            this.groupBoxQRS2.Text = "2º Complexo QRS";
            // 
            // groupBoxT2
            // 
            this.groupBoxT2.Controls.Add(this.chartT2);
            this.groupBoxT2.Location = new System.Drawing.Point(318, 218);
            this.groupBoxT2.Name = "groupBoxT2";
            this.groupBoxT2.Size = new System.Drawing.Size(300, 200);
            this.groupBoxT2.TabIndex = 2;
            this.groupBoxT2.TabStop = false;
            this.groupBoxT2.Text = "2ª Onda T";
            // 
            // groupBoxT1
            // 
            this.groupBoxT1.Controls.Add(this.chartT1);
            this.groupBoxT1.Location = new System.Drawing.Point(12, 218);
            this.groupBoxT1.Name = "groupBoxT1";
            this.groupBoxT1.Size = new System.Drawing.Size(300, 200);
            this.groupBoxT1.TabIndex = 3;
            this.groupBoxT1.TabStop = false;
            this.groupBoxT1.Text = "1ª Onda T";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(543, 424);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // chartQRS1
            // 
            chartArea5.Name = "OndaChartArea";
            this.chartQRS1.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chartQRS1.Legends.Add(legend5);
            this.chartQRS1.Location = new System.Drawing.Point(6, 22);
            this.chartQRS1.Name = "chartQRS1";
            series5.ChartArea = "OndaChartArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "OndaSeries";
            this.chartQRS1.Series.Add(series5);
            this.chartQRS1.Size = new System.Drawing.Size(288, 172);
            this.chartQRS1.TabIndex = 4;
            this.chartQRS1.Text = "Treinamento";
            // 
            // chartQRS2
            // 
            chartArea6.Name = "OndaChartArea";
            this.chartQRS2.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.chartQRS2.Legends.Add(legend6);
            this.chartQRS2.Location = new System.Drawing.Point(6, 22);
            this.chartQRS2.Name = "chartQRS2";
            series6.ChartArea = "OndaChartArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "OndaSeries";
            this.chartQRS2.Series.Add(series6);
            this.chartQRS2.Size = new System.Drawing.Size(288, 172);
            this.chartQRS2.TabIndex = 5;
            this.chartQRS2.Text = "Treinamento";
            // 
            // chartT1
            // 
            chartArea7.Name = "OndaChartArea";
            this.chartT1.ChartAreas.Add(chartArea7);
            legend7.Enabled = false;
            legend7.Name = "Legend1";
            this.chartT1.Legends.Add(legend7);
            this.chartT1.Location = new System.Drawing.Point(6, 22);
            this.chartT1.Name = "chartT1";
            series7.ChartArea = "OndaChartArea";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "OndaSeries";
            this.chartT1.Series.Add(series7);
            this.chartT1.Size = new System.Drawing.Size(288, 172);
            this.chartT1.TabIndex = 5;
            this.chartT1.Text = "Treinamento";
            // 
            // chartT2
            // 
            chartArea8.Name = "OndaChartArea";
            this.chartT2.ChartAreas.Add(chartArea8);
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.chartT2.Legends.Add(legend8);
            this.chartT2.Location = new System.Drawing.Point(6, 22);
            this.chartT2.Name = "chartT2";
            series8.ChartArea = "OndaChartArea";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "OndaSeries";
            this.chartT2.Series.Add(series8);
            this.chartT2.Size = new System.Drawing.Size(288, 172);
            this.chartT2.TabIndex = 6;
            this.chartT2.Text = "Treinamento";
            // 
            // FDetalhaOndas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 456);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxT1);
            this.Controls.Add(this.groupBoxT2);
            this.Controls.Add(this.groupBoxQRS2);
            this.Controls.Add(this.groupBoxQRS1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FDetalhaOndas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes das ondas";
            this.groupBoxQRS1.ResumeLayout(false);
            this.groupBoxQRS2.ResumeLayout(false);
            this.groupBoxT2.ResumeLayout(false);
            this.groupBoxT1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartQRS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQRS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartT2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxQRS1;
        private System.Windows.Forms.GroupBox groupBoxQRS2;
        private System.Windows.Forms.GroupBox groupBoxT2;
        private System.Windows.Forms.GroupBox groupBoxT1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQRS1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQRS2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartT2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartT1;
    }
}