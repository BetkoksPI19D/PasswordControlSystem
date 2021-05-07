using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystem
{
    class Encryption
    {
        public string Encrypt(string strWord, string strKey, bool ECB)
        {
            byte[] key = new byte[8];
            byte[] byteArray;
            byte[] hash;
            byte[] setIV = { 10, 20, 30, 40, 50, 60, 70, 80 };

            try
            {
                MD5CryptoServiceProvider hsh = new MD5CryptoServiceProvider();
                hash = hsh.ComputeHash(Encoding.ASCII.GetBytes(strKey));
                for (int i = 0; i < 8; i++)
                    key[i] = hash[i];
                DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                if (ECB == true)
                {
                    DES.Mode = CipherMode.ECB;
                    DES.Key = key;
                }
                else
                {
                    DES.Mode = CipherMode.CBC;
                    DES.Key = key;
                    DES.IV = setIV;
                }
                byteArray = Encoding.ASCII.GetBytes(strWord);
                MemoryStream memStream = new MemoryStream();
                CryptoStream cryStream = new CryptoStream(memStream, DES.CreateEncryptor(), CryptoStreamMode.Write);
                cryStream.Write(byteArray, 0, byteArray.Length);
                cryStream.FlushFinalBlock();

                return Convert.ToBase64String(memStream.ToArray());

            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
        public string Decrypt(string strWord, string strKey, bool ECB)
        {
            byte[] setIV = { 10, 20, 30, 40, 50, 60, 70, 80 };
            byte[] key = new byte[8];
            byte[] byteArray = new byte[strWord.Length];
            byte[] hash;

            try
            {
                MD5CryptoServiceProvider hsh = new MD5CryptoServiceProvider();
                hash = hsh.ComputeHash(Encoding.ASCII.GetBytes(strKey));

                for (int i = 0; i < 8; i++)
                    key[i] = hash[i];

                DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                if (ECB == true)
                {
                    DES.Mode = CipherMode.ECB;
                    DES.Key = key;
                }
                else
                {
                    DES.Mode = CipherMode.CBC;
                    DES.Key = key;
                    DES.IV = setIV;
                }
                byteArray = Convert.FromBase64String(strWord);
                MemoryStream memStream = new MemoryStream();
                CryptoStream cryStream = new CryptoStream(memStream, DES.CreateDecryptor(), CryptoStreamMode.Write);
                cryStream.Write(byteArray, 0, byteArray.Length);
                cryStream.FlushFinalBlock();

                Encoding encode = Encoding.ASCII;
                return encode.GetString(memStream.ToArray());

            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
