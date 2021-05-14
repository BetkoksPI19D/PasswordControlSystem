using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSystem
{
    class FileCryption
    {
        private string psw = "key";
        //public void Encrypt(string path)
        //{

        //    MD5 MD5 = MD5.Create();
        //    byte[] md5;
        //    var files = Directory.GetFiles($@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\{LogInControl.loggedInUsername}.txt");
        //    string hash;
        //    foreach (var file in files)
        //    {
        //        FileEcnryption(file, psw);
        //        md5 = MD5.ComputeHash(File.ReadAllBytes(file + ".aes"));
        //        hash = BitConverter.ToString(md5).Replace("-", string.Empty);
        //        File.Delete(file);
        //        Thread.Sleep(500);

        //    }
        //}
        //private void Decrypt()
        //{
        //    MD5 MD5 = MD5.Create();
        //    string hash;
        //    byte[] md5;
        //    var files = Directory.GetFiles($@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\{LogInControl.loggedInUsername}.txt");
        //    string[] hshes = File.ReadAllLines(@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Daugiagijis\AES_FolderToUse\hash.txt");
        //    foreach (string file in files)
        //    {
        //        md5 = MD5.ComputeHash(File.ReadAllBytes(file));
        //        hash = BitConverter.ToString(md5).Replace("-", string.Empty);
        //        foreach (string line in hshes)
        //        {
        //            if (hash == line)
        //            {
        //                FileDecryption(file, file.Remove(file.Length - 4), psw);
        //                File.Delete(file);
        //            }
        //        }
        //    }
        //}
        public void FileEcnryption(string inputFiles, string psw)
        {
            byte[] salt = SaltGenerator();
            byte[] keys = Encoding.UTF8.GetBytes(psw);
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.Padding = PaddingMode.PKCS7;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(psw, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Mode = CipherMode.CFB;

            using (FileStream fStream = new FileStream(inputFiles + ".aes", FileMode.Create))
            {
                fStream.Write(salt, 0, salt.Length);
                using (CryptoStream cStream = new CryptoStream(fStream, AES.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using (FileStream fStreamIN = new FileStream(inputFiles, FileMode.Open))
                    {
                        byte[] buff = new byte[100000];
                        int a;
                        while ((a = fStreamIN.Read(buff, 0, buff.Length)) > 0)
                        {
                            cStream.Write(buff, 0, a);
                        }
                    }
                }
            }
            File.Delete(inputFiles);
        }
        public void FileDecryption(string inputFiles, string outputFiles, string psw)
        {
            byte[] keys = Encoding.UTF8.GetBytes(psw);
            byte[] salt = new byte[32];

            using (FileStream fStream = new FileStream(inputFiles, FileMode.Open))
            {
                fStream.Read(salt, 0, salt.Length);
                RijndaelManaged AES = new RijndaelManaged();
                AES.BlockSize = 128;
                AES.KeySize = 256;
                var key = new Rfc2898DeriveBytes(keys, salt, 50000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                AES.Mode = CipherMode.CFB;

                using (CryptoStream cStream = new CryptoStream(fStream, AES.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    using (FileStream fileStream = new FileStream(outputFiles, FileMode.Create))
                    {
                        int a;
                        byte[] buff = new byte[100000];
                        while ((a = cStream.Read(buff, 0, buff.Length)) > 0)
                        {
                            fileStream.Write(buff, 0, a);
                        }
                    }
                }
            }
            File.Delete(inputFiles);
        }
        public static byte[] SaltGenerator()
        {
            byte[] input = new byte[32];
            using (RNGCryptoServiceProvider rngProvider = new RNGCryptoServiceProvider())
            {
                rngProvider.GetBytes(input);
            }
            return input;
        }

    }
}
