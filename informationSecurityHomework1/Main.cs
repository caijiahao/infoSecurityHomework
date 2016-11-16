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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void 散列函数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MD5 md5 = new MD5();
            md5.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DES des = new DES();
            des.ShowDialog();
        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RSA().ShowDialog();
        }

        private void 数字签名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Sender().ShowDialog();
        }

       
    }
}
