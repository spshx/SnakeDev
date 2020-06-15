namespace SnakeDev
{
    partial class Gioco
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.punt = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giocaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.riprendiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.funzioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficoltàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aiutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maggioriInformazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGameOver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGameOver.Location = new System.Drawing.Point(72, 424);
            this.lblGameOver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(0, 138);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGameOver.Visible = false;
            // 
            // punt
            // 
            this.punt.AutoSize = true;
            this.punt.BackColor = System.Drawing.Color.White;
            this.punt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Bold);
            this.punt.ForeColor = System.Drawing.Color.Red;
            this.punt.Location = new System.Drawing.Point(1124, 42);
            this.punt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.punt.Name = "punt";
            this.punt.Size = new System.Drawing.Size(197, 55);
            this.punt.TabIndex = 2;
            this.punt.Text = "Score : ";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giocaToolStripMenuItem,
            this.pausaToolStripMenuItem,
            this.toolStripSeparator1,
            this.riprendiToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.esciToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(145, 61);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // giocaToolStripMenuItem
            // 
            this.giocaToolStripMenuItem.Name = "giocaToolStripMenuItem";
            this.giocaToolStripMenuItem.Size = new System.Drawing.Size(329, 62);
            this.giocaToolStripMenuItem.Text = "Gioca";
            this.giocaToolStripMenuItem.Click += new System.EventHandler(this.giocaToolStripMenuItem_Click_1);
            // 
            // pausaToolStripMenuItem
            // 
            this.pausaToolStripMenuItem.Name = "pausaToolStripMenuItem";
            this.pausaToolStripMenuItem.Size = new System.Drawing.Size(329, 62);
            this.pausaToolStripMenuItem.Text = "Pausa";
            this.pausaToolStripMenuItem.Click += new System.EventHandler(this.pausaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(326, 6);
            // 
            // riprendiToolStripMenuItem
            // 
            this.riprendiToolStripMenuItem.Enabled = false;
            this.riprendiToolStripMenuItem.Name = "riprendiToolStripMenuItem";
            this.riprendiToolStripMenuItem.Size = new System.Drawing.Size(329, 62);
            this.riprendiToolStripMenuItem.Text = "Riprendi";
            this.riprendiToolStripMenuItem.Click += new System.EventHandler(this.riprendiToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(329, 62);
            this.salvaToolStripMenuItem.Text = "Salva";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(329, 62);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.test2ToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(329, 62);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(268, 62);
            this.test1ToolStripMenuItem.Text = "Test1";
            this.test1ToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(268, 62);
            this.test2ToolStripMenuItem.Text = "Test2";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(12, 61);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.toolStripComboBox1,
            this.funzioniToolStripMenuItem,
            this.aiutoToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 24);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menu.Size = new System.Drawing.Size(1586, 69);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // funzioniToolStripMenuItem
            // 
            this.funzioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficoltàToolStripMenuItem});
            this.funzioniToolStripMenuItem.Name = "funzioniToolStripMenuItem";
            this.funzioniToolStripMenuItem.Size = new System.Drawing.Size(194, 61);
            this.funzioniToolStripMenuItem.Text = "Funzioni";
            // 
            // difficoltàToolStripMenuItem
            // 
            this.difficoltàToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facileToolStripMenuItem,
            this.medioToolStripMenuItem,
            this.difficileToolStripMenuItem,
            this.proToolStripMenuItem});
            this.difficoltàToolStripMenuItem.Name = "difficoltàToolStripMenuItem";
            this.difficoltàToolStripMenuItem.Size = new System.Drawing.Size(337, 62);
            this.difficoltàToolStripMenuItem.Text = "Difficoltà";
            // 
            // facileToolStripMenuItem
            // 
            this.facileToolStripMenuItem.Name = "facileToolStripMenuItem";
            this.facileToolStripMenuItem.Size = new System.Drawing.Size(309, 62);
            this.facileToolStripMenuItem.Text = "Facile";
            this.facileToolStripMenuItem.Click += new System.EventHandler(this.facileToolStripMenuItem_Click);
            // 
            // medioToolStripMenuItem
            // 
            this.medioToolStripMenuItem.Name = "medioToolStripMenuItem";
            this.medioToolStripMenuItem.Size = new System.Drawing.Size(309, 62);
            this.medioToolStripMenuItem.Text = "Medio";
            this.medioToolStripMenuItem.Click += new System.EventHandler(this.medioToolStripMenuItem_Click);
            // 
            // difficileToolStripMenuItem
            // 
            this.difficileToolStripMenuItem.Name = "difficileToolStripMenuItem";
            this.difficileToolStripMenuItem.Size = new System.Drawing.Size(309, 62);
            this.difficileToolStripMenuItem.Text = "Difficile";
            this.difficileToolStripMenuItem.Click += new System.EventHandler(this.difficileToolStripMenuItem_Click);
            // 
            // proToolStripMenuItem
            // 
            this.proToolStripMenuItem.Name = "proToolStripMenuItem";
            this.proToolStripMenuItem.Size = new System.Drawing.Size(309, 62);
            this.proToolStripMenuItem.Text = "Pro";
            this.proToolStripMenuItem.Click += new System.EventHandler(this.proToolStripMenuItem_Click);
            // 
            // aiutoToolStripMenuItem
            // 
            this.aiutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandiToolStripMenuItem,
            this.creditiToolStripMenuItem,
            this.maggioriInformazioniToolStripMenuItem});
            this.aiutoToolStripMenuItem.Name = "aiutoToolStripMenuItem";
            this.aiutoToolStripMenuItem.Size = new System.Drawing.Size(137, 61);
            this.aiutoToolStripMenuItem.Text = "Aiuto";
            // 
            // commandiToolStripMenuItem
            // 
            this.commandiToolStripMenuItem.Name = "commandiToolStripMenuItem";
            this.commandiToolStripMenuItem.Size = new System.Drawing.Size(587, 62);
            this.commandiToolStripMenuItem.Text = "Commandi";
            this.commandiToolStripMenuItem.Click += new System.EventHandler(this.commandiToolStripMenuItem_Click);
            // 
            // creditiToolStripMenuItem
            // 
            this.creditiToolStripMenuItem.Name = "creditiToolStripMenuItem";
            this.creditiToolStripMenuItem.Size = new System.Drawing.Size(587, 62);
            this.creditiToolStripMenuItem.Text = "Crediti";
            this.creditiToolStripMenuItem.Click += new System.EventHandler(this.creditiToolStripMenuItem_Click);
            // 
            // maggioriInformazioniToolStripMenuItem
            // 
            this.maggioriInformazioniToolStripMenuItem.Name = "maggioriInformazioniToolStripMenuItem";
            this.maggioriInformazioniToolStripMenuItem.Size = new System.Drawing.Size(587, 62);
            this.maggioriInformazioniToolStripMenuItem.Text = "Maggiori Informazioni";
            this.maggioriInformazioniToolStripMenuItem.Click += new System.EventHandler(this.maggioriInformazioniToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1586, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Gioco
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1586, 1183);
            this.Controls.Add(this.punt);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.Name = "Gioco";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Gioco_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Gioco_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gioco_KeyDown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label punt;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giocaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem funzioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aiutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maggioriInformazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficoltàToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem riprendiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
    }
}