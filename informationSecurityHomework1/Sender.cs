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
    public partial class Sender: Form
    {
        private RSACryptoServiceProvider B;//发送方
        private readonly string _publicKey = "";
        private byte[] _des;
        private readonly string _strPrivateKey;
        private readonly string _strPublicKey;
        public Sender()
        {
            InitializeComponent();
            RSACryptoServiceProvider A = new RSACryptoServiceProvider();
            _strPrivateKey = Convert.ToBase64String(A.ExportCspBlob(true));
            _strPublicKey = Convert.ToBase64String(A.ExportCspBlob(false));

            B = new RSACryptoServiceProvider();
            _publicKey = Convert.ToBase64String(B.ExportCspBlob(false));
            string line = Environment.NewLine;
            txtKey.Text += @"原文加密私钥：" + _strPrivateKey + line + line;
            txtKey.Text += @"原文解密公钥：" + _strPublicKey + line + line;
            txtKey.Text += @"DES Key加密公钥：" + _publicKey;
        }


        //创建数字签名
        public static string CreateSignature(string strDataToSign, string strPrivateKey)
        {
            ASCIIEncoding byteConverter = new ASCIIEncoding();
            byte[] dataToSign = byteConverter.GetBytes(strDataToSign);
            try
            {
                RSACryptoServiceProvider rsAalg = new RSACryptoServiceProvider();
                rsAalg.ImportCspBlob(Convert.FromBase64String(strPrivateKey));
                byte[] signedData = rsAalg.SignData(dataToSign, new SHA1CryptoServiceProvider());
                string strSignedData = Convert.ToBase64String(signedData);
                return strSignedData;
            }
            catch (CryptographicException e)
            {
                MessageBox.Show(e.Message, @"创建数字签名过程出错！");
                return null;
            }
        }

        //DES加密
        public static string DesEncrypt(string str, string key)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.UTF8.GetBytes(str);
            des.Key = Encoding.ASCII.GetBytes(key);
            des.IV = Encoding.ASCII.GetBytes(key);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();

            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:x2}", b);
            }
            return ret.ToString();
        }

        private void Sender_Load(object sender, EventArgs e)
        {

        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string strDataToSign = textBoxMessage.Text;
            string strSignedData = CreateSignature(strDataToSign, _strPrivateKey);
            string str = strDataToSign + "#" + strSignedData + "#" + _strPublicKey;
            string key = textBoxDESKey.Text;
            string strEncrypt = DesEncrypt(str, key);
            string strSend = strEncrypt;
            //RSA加密DES key
            _des = B.Encrypt(Encoding.UTF8.GetBytes(key), false);
            textBoxEncrypt.Text = strSend;
        }

        private void buttonSender_Click(object sender, EventArgs e)
        {
            new Receive(B, textBoxEncrypt.Text, _des).ShowDialog();
        }

    }
}
