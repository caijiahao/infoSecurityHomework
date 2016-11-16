using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace informationSecurityHomework1
{
    public partial class MD5 : Form
    {
        public MD5()
        {
            InitializeComponent();
        }

        private void encryption_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = MD(this.textBox1.Text);
        }

        /// <summary>  
        /// 字符串MD5加密  
        /// </summary>  
        /// <param name="Text">要加密的字符串</param>  
        /// <returns>密文</returns>  
        public static string MD(string Text)
        {
            byte[] buffer = System.Text.Encoding.Default.GetBytes(Text);
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider check;
                check = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] somme = check.ComputeHash(buffer);
                string ret = "";
                foreach (byte a in somme)
                {
                    if (a < 16)
                        ret += "0" + a.ToString("X");
                    else
                        ret += a.ToString("X");
                }
                return ret.ToLower();
            }
            catch
            {
                throw;
            }
        }  
    }
}
