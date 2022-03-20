namespace Calculadora3._0
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuPrin = new System.Windows.Forms.ToolStripMenuItem();
            this.sairStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.calcStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moedaStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuPrin,
            this.toolStripMenuCalc,
            this.toolStripMenuSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuPrin
            // 
            this.toolStripMenuPrin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairStripMenuItem1});
            this.toolStripMenuPrin.Name = "toolStripMenuPrin";
            this.toolStripMenuPrin.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuPrin.Text = "Principal";
            // 
            // sairStripMenuItem1
            // 
            this.sairStripMenuItem1.Image = global::Calculadora3._0.Properties.Resources.Sair;
            this.sairStripMenuItem1.Name = "sairStripMenuItem1";
            this.sairStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.sairStripMenuItem1.Text = "Sair";
            this.sairStripMenuItem1.Click += new System.EventHandler(this.sairStripMenuItem1_Click);
            // 
            // toolStripMenuCalc
            // 
            this.toolStripMenuCalc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcStripMenuItem,
            this.convertStripMenuItem});
            this.toolStripMenuCalc.Name = "toolStripMenuCalc";
            this.toolStripMenuCalc.Size = new System.Drawing.Size(87, 20);
            this.toolStripMenuCalc.Text = "Calculadoras";
            // 
            // calcStripMenuItem
            // 
            this.calcStripMenuItem.Image = global::Calculadora3._0.Properties.Resources.Calculadora;
            this.calcStripMenuItem.Name = "calcStripMenuItem";
            this.calcStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calcStripMenuItem.Text = "Calculadora";
            this.calcStripMenuItem.Click += new System.EventHandler(this.calcStripMenuItem_Click);
            // 
            // convertStripMenuItem
            // 
            this.convertStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moedaStripMenuItem});
            this.convertStripMenuItem.Image = global::Calculadora3._0.Properties.Resources.Converte;
            this.convertStripMenuItem.Name = "convertStripMenuItem";
            this.convertStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convertStripMenuItem.Text = "Conversor";
            // 
            // moedaStripMenuItem
            // 
            this.moedaStripMenuItem.Image = global::Calculadora3._0.Properties.Resources.Moeda;
            this.moedaStripMenuItem.Name = "moedaStripMenuItem";
            this.moedaStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moedaStripMenuItem.Text = "Moeda";
            this.moedaStripMenuItem.Click += new System.EventHandler(this.moedaStripMenuItem_Click);
            // 
            // toolStripMenuSobre
            // 
            this.toolStripMenuSobre.Name = "toolStripMenuSobre";
            this.toolStripMenuSobre.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuSobre.Text = "Sobre";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(80, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(601, 299);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Calculadora 3.0 Tudo que você precisa";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuPrin;
        private ToolStripMenuItem toolStripMenuCalc;
        private ToolStripMenuItem toolStripMenuSobre;
        private ToolStripMenuItem sairStripMenuItem1;
        private ToolStripMenuItem calcStripMenuItem;
        private ToolStripMenuItem convertStripMenuItem;
        private ToolStripMenuItem moedaStripMenuItem;
        private TextBox textBox1;
    }
}