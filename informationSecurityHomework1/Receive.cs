using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace informationSecurityHomework1
{
    public partial class Receive : Form
    {
        private RSACryptoServiceProvider B;
        private readonly string _msString = "";
        private string _desKey = "";
        private readonly string _strPrivateKey;
        string _strDataToSign, _strSignedData, _strPublicKey;
        private readonly byte[] _des;
        public Receive()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public Receive(RSACryptoServiceProvider b, string msString, byte[] deString)
        {
            B = b;
            _des = deString;
            InitializeComponent();
            _msString = msString;
            _strPrivateKey = Convert.ToBase64String(B.ExportCspBlob(true));
            txtPrivateKey.Text = _strPrivateKey;
        }

        //DSE解密
        public static string DesDecrypt(string str, string key)
        {

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = new byte[str.Length / 2];
            for (int x = 0; x < str.Length / 2; x++)
            {
                int i = (Convert.ToInt32(str.Substring(x * 2, 2), 16));
                inputByteArray[x] = (byte)i;
            }
            des.Key = Encoding.ASCII.GetBytes(key);
            des.IV = Encoding.ASCII.GetBytes(key);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Encoding.UTF8.GetString(ms.ToArray());
        }

        //验证数字签名
        public static bool VerifySignature(string strDataToSign, string strSignedData, string strPublicKey)
        {
            try
            {
                byte[] signedData = Convert.FromBase64String(strSignedData);
                ASCIIEncoding byteConverter = new ASCIIEncoding();
                byte[] dataToSign = byteConverter.GetBytes(strDataToSign);
                RSACryptoServiceProvider rsAalg = new RSACryptoServiceProvider();
                rsAalg.ImportCspBlob(Convert.FromBase64String(strPublicKey));

                return rsAalg.VerifyData(dataToSign, new SHA1CryptoServiceProvider(), signedData);
            }
            catch (FormatException)
            {
                return true;
            }
            catch (CryptographicException e)
            {
                MessageBox.Show(e.Message, @"验证数字签名过程出错！");
                return false;
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            //RSA解密DES key          
            _desKey = Encoding.UTF8.GetString(B.Decrypt(_des, false));
            textBoxDESKey.Text = _desKey;
            string msg = DesDecrypt(_msString, _desKey);
            //拆
            string[] result = msg.Split('#');
            _strDataToSign = result[0];
            _strSignedData = result[1];
            _strPublicKey = result[2];
            string line = Environment.NewLine;
            textBoxMessage.Text += @"原文：" + _strDataToSign + line + line;
            textBoxMessage.Text += @"数字签名：" + _strSignedData + line + line;
            textBoxMessage.Text += @"公钥：" + _strPublicKey;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbResult.Text = VerifySignature(_strDataToSign, _strSignedData, _strPublicKey) ? "验证签名成功！" : "签名不匹配！";
        }





    }
}
