namespace informationSecurityHomework1
{
    partial class Receive
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxDESKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.labelBPBK = new System.Windows.Forms.Label();
            this.labelAPBK = new System.Windows.Forms.Label();
            this.labelAPRK = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbResult);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBoxMessage);
            this.groupBox2.Controls.Add(this.buttonDecrypt);
            this.groupBox2.Controls.Add(this.textBoxDESKey);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 335);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DES解密";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(19, 277);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 12);
            this.lbResult.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "验证签名";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(5, 53);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(593, 191);
            this.textBoxMessage.TabIndex = 7;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(523, 18);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 6;
            this.buttonDecrypt.Text = "解密";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textBoxDESKey
            // 
            this.textBoxDESKey.Location = new System.Drawing.Point(68, 20);
            this.textBoxDESKey.Name = "textBoxDESKey";
            this.textBoxDESKey.Size = new System.Drawing.Size(438, 21);
            this.textBoxDESKey.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "密钥：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPrivateKey);
            this.groupBox1.Controls.Add(this.labelBPBK);
            this.groupBox1.Controls.Add(this.labelAPBK);
            this.groupBox1.Controls.Add(this.labelAPRK);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSA-Key密钥";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(5, 20);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(598, 125);
            this.txtPrivateKey.TabIndex = 6;
            // 
            // labelBPBK
            // 
            this.labelBPBK.AutoSize = true;
            this.labelBPBK.Location = new System.Drawing.Point(304, 26);
            this.labelBPBK.Name = "labelBPBK";
            this.labelBPBK.Size = new System.Drawing.Size(0, 12);
            this.labelBPBK.TabIndex = 5;
            // 
            // labelAPBK
            // 
            this.labelAPBK.AutoSize = true;
            this.labelAPBK.Location = new System.Drawing.Point(92, 52);
            this.labelAPBK.Name = "labelAPBK";
            this.labelAPBK.Size = new System.Drawing.Size(0, 12);
            this.labelAPBK.TabIndex = 3;
            // 
            // labelAPRK
            // 
            this.labelAPRK.AutoSize = true;
            this.labelAPRK.Location = new System.Drawing.Point(92, 26);
            this.labelAPRK.Name = "labelAPRK";
            this.labelAPRK.Size = new System.Drawing.Size(0, 12);
            this.labelAPRK.TabIndex = 2;
            // 
            // Receive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Receive";
            this.Text = "Receive";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxDESKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label labelBPBK;
        private System.Windows.Forms.Label labelAPBK;
        private System.Windows.Forms.Label labelAPRK;
    }
}