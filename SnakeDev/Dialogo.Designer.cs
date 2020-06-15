namespace SnakeDev
{
    partial class Dialogo
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
            this.lbl = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(41, 79);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(141, 32);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Nickname";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(517, 48);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(184, 98);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(219, 79);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(251, 38);
            this.txt.TabIndex = 4;
            // 
            // Dialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 212);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbl);
            this.Name = "Dialogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialogo";
            this.Load += new System.EventHandler(this.Dialogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txt;
    }
}