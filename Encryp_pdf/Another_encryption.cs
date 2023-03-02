using System;
using System.Security.Cryptography;

namespace Encryp_pdf
{
    public class Another_encryption
    {
        public static void encrypt02()
        {
            string inputFile = "./file/Theory Inner.pdf";
            string outputFile = "./Output_file/output.pdf";
            string password = "my_password";

            // Generate a key and IV from the password
            Rfc2898DeriveBytes keyGenerator = new Rfc2898DeriveBytes(password, 16, 1000);
            byte[] key = keyGenerator.GetBytes(16);
            byte[] iv = keyGenerator.GetBytes(16);

            // Create the encryption algorithm
            Aes encryptionAlgorithm = Aes.Create();

            // Set the key and IV
            encryptionAlgorithm.Key = key;
            encryptionAlgorithm.IV = iv;

            // Create the encryption stream
            using (FileStream inputStream = new FileStream(inputFile, FileMode.Open))
            using (FileStream outputStream = new FileStream(outputFile, FileMode.Create))
            using (ICryptoTransform encryptor = encryptionAlgorithm.CreateEncryptor())
            using (CryptoStream cryptoStream = new CryptoStream(outputStream, encryptor, CryptoStreamMode.Write))
            {
                // Write the IV to the output stream
                outputStream.Write(iv, 0, iv.Length);

                // Encrypt the input stream and write to the output stream
                inputStream.CopyTo(cryptoStream);
            }

            // Clean up
            encryptionAlgorithm.Dispose();
        }

        public static void decrypt02()
        {
            string inputFile = "./Output_file/output.pdf";
            string outputFile = "./decrypted/Theory_Inner.pdf";
            string password = "my_password";

            try
            {
                // Generate a key and IV from the password
                Rfc2898DeriveBytes keyGenerator = new Rfc2898DeriveBytes(password, 16, 1000);
                byte[] key = keyGenerator.GetBytes(16);
                byte[] iv = new byte[16];
    
                // Read the IV from the input file
                using (FileStream inputStream = new FileStream(inputFile, FileMode.Open))
                {
                    inputStream.Read(iv, 0, iv.Length);
                }
    
                // Create the encryption algorithm
                Aes decryptionAlgorithm = Aes.Create();
    
                // Set the key and IV
                decryptionAlgorithm.Key = key;
                decryptionAlgorithm.IV = iv;
    
                // Create the encryption stream
                using (FileStream inputStream = new FileStream(inputFile, FileMode.Open))
                using (FileStream outputStream = new FileStream(outputFile, FileMode.Create))
                using (ICryptoTransform decryptor = decryptionAlgorithm.CreateDecryptor())
                using (CryptoStream cryptoStream = new CryptoStream(inputStream, decryptor, CryptoStreamMode.Read))
                {
                    // Decrypt the input stream and write to the output stream
                    cryptoStream.CopyTo(outputStream);
                }
    
                // Clean up
                decryptionAlgorithm.Dispose();
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
        }
    }
}