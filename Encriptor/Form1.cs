using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encriptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region RSA
        UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
        RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
        byte[] data;
        byte[] encryptData;
        byte[] Encrypt(byte[] data, RSAParameters RSAKey, bool fOAEP)
        {
            byte[] encryptedData;
            using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
            {
                rSACryptoServiceProvider.ImportParameters(RSAKey);
                encryptedData = rSACryptoServiceProvider.Encrypt(data, fOAEP);
            }
            return encryptedData;
        }
        byte[] Decrypt(byte[] data, RSAParameters RSAKey, bool fOAEP)
        {
            byte[] decryptedData;
            using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
            {
                rSACryptoServiceProvider.ImportParameters(RSAKey);
                decryptedData = rSACryptoServiceProvider.Decrypt(data, fOAEP);
            }
            return decryptedData;
        }
        private void encrsa_Click(object sender, EventArgs e)
        {
            data = unicodeEncoding.GetBytes(txtInput.Text);
            encryptData = Encrypt(data, rSACryptoServiceProvider.ExportParameters(false), false);
            txtEncrypt.Text = unicodeEncoding.GetString(encryptData);
        }

        private void desrsa_Click(object sender, EventArgs e)
        {
            byte[] data = Decrypt(encryptData, rSACryptoServiceProvider.ExportParameters(true), false);
            txtDecrypt.Text = unicodeEncoding.GetString(data);
        }
        #endregion

        #region  MD5
        private void encripmd5_Click(object sender, EventArgs e)
        {
            byte[] hashBytes = Encoding.Unicode.GetBytes(txtInputmd5.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                hashBytes = md5.ComputeHash(hashBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    stringBuilder.Append(b.ToString("X2"));
                txtEncryptmd5.Text = stringBuilder.ToString();
            }
        }
        #endregion

        #region ROT13
        public string ROT13(string input)
        {
            StringBuilder result = new StringBuilder();
            Regex regex = new Regex("[A-Za-z]");
            foreach (char c in input)
            {
                if (regex.IsMatch(c.ToString()))
                {
                    int code = ((c & 223) - 52) % 26 + (c & 32) + 65;
                    result.Append((char)code);
                }
                else
                    result.Append(c);
            }
            return result.ToString();
        }
        private void encriprot13_Click(object sender, EventArgs e)
        {
            txtEncryptROT13.Text = ROT13(txtInputROT13.Text);
        }

        private void decriptrot13_Click(object sender, EventArgs e)
        {
            txtDecryptROT13.Text = ROT13(txtEncryptROT13.Text);
        }
        #endregion

        #region BINARY
        public string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in data.ToCharArray())
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            return sb.ToString();
        }
        public string BinaryToString(string data)
        {
            List<byte> bytes = new List<byte>();
            for (int i = 0; i < data.Length; i += 8)
                bytes.Add(Convert.ToByte(data.Substring(i, 8), 2));
            return Encoding.ASCII.GetString(bytes.ToArray());
        }
        private void encripbinay_Click(object sender, EventArgs e)
        {
            txtOutputbinary.Text = StringToBinary(txtInputbinay.Text);
        }

        private void decriptbinary_Click(object sender, EventArgs e)
        {
            decript.Text = BinaryToString(txtOutputbinary.Text);
        }
        #endregion

        #region RC4
        public string RC4(string input, string key)
        {
            StringBuilder result = new StringBuilder();
            int x, y, j = 0;
            int[] box = new int[256];
            for (int i = 0; i < 256; i++)
                box[i] = i;
            for (int i = 0; i < 256; i++)
            {
                j = (key[i % key.Length] + box[i] + j) % 256;
                x = box[i];
                box[i] = box[j];
                box[j] = x;
            }
            for (int i = 0; i < input.Length; i++)
            {
                y = i % 256;
                j = (box[y] + j) % 256;
                x = box[y];
                box[y] = box[j];
                box[j] = x;
                result.Append((char)(input[i] ^ box[(box[y] + box[j]) % 256]));
            }
            return result.ToString();
        }
        private void encriptrc4_Click(object sender, EventArgs e)
        {
            txtEncryptrc4.Text = RC4(txtInputrc4.Text, txtLlave.Text);
        }

        private void deciptrc4_Click(object sender, EventArgs e)
        {
            txtDecryptrc4.Text = RC4(txtEncryptrc4.Text, txtLlave.Text);
        }
        #endregion

        #region 3DES
        public string Encrypt(string source, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    byte[] data = Encoding.Unicode.GetBytes(source);
                    return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }

        public static string Decrypt(string encrypt, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    byte[] byteBuff = Convert.FromBase64String(encrypt);
                    return Encoding.Unicode.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
                }
            }
        }
        private void encri3des_Click(object sender, EventArgs e)
        {
            txtEncrypt3des.Text = Encrypt(txtInput3des.Text, txtKey.Text);
        }

        private void decript3des_Click(object sender, EventArgs e)
        {
            txtDecrypt3des.Text = Decrypt(txtEncrypt3des.Text, txtKey.Text);
        }
        #endregion

        #region CONTRASEÑA
        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERIC = "1234567890";
        const string SPECIAL_CHARACTER = @"~!@#$%^&*()+=-";
        public string PasswordGenerator(bool lowerCase, bool upperCase, bool mumberic, bool specialCharacter, int length)
        {
            char[] password = new char[length];
            string charSet = "";
            System.Random _random = new Random();
            if (lowerCase)
                charSet += LOWER_CASE;
            if (upperCase)
                charSet += UPPER_CASE;
            if (mumberic)
                charSet += NUMBERIC;
            if (specialCharacter)
                charSet += SPECIAL_CHARACTER;
            for (int i = 0; i < length; i++)
                password[i] = charSet[_random.Next(charSet.Length - 1)];
            return string.Join(null, password);
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                txtPassword.Text = PasswordGenerator(chkLowerCase.Checked, chkUpperCase.Checked, chkNumeric.Checked, chkSpecical.Checked, int.Parse(txtPasswordLength.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopyPass_Click(object sender, EventArgs e)
        {
            txtPassword.Copy();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPasswordLength.Clear();
        }
#endregion
    }
}
