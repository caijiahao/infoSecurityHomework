using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace informationSecurityHomework1
{
    public partial class RSA : Form
    {
        private RSACryptoServiceProvider B;//发送方
        byte[] messagebytes;
        byte[] rsa;
        public RSA()
        {
            InitializeComponent();
            B = new RSACryptoServiceProvider();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = this.textBox1.Text;
            messagebytes = Encoding.UTF8.GetBytes(text);
            rsa = B.Encrypt(messagebytes, false);
            this.textBox2.Text = Encoding.UTF8.GetString(rsa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = Encoding.UTF8.GetString(B.Decrypt(rsa, false));
        }

        private void RSA_Load(object sender, EventArgs e)
        {

        }
    }
}
