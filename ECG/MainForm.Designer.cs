﻿namespace ECG
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripECG = new System.Windows.Forms.MenuStrip();
            this.ecgCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirExameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redeNeuronalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripECG = new System.Windows.Forms.StatusStrip();
            this.infoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripECG = new System.Windows.Forms.ToolStrip();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.iniciarTreinamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripECG.SuspendLayout();
            this.statusStripECG.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripECG
            // 
            this.menuStripECG.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripECG.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ecgCToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStripECG.Location = new System.Drawing.Point(0, 0);
            this.menuStripECG.Name = "menuStripECG";
            this.menuStripECG.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripECG.Size = new System.Drawing.Size(1100, 24);
            this.menuStripECG.TabIndex = 0;
            this.menuStripECG.Text = "menuStripECG";
            // 
            // ecgCToolStripMenuItem
            // 
            this.ecgCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirExameToolStripMenuItem,
            this.iniciarTreinamentoToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.ecgCToolStripMenuItem.Name = "ecgCToolStripMenuItem";
            this.ecgCToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.ecgCToolStripMenuItem.Text = "ECG";
            // 
            // abrirExameToolStripMenuItem
            // 
            this.abrirExameToolStripMenuItem.Name = "abrirExameToolStripMenuItem";
            this.abrirExameToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.abrirExameToolStripMenuItem.Text = "Abrir Exame";
            this.abrirExameToolStripMenuItem.Click += new System.EventHandler(this.abrirExameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redeNeuronalToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // redeNeuronalToolStripMenuItem
            // 
            this.redeNeuronalToolStripMenuItem.Name = "redeNeuronalToolStripMenuItem";
            this.redeNeuronalToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.redeNeuronalToolStripMenuItem.Text = "Rede Neuronal";
            this.redeNeuronalToolStripMenuItem.Click += new System.EventHandler(this.redeNeuronalToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // statusStripECG
            // 
            this.statusStripECG.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripECG.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripStatusLabel});
            this.statusStripECG.Location = new System.Drawing.Point(0, 620);
            this.statusStripECG.Name = "statusStripECG";
            this.statusStripECG.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStripECG.Size = new System.Drawing.Size(1100, 22);
            this.statusStripECG.TabIndex = 1;
            this.statusStripECG.Text = "statusStripECG";
            // 
            // infoToolStripStatusLabel
            // 
            this.infoToolStripStatusLabel.Name = "infoToolStripStatusLabel";
            this.infoToolStripStatusLabel.Size = new System.Drawing.Size(17, 17);
            this.infoToolStripStatusLabel.Text = "[]";
            // 
            // toolStripECG
            // 
            this.toolStripECG.Location = new System.Drawing.Point(0, 24);
            this.toolStripECG.Name = "toolStripECG";
            this.toolStripECG.Size = new System.Drawing.Size(1100, 25);
            this.toolStripECG.TabIndex = 2;
            this.toolStripECG.Text = "toolStripECG";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // iniciarTreinamentoToolStripMenuItem
            // 
            this.iniciarTreinamentoToolStripMenuItem.Name = "iniciarTreinamentoToolStripMenuItem";
            this.iniciarTreinamentoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.iniciarTreinamentoToolStripMenuItem.Text = "Iniciar Treinamento";
            this.iniciarTreinamentoToolStripMenuItem.Click += new System.EventHandler(this.iniciarTreinamentoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 642);
            this.Controls.Add(this.toolStripECG);
            this.Controls.Add(this.statusStripECG);
            this.Controls.Add(this.menuStripECG);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripECG;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECG";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripECG.ResumeLayout(false);
            this.menuStripECG.PerformLayout();
            this.statusStripECG.ResumeLayout(false);
            this.statusStripECG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripECG;
        private System.Windows.Forms.StatusStrip statusStripECG;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecgCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirExameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel infoToolStripStatusLabel;
        private System.Windows.Forms.ToolStrip toolStripECG;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redeNeuronalToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem iniciarTreinamentoToolStripMenuItem;
    }
}

