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
    public partial class Form1 : Form
    {
        private static int kasaLength = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void 凯撒加密ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string plainText = this.textBox1.Text;
            char[] ch=plainText.ToCharArray();
            string chiperText = "";
            for (int i = 0; i < ch.Length;i++ )
            {
                chiperText += plainTextToChiperText(ch[i],3);
            }
            this.textBox2.Text = chiperText;

        }

        private void vignere加密ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string plainText = this.textBox1.Text;
            char[] ch = plainText.ToCharArray();
            string secertKey = this.textBox3.Text;
            int[] secertNum = secertKeyTosecertNum(secertKey);
            string chiperText = "";
            int count = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] != ' ')
                {
                    chiperText += plainTextToChiperText(ch[i], caculateMaJu(count, secertNum));
                    count++;
                }
                else
                {
                    chiperText += ch[i];
                }
            }
            this.textBox2.Text = chiperText;
        }

        //将密钥转化函数
        //@param  string 密钥
        //@return int[] 
        private int[] secertKeyTosecertNum(string secertKey)
        {
            char[] ch = secertKey.ToCharArray();
            int[] num = new int[ch.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'a' && ch[i] <= 'z')
                {
                    num[i] = ch[i] - 'a';
                }
                else if (ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    num[i] = ch[i] - 'A';
                }

            }
            return num;
        }


        //单个明文字符转化为密文字符
        //@param  char 明文
        //@return char 密文 
        private char plainTextToChiperText(char plainChar,int codeDistance)
        {
            if (plainChar >= 'a' && plainChar <= 'z')
            {
                return Convert.ToChar(((plainChar - 'a' + codeDistance) % 26) + 'a');
            }
            else if (plainChar >= 'A' && plainChar <= 'Z')
            {
                return Convert.ToChar(((plainChar - 'A' + codeDistance) % 26) + 'A');
            }
            else
            {
                return plainChar;
            }
        }

        //根据字符计算码距
        //@param  int 明文
        //@param  int[] 密钥码距
        //@return int 码距 
        private int caculateMaJu(int plainCharNum, int[] secertNum)
        {
            return secertNum[plainCharNum % secertNum.Length];
        } 
    }
}
