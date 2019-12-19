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

namespace RSAtools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonNewRSA_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            textBoxPrivateKey.Text = Convert.ToBase64String(rsa.ExportCspBlob(true));
            textBoxPublicKey.Text = Convert.ToBase64String(rsa.ExportCspBlob(false));
        }

        private RSACryptoServiceProvider loadRSA(String key)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] keyBytes = Convert.FromBase64String(key);
            rsa.ImportCspBlob(keyBytes);
            return rsa;
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bt = Encoding.GetEncoding("utf-8").GetBytes(textBoxTextForSign.Text);
                var sha256 = new SHA256CryptoServiceProvider();
                byte[] rgbHash = sha256.ComputeHash(bt);
                RSAPKCS1SignatureFormatter formatter = new RSAPKCS1SignatureFormatter(loadRSA(textBoxPrivateKeyForSign.Text));
                formatter.SetHashAlgorithm("SHA256");
                byte[] inArray = formatter.CreateSignature(rgbHash);
                textBoxSignedForSign.Text = Convert.ToBase64String(inArray);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonSignCheck_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bt = Encoding.GetEncoding("utf-8").GetBytes(textBoxTextForSignCheck.Text);
                var sha256 = new SHA256CryptoServiceProvider();
                byte[] rgbHash = sha256.ComputeHash(bt);
                RSAPKCS1SignatureDeformatter deformatter = new RSAPKCS1SignatureDeformatter(loadRSA(textBoxPublicKeyForSignCheck.Text));
                deformatter.SetHashAlgorithm("SHA256");
                byte[] rgbSignature = Convert.FromBase64String(textBoxSignedTextForSignCheck.Text);
                if (deformatter.VerifySignature(rgbHash, rgbSignature))
                {
                    labelMsgForSignCheck.Text = "OK";
                }
                else
                {
                    labelMsgForSignCheck.Text = "NOK";
                }
            }
            catch
            {
                labelMsgForSignCheck.Text = "Error";
            }
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] encryptedData = loadRSA(textBoxPublicKeyForEncode.Text).Encrypt(Encoding.GetEncoding("utf-8").GetBytes(textBoxTextForEncode.Text), false);
                textBoxEncodeForEncode.Text = Convert.ToBase64String(encryptedData);
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] decryptedData = loadRSA(textBoxPrivateKeyForDecode.Text).Decrypt(Convert.FromBase64String(textBoxEncodeTextForDecode.Text), false);
                textBoxTextForDecode.Text = Encoding.GetEncoding("utf-8").GetString(decryptedData);
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void buttonSavePriKey_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Files (*.key;*.txt)|*.key;*.txt";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveDialog.FileName))
                {
                    streamWriter.Write(textBoxPrivateKey.Text);//
                }
            }
        }

        private void buttonSavePubKey_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Files (*.key;*.txt)|*.key;*.txt";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveDialog.FileName))
                {
                    streamWriter.Write(textBoxPublicKey.Text);//
                }
            }
        }

        private void buttonOpenPrivateForSign_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Files (*.key;*.txt)|*.key;*.txt";
            openDialog.Multiselect = false;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openDialog.FileName);
                textBoxPrivateKeyForSign.Text = streamReader.ReadToEnd();
            }
        }

        private void buttonOpenPublicKeyForSigncheck_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Files (*.key;*.txt)|*.key;*.txt";
            openDialog.Multiselect = false;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openDialog.FileName);
                textBoxPublicKeyForSignCheck.Text = streamReader.ReadToEnd();
            }
        }

        private void buttonOpenPublicKeyForEncode_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Files (*.key;*.txt)|*.key;*.txt";
            openDialog.Multiselect = false;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openDialog.FileName);
                textBoxPublicKeyForEncode.Text = streamReader.ReadToEnd();
            }
        }

        private void buttonOpenPrivateKeyForDecode_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Files (*.key;*.txt)|*.key;*.txt";
            openDialog.Multiselect = false;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openDialog.FileName);
                textBoxPrivateKeyForDecode.Text = streamReader.ReadToEnd();
            }
        }
    }
}