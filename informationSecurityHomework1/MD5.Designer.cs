namespace informationSecurityHomework1
{
    partial class MD5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.encryption = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.plaintext = new System.Windows.Forms.Label();
            this.ciphertext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 243);
            this.textBox1.TabIndex = 0;
            // 
            // encryption
            // 
            this.encryption.Location = new System.Drawing.Point(213, 176);
            this.encryption.Name = "encryption";
            this.encryption.Size = new System.Drawing.Size(75, 23);
            this.encryption.TabIndex = 2;
            this.encryption.Text = "散列加密";
            this.encryption.UseVisualStyleBackColor = true;
            this.encryption.Click += new System.EventHandler(this.encryption_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 60);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 243);
            this.textBox2.TabIndex = 3;
            // 
            // plaintext
            // 
            this.plaintext.AutoSize = true;
            this.plaintext.Location = new System.Drawing.Point(65, 33);
            this.plaintext.Name = "plaintext";
            this.plaintext.Size = new System.Drawing.Size(41, 12);
            this.plaintext.TabIndex = 4;
            this.plaintext.Text = "明文：";
            // 
            // ciphertext
            // 
            this.ciphertext.AutoSize = true;
            this.ciphertext.Location = new System.Drawing.Point(387, 33);
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.Size = new System.Drawing.Size(41, 12);
            this.ciphertext.TabIndex = 5;
            this.ciphertext.Text = "密文：";
            // 
            // MD5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 369);
            this.Controls.Add(this.ciphertext);
            this.Controls.Add(this.plaintext);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.encryption);
            this.Controls.Add(this.textBox1);
            this.Name = "MD5";
            this.Text = "MD5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button encryption;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label plaintext;
        private System.Windows.Forms.Label ciphertext;
    }
}