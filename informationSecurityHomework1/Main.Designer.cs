namespace informationSecurityHomework1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.散列函数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数字签名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.rSAToolStripMenuItem,
            this.散列函数ToolStripMenuItem,
            this.数字签名ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "古典";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(43, 21);
            this.toolStripMenuItem2.Text = "DES";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.rSAToolStripMenuItem.Text = "RSA";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.rSAToolStripMenuItem_Click);
            // 
            // 散列函数ToolStripMenuItem
            // 
            this.散列函数ToolStripMenuItem.Name = "散列函数ToolStripMenuItem";
            this.散列函数ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.散列函数ToolStripMenuItem.Text = "散列函数";
            this.散列函数ToolStripMenuItem.Click += new System.EventHandler(this.散列函数ToolStripMenuItem_Click);
            // 
            // 数字签名ToolStripMenuItem
            // 
            this.数字签名ToolStripMenuItem.Name = "数字签名ToolStripMenuItem";
            this.数字签名ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数字签名ToolStripMenuItem.Text = "数字签名";
            this.数字签名ToolStripMenuItem.Click += new System.EventHandler(this.数字签名ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 385);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "华南农业大学信息安全综合性实验";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 散列函数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数字签名ToolStripMenuItem;
    }
}